using System;
using System.Linq;
using System.Security.Cryptography;


namespace DLMApp_BusinessLayer
{
    public class PasswordManager
    {
        //==========================================================================

        // حجم الملح بالبايت (16 بايت = 128 بت وهو كافٍ جداً)
        private const int SaltSize = 16;

        // حجم الهاش الناتج بالبايت (32 بايت = 256 بت)
        private const int HashSize = 32;

        // عدد التكرارات (Iterations) - كلما زاد كلما كان الهاش أبطأ وأكثر أماناً ضد الاختراق
        // الموصى به حالياً لا يقل عن 100,000 تكرار
        private const int Iterations = 100000;

        // علامة الفصل التي سنستخدمها لدمج وفصل الملح عن الهاش
        // النقطة ليست جزءاً من قاموس الـ
        // Base64 نهائياً
        // مهما كانت الكلمة السرية أو الملح العشوائي الذي تم توليده، فإن النص الناتج من الدالة مستحيل أن يحتوي على نقطة
        private const char Delimiter = '.';

        //==========================================================================


        public static string HashPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                return "";
            }
            else
            {
                byte[] saltBytes = new byte[SaltSize];

                using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(saltBytes);
                }

                using (Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, Iterations, HashAlgorithmName.SHA256))
                {
                    byte[] hashBytes = pbkdf2.GetBytes(HashSize);

                    // تحويلهما لنصوص Base64
                    string saltBase64 = Convert.ToBase64String(saltBytes);
                    string hashBase64 = Convert.ToBase64String(hashBytes);

                    // الدمج في نص واحد يفصل بينهما نقطة (.)
                    // الناتج سيكون شكله هكذا: [SaltBase64].[HashBase64]
                    return $"{saltBase64}{Delimiter}{hashBase64}";
                }
            }
        }

        public static bool VerifyPassword(string password, string storedCombinedHash)
        {
            //  فحص ما إذا كان النص المسترجع يحتوي على علامة الفصل
            if (string.IsNullOrWhiteSpace(storedCombinedHash) || !storedCombinedHash.Contains(Delimiter) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            //  تفكيك النص المدمج إلى جزأين: الملح والهاش
            string[] parts = storedCombinedHash.Split(Delimiter);
            string saltBase64 = parts[0];
            string storedHashBase64 = parts[1];

            // تحويلهما مجدداً إلى بايتات
            byte[] saltBytes = Convert.FromBase64String(saltBase64);
            byte[] storedHashBytes = Convert.FromBase64String(storedHashBase64);

            // إعادة حساب الهاش لكلمة المرور المدخلة باستخدام الملح المستخرج
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, Iterations, HashAlgorithmName.SHA256))
            {
                byte[] computedHashBytes = pbkdf2.GetBytes(HashSize);

                // المقارنة الآمنة
                return FixedTimeEquals(computedHashBytes, storedHashBytes);
            }
        }


        // دالة بديلة للمقارنة الثابتة زمنياً لحماية التطبيق من الـ Timing Attacks

        // The function executes a `for` loop that iterates through all bytes from start to finish without any break or return statements.
        // It performs an XOR operation (using the `^` operator) between the corresponding bytes;
        // if the bytes are identical, the result is 0. If there is any difference—even in a single byte—the `result` variable changes to a non-zero value. Finally,
        // the function checks whether the result is 0 (indicating a complete match).
        private static bool FixedTimeEquals(byte[] left, byte[] right)
        {
            if (left == null || right == null)
                return false;

            if (left.Length != right.Length)
                return false;

            int result = 0;

            for (int i = 0; i < left.Length; i++)
            {
                // عملية XOR تضمن فحص كل البايتات بالكامل مهما كانت النتيجة
                result |= left[i] ^ right[i];
            }

            return result == 0;
        }


    }
}
