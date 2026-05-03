using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLMApp_ModulesLayer
{
    public class clsLicense
    {
        public int ID {  get; set; }
        public string Notes {  get; set; }
        public string ImagePath {  get; set; }
        public DateTime ReleaseDate  {  get; set; }
        public DateTime EndDate  {  get; set; }
        public bool IsActive  {  get; set; }
        public bool IsDetained  {  get; set; }
        public float LicenseFees { get; set; } = -1;
        public int DriverID  {  get; set; }
        public clsPerson PersonInfo  {  get; set; }

        public enLicenseStatus LicenseStatusID = enLicenseStatus.New;
        public int CreatedByUserID  {  get; set; }
        public int ApplicationID  {  get; set; }
        public byte LicenseClassID  {  get; set; }
        public clsLicenseClass LicenseClassInfo  {  get; set; }
        public string LicenseClass  {  get; set; }
        public string CreatedByUser {  get; set; }

        public bool IsFull()
        {
            return !string.IsNullOrWhiteSpace(this.ImagePath) && this.EndDate != default(DateTime) && this.LicenseFees > -1 &&
                this.CreatedByUserID > 0 && this.ReleaseDate != default(DateTime) &&
                this.ApplicationID > 0 && this.LicenseClassID > 0 && this.DriverID > 0;
        }

        public bool IsThirdClass()
        {
            if (this.IsFull())
            {
                return this.LicenseClassID == (byte)enLicenseClasses.Class3_Ordinarydriving;
            }
            else
            {
                return false;
            }
        }

        public bool IsValid()
        {
            if (this.IsFull())
            {
                return this.EndDate > DateTime.Now;
            }
            else
            {
                return false;
            }
        }



    }
}
