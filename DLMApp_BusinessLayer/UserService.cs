using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLMApp_DataAccessLayer;

namespace DLMApp_BusinessLayer
{
    public class UserService
    {
        static public clsUser Find(string UserName)
        {
            if (!string.IsNullOrWhiteSpace(UserName))
            {
                return UserRepository.Find(UserName);
            }
            else
            {
                return null;
            }
        }

        static public List<clsUser> GetAllUsers()
        {
            return UserRepository.GetAllUsers();
        }

        public static bool UpdateActiveUser(int UserID, bool Active)
        {
            if (UserID > 0)
            {
                return UserRepository.UpdateActiveUser(UserID, Active);
            }
            else
            {
                return false;
            }
        }

        public static bool ChangePassword(int UserID, string NewPassword)
        {
            if (UserID > 0 && !string.IsNullOrWhiteSpace(NewPassword))
            {
                return UserRepository.ChangePassword(UserID, NewPassword);
            }
            else
            {
                return false;
            }
        }

        public static bool AddNewUser(clsUser User)
        {
            if (User.IsFull())
            {
                return UserRepository.AddNewUser(User);
            }
            else
            {
                return false;
            }
        }

        public static bool UserNameExist(string UserName)
        {
            if (!string.IsNullOrWhiteSpace(UserName))
            {
                return UserRepository.UserNameExist(UserName);
            }
            else
            {
                return false;
            }
        }

        static public clsUser FindWithoutPass(string UserName)
        {
            if (!string.IsNullOrWhiteSpace(UserName))
            {
                return UserRepository.FindWithoutPass(UserName);
            }
            else
            {
                return null;
            }
        }

        static public clsUser Find(int UserID)
        {
            if (UserID > 0)
            {
                return UserRepository.Find(UserID);
            }
            else
            {
                return null;
            }
        }

        static public clsUser FindByNationalNumber(string NationalNumber)
        {
            if (!string.IsNullOrWhiteSpace(NationalNumber))
            {
                return UserRepository.FindByNationalNumber(NationalNumber);
            }
            else
            {
                return null;
            }
        }

        static public bool PersonIDExist(int PersonID)
        {
            if (PersonID > 0)
            {
                return UserRepository.PersonIDExist(PersonID);
            }
            else
            {
                return false;
            }
        }

    





    }
}
