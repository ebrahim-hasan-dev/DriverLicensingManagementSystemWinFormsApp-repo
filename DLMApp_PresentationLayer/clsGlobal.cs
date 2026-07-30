using DLMApp_ModulesLayer;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DLMApp_PresentationLayer
{
    internal class clsGlobal
    {
        //====================================================

        public static clsUser CurrentUser { get; set; }

        //====================================================


        public static async Task<Image> LoadImageNoLockAsync(string Path)
        {
            // استخدام FileStream لفتح الملف للقراءة فقط
            using (FileStream fs = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, true))
            {
                // تجهيز مصفوفة البايتات بنفس حجم الملف
                byte[] bytes = new byte[fs.Length];

                //قراءة الملف بشكل غير متزامن (Async) في الـ .NET Framework
                await fs.ReadAsync(bytes, 0, (int)fs.Length);

                // تحويل البايتات إلى صورة باستخدام MemoryStream و Clone
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    // نستخدم Clone لضمان استقلال الصورة عن الـ stream تماماً
                    return (Image)Image.FromStream(ms).Clone();
                }
            }
        }

        public static void MakeTitleInCenterScreen(int Width, Label label)
        {
            label.Location = new Point((Width / 2) - (label.Size.Width / 2), 0);
        }


    }
}
