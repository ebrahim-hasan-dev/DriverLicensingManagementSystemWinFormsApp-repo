using DLMApp_BusinessLayer;
using DLMApp_ModulesLayer;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DLMApp_PresentationLayer.Properties;

namespace DLMApp_PresentationLayer
{
    public partial class uctrlAddOrUpdatePerson : UserControl
    {
        // ==========================================================================

        public bool AddedSuccessfully = false;
        public int PersonID { get; set; }

        clsPerson _Person = null;

        string _OldPhone1 = "";
        string _OldPhone2 = "";

        bool _NationalNumberExist = true;
        bool _Phone1Exist = true;
        bool _Phone2Exist = true;
        bool _EmailExist = true;
        bool _EmailCorrectFormat = false;

        bool _IsUpdatePerson = false;

        List<clsCountry> _ListOfCountries = null;

        public event Action<clsPerson> AddedEventHandler;

        // ==========================================================================


        protected virtual void OnAddedEventHandler(clsPerson Person)
        {
            AddedEventHandler?.Invoke(Person);
        }

        public uctrlAddOrUpdatePerson()
        {
            InitializeComponent();
            
            LoadAllCountries();
        }

        void LoadAllCountries()
        {
            _ListOfCountries = CountryService.GetAllCountries();

            for (int i = 0; i < _ListOfCountries.Count; i++)
            {
                cbCountries.Items.Add(_ListOfCountries[i].Name);
            }

            cbCountries.SelectedIndex = cbCountries.FindString("Egypt");
        }

        void Reset()
        {
            lbPersonIDResult.Text = "[???]";

            txtbFirstName.Clear();
            txtbSecondName.Clear();
            txtbThirdName.Clear();
            txtbLastName.Clear();
            txtbEmail.Clear();
            mtxtbNationalNumber.Clear();
            txtbAddress.Clear();
            mtxtbPhone1.Clear();
            mtxtbPhone2.Clear();

            pctbNewPerson.Image = null;

            openFileDialog1.FileName = "";

            cbCountries.SelectedIndex = cbCountries.FindString("Egypt");

            rbFemale.Checked = false;
            rbMale.Checked = false;

            dtpDateOfBirth.Value = new DateTime(2000, 1, 1);

            btSave.Enabled = false;

            _Phone1Exist = true;
            _Phone2Exist = true;
            _NationalNumberExist = true;
            _EmailExist = true;
            _EmailCorrectFormat = false;

            _IsUpdatePerson = false;

            txtbFirstName.Focus();
        }

        void FillPerson(clsPerson Person)
        {
            Person.FirstName = txtbFirstName.Text;
            Person.SecondName = txtbSecondName.Text;
            Person.ThirdName = txtbThirdName.Text;
            Person.LastName = txtbLastName.Text;
            Person.Email = txtbEmail.Text;
            Person.Address = txtbAddress.Text;
            Person.NationalNumber = mtxtbNationalNumber.Text;
            Person.DateOfBirth = dtpDateOfBirth.Value;
            Person.ImagePath = openFileDialog1.FileName;
            Person.Country = cbCountries.Text;

            Person.NationalityCountryID = _ListOfCountries.Find(x => x.Name == cbCountries.Text).ID;

            if (rbMale.Checked)
            {
                Person.Gender = "Male";
            }
            else
            {
                Person.Gender = "Female";
            }

            Person.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (mtxtbPhone1.MaskCompleted)
            {
                Person.Phone1 = mtxtbPhone1.Text;
            }

            if (mtxtbPhone2.MaskCompleted)
            {
                Person.Phone2 = mtxtbPhone2.Text;
            }
        }

