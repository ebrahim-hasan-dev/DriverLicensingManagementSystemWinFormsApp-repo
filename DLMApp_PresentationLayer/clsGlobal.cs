using DLMApp_ModulesLayer;
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace DLMApp_PresentationLayer
{
    internal class clsGlobal
    {
        //====================================================

        public static clsUser CurrentUser { get; set; }

        //====================================================


        public static clsApplication FillAndGetApplication(int PersonID, enApplicationStatus ApplicationStatus, enApplicationTypes ApplicationTypes, float Fees)
        {
            clsApplication Application = new clsApplication();

            Application.PersonID = PersonID;
            Application.StatusID = ApplicationStatus;
            Application.AddedDateTme = DateTime.Now;
            Application.ApplicationTypeID = ApplicationTypes;
            Application.CreatedByUserID = CurrentUser.UserID;
            Application.Fees = Fees;

            return Application;
        }

        public static Image LoadImageNoLock(string path)
        {
            // نقرأ الملف بالكامل في مصفوفة بايتات
            byte[] bytes = File.ReadAllBytes(path);

            // نستخدم MemoryStream لتحويل البايتات إلى صورة
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                // نستخدم Clone لضمان استقلال الصورة عن الـ stream تماماً
                return (Image)Image.FromStream(ms).Clone();
            }
        }

        public static void MakeTitleInCenterScreen(int Width, Label label)
        {
            label.Location = new Point((Width / 2) - (label.Size.Width / 2), 0);
        }





    }
}
