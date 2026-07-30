using DLMApp_ModulesLayer;
using System.Collections.Generic;
using System.Threading.Tasks;
using DLMApp_DataAccessLayer;


namespace DLMApp_BusinessLayer
{
    public class UserService
    {
        static public async Task<clsUser> Find(string UserName)
        {
            if (!string.IsNullOrWhiteSpace(UserName))
            {
                return await UserRepository.Find(UserName);
            }
            else
            {
                return null;
            }
        }

        static public async Task<List<clsUser>> GetAllUsers()
        {
            return await UserRepository.GetAllUsers();
        }

        public static async Task<bool> UpdateActiveUser(int UserID, bool Active)
        {
            if (UserID > 0)
            {
                return await UserRepository.UpdateActiveUser(UserID, Active);
            }
            else
            {
                return false;
            }
        }

        public static async Task<bool> ChangePassword(int UserID, string NewPassword)
        {
            if (UserID > 0 && !string.IsNullOrWhiteSpace(NewPassword))
            {
                return await UserRepository.ChangePassword(UserID, NewPassword);
            }
            else
            {
                return false;
            }
        }

        public static async Task<bool> AddNewUser(clsUser User)
        {
            if (User.IsFull())
            {
                return await UserRepository.AddNewUser(User);
            }
            else
            {
                return false;
            }
        }

        public static async Task<bool> UserNameExist(string UserName)
        {
            if (!string.IsNullOrWhiteSpace(UserName))
            {
                return await UserRepository.UserNameExist(UserName);
            }
            else
            {
                return false;
            }
        }

        static public async Task<clsUser> FindWithoutPass(string UserName)
        {
            if (!string.IsNullOrWhiteSpace(UserName))
            {
                return await UserRepository.FindWithoutPass(UserName);
            }
            else
            {
                return null;
            }
        }

        public static async Task<clsUser> Find(int UserID)
        {
            if (UserID > 0)
            {
                return await UserRepository.Find(UserID);
            }
            else
            {
                return null;
            }
        }

        static public async Task<clsUser> FindByNationalNumber(string NationalNumber)
        {
            if (!string.IsNullOrWhiteSpace(NationalNumber))
            {
                return await UserRepository.FindByNationalNumber(NationalNumber);
            }
            else
            {
                return null;
            }
        }

        static public async Task<bool> PersonIDExist(int PersonID)
        {
            if (PersonID > 0)
            {
                return await UserRepository.PersonIDExist(PersonID);
            }
            else
            {
                return false;
            }
        }

    





    }
}