        void AddNewPersonProcess()
        {
            clsPerson Person = new clsPerson();

            FillPerson(Person);

            if (Person.IsFull())
            {
                if (PersonService.AddNewPerson(Person))
                {
                    lbPersonIDResult.Text = Person.PersonID.ToString();

                    PersonID = Person.PersonID;
                    AddedSuccessfully = true;

                    OnAddedEventHandler(Person);

                    MessageBox.Show($"Operation completed successfully with ID ({Person.PersonID})", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Reset();
                }
                else
                {
                    MessageBox.Show("The addition operation failed", "Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                fmLoginScreen.ShowMissingMessage();
            }
        }

        void UpdatePersonHelper()
        {
            _Person.FirstName = txtbFirstName.Text;
            _Person.SecondName = txtbSecondName.Text;
            _Person.ThirdName = txtbThirdName.Text;
            _Person.LastName = txtbLastName.Text;
            _Person.Email = txtbEmail.Text;
            _Person.Address = txtbAddress.Text;
            _Person.NationalNumber = mtxtbNationalNumber.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.ImagePath = openFileDialog1.FileName;
            _Person.Country = cbCountries.Text;

            _Person.NationalityCountryID = _ListOfCountries.Find(x => x.Name == cbCountries.Text).ID;

            if (rbMale.Checked)
            {
                _Person.Gender = "Male";
            }
            else
            {
                _Person.Gender = "Female";
            }

            if (mtxtbPhone1.MaskCompleted)
            {
                _Person.Phone1 = mtxtbPhone1.Text;
            }

            if (mtxtbPhone2.MaskCompleted)
            {
                _Person.Phone2 = mtxtbPhone2.Text;
            }
        }

        void UpdatePersonProcess()
        {
            UpdatePersonHelper();

            if (_Person.IsFull())
            {
                if (PersonService.UpdatePerson(_Person.PersonID, _OldPhone1, _OldPhone2,  _Person))
                {
                    OnAddedEventHandler(_Person);

                    MessageBox.Show("Operation completed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Reset();
                }
                else
                {
                    MessageBox.Show("The addition operation failed", "Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                fmLoginScreen.ShowMissingMessage();
            }
        }
        
        private void btSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbFirstName.Text) && !string.IsNullOrWhiteSpace(txtbSecondName.Text) &&
                !string.IsNullOrWhiteSpace(txtbThirdName.Text) && !string.IsNullOrWhiteSpace(txtbLastName.Text) &&
                mtxtbNationalNumber.MaskCompleted && !string.IsNullOrWhiteSpace(txtbAddress.Text) &&
                !string.IsNullOrWhiteSpace(openFileDialog1.FileName) &&
                (mtxtbPhone1.MaskCompleted || mtxtbPhone2.MaskCompleted) && (rbFemale.Checked || rbMale.Checked))
            {
                if (_IsUpdatePerson == true)
                {
                    UpdatePersonProcess();
                }
                else
                {
                    AddNewPersonProcess();
                }
            }
            else
            {
                fmLoginScreen.ShowMissingMessage();
            }
        }
        
        private void llbSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (_IsUpdatePerson == true && _Person != null)
                {
                    if (File.Exists(_Person.ImagePath))
                    {
                        File.Delete(_Person.ImagePath);
                    }
                }

                //pctbNewPerson.ImageLocation = openFileDialog1.FileName;
                pctbNewPerson.Image = clsGlobal.LoadImageNoLock(openFileDialog1.FileName);
                
                string ImagesPath = $"D:\\Visual Studio 2022 Projects\\DLMApp_WindowsForms\\People Images\\Guid{Guid.NewGuid()}" + Path.GetExtension(openFileDialog1.FileName);


                File.Copy(openFileDialog1.FileName, ImagesPath, true);

                openFileDialog1.FileName = ImagesPath;
            }
        }

        bool CheckFromUniqueInputs()
        {
            bool IsUnique = false;

            if (_NationalNumberExist == false)
            {
                if (mtxtbPhone1.MaskCompleted)
                {
                    if (_Phone1Exist == false)
                        IsUnique = true;
                    else
                        return false;
                }

                if (mtxtbPhone2.MaskCompleted)
                {
                    if (_Phone2Exist == false)
                        IsUnique = true;
                    else
                        return false;
                }

                if (string.IsNullOrWhiteSpace(txtbEmail.Text) == false)
                {
                    if (_EmailExist == false && _EmailCorrectFormat == true)
                        IsUnique = true;
                    else
                        return false;
                }
            }

            return IsUnique;
        }

        private void mtxtbNationalNumber_Validating(object sender, CancelEventArgs e)
        {
            if (_IsUpdatePerson && _Person.NationalNumber == mtxtbNationalNumber.Text)
            {
                _NationalNumberExist = false;
                errorProvider1.SetError(mtxtbNationalNumber, "");
            }
            else
            {
                if (mtxtbNationalNumber.MaskCompleted)
                {
                    if (PersonService.NationalNumberExist(mtxtbNationalNumber.Text))
                    {
                        errorProvider1.SetError(mtxtbNationalNumber, $"this national number ({mtxtbNationalNumber.Text}) is already exist");
                        btSave.Enabled = false;
                        _NationalNumberExist = true;
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(mtxtbNationalNumber, "");
                        _NationalNumberExist = false;
                    }
                }
            }

            if (CheckFromUniqueInputs())
            {
                btSave.Enabled = true;
            }
        }

        private void mtxtbPhone1_Validating(object sender, CancelEventArgs e)
        {
            if (_IsUpdatePerson && _Person.Phone1 == mtxtbPhone1.Text)
            {
                _Phone1Exist = false;
                errorProvider1.SetError(mtxtbPhone1, "");
            }
            else
            {
                if (mtxtbPhone1.MaskCompleted)
                {
                    if (mtxtbPhone2.Text == mtxtbPhone1.Text)
                    {
                        errorProvider1.SetError(mtxtbPhone1, $"this phone number ({mtxtbPhone1.Text}) same phone 2");
                        btSave.Enabled = false;
                        return;
                    }

                    if (PersonService.PhoneExist(mtxtbPhone1.Text))
                    {
                        errorProvider1.SetError(mtxtbPhone1, $"this phone number ({mtxtbPhone1.Text}) is already exist");
                        btSave.Enabled = false;
                        _Phone1Exist = true;
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(mtxtbPhone1, "");
                        _Phone1Exist = false;
                    }
                }
            }

            if (CheckFromUniqueInputs())
            {
                btSave.Enabled = true;
            }
        }

        private void mtxtbPhone2_Validating(object sender, CancelEventArgs e)
        {
            if (_IsUpdatePerson && _Person.Phone2 == mtxtbPhone2.Text)
            {
                _Phone2Exist = false;
                errorProvider1.SetError(mtxtbPhone2, "");
            }
            else
            {
                if (mtxtbPhone2.MaskCompleted)
                {
                    if (mtxtbPhone2.Text == mtxtbPhone1.Text)
                    {
                        errorProvider1.SetError(mtxtbPhone2, $"this phone number ({mtxtbPhone2.Text}) same phone 1");
                        btSave.Enabled = false;
                        return;
                    }

                    if (PersonService.PhoneExist(mtxtbPhone2.Text))
                    {
                        errorProvider1.SetError(mtxtbPhone2, $"this phone number ({mtxtbPhone2.Text}) is already exist");
                        btSave.Enabled = false;
                        _Phone2Exist = true;
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(mtxtbPhone2, "");
                        _Phone2Exist = false;
                    }
                }
            }

            if (CheckFromUniqueInputs())
            {
                btSave.Enabled = true;
            }
        }

        private void txtbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (_IsUpdatePerson && _Person.Email == txtbEmail.Text)
            {
                _EmailExist = false;
                _EmailCorrectFormat = true;
                errorProvider1.SetError(txtbEmail, "");
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txtbEmail.Text))
                {
                    if (PersonService.EmailExist(txtbEmail.Text))
                    {
                        errorProvider1.SetError(txtbEmail, $"this email ({txtbEmail.Text}) is already exist");
                        btSave.Enabled = false;
                        _EmailExist = true;
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtbEmail, "");
                        _EmailExist = false;
                    }

