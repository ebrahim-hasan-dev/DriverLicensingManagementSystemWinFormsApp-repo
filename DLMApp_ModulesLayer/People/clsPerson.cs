
using System;


namespace DLMApp_ModulesLayer
{
    public class clsPerson
    {
        public int PersonID { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }
        public string NationalNumber { get; set; }
        public string Country { get; set; }
        public int NationalityCountryID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime AddedDate { get; set; }
        public int CreatedByUserID { get; set; }
        public string CreatedByUser { get; set; }


        public virtual bool IsFull()
        {
            return !string.IsNullOrWhiteSpace(this.FirstName) && !string.IsNullOrWhiteSpace(this.SecondName) &&
                !string.IsNullOrWhiteSpace(this.ThirdName) && !string.IsNullOrWhiteSpace(this.LastName) &&
                !string.IsNullOrWhiteSpace(this.Address) && !string.IsNullOrWhiteSpace(this.ImagePath) &&
                !string.IsNullOrWhiteSpace(this.NationalNumber) && this.DateOfBirth != default(DateTime) &&
                !string.IsNullOrWhiteSpace(this.Gender) && this.CreatedByUserID > 0 &&
                 this.NationalityCountryID > 0 && (!string.IsNullOrWhiteSpace(this.Phone1) || !string.IsNullOrWhiteSpace(this.Phone2));
        }

        public string GetFullName()
        {
            return $"{this.FirstName} {this.SecondName} {this.ThirdName} {this.LastName}"; 
        }


    }
}