                    string Pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                    if (Regex.IsMatch(txtbEmail.Text, Pattern))
                    {
                        errorProvider1.SetError(txtbEmail, "");
                        _EmailCorrectFormat = true;
                    }
                    else
                    {
                        errorProvider1.SetError(txtbEmail, "Invalid format");
                        btSave.Enabled = false;
                        _EmailCorrectFormat = false;
                        return;
                    }
                }
            }

            if (CheckFromUniqueInputs())
            {
                btSave.Enabled = true;
            }
        }

        void UpdateSetting()
        {
            _NationalNumberExist = false;
            _Phone1Exist = false;
            _Phone2Exist = false;
            _EmailExist = false;
        }

        public void SetPersonInfoToUpdate(clsPerson Person)
        {
            lbPersonIDResult.Text = Person.PersonID.ToString();

            txtbFirstName.Text = Person.FirstName;
            txtbSecondName.Text = Person.SecondName;
            txtbThirdName.Text = Person.ThirdName;
            txtbLastName.Text = Person.LastName;

            mtxtbNationalNumber.Text = Person.NationalNumber;

            dtpDateOfBirth.Value = Person.DateOfBirth.Date;

            if (Person.Gender == "Male")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }

            if (!string.IsNullOrWhiteSpace(Person.Phone1))
            {
                mtxtbPhone1.Text = Person.Phone1;
                _OldPhone1 = Person.Phone1;
            }

            if (!string.IsNullOrWhiteSpace(Person.Phone2))
            {
                mtxtbPhone2.Text = Person.Phone2;
                _OldPhone2 = Person.Phone2;
            }

            txtbAddress.Text = Person.Address;

            if (!string.IsNullOrWhiteSpace(Person.Email))
            {
                txtbEmail.Text = Person.Email;
            }

            pctbNewPerson.Image = clsGlobal.LoadImageNoLock(Person.ImagePath);
            openFileDialog1.FileName = Person.ImagePath;

            short index = (short)cbCountries.FindString(Person.Country);

            cbCountries.SelectedIndex = index;

            _IsUpdatePerson = true;

            _Person = Person;

            btSave.Enabled = true;

            UpdateSetting();
        }

        private void uctrlAddOrUpdatePerson_Load(object sender, EventArgs e)
        {
            dtpDateOfBirth.MaxDate = new DateTime(DateTime.Today.Year - 18, 1, 1);
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked)
                pctbNewPerson.Image = Resources.Male_512;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
                pctbNewPerson.Image = Resources.Female_512;
        }
    }
}
