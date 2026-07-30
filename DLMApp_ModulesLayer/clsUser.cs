
namespace DLMApp_ModulesLayer
{
    public class clsUser
    {
        public int UserID {  get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PersonID { get; set; }
        public bool IsActive { get; set; }

        public bool IsFull()
        {
            return !string.IsNullOrWhiteSpace(this.UserName) && !string.IsNullOrWhiteSpace(this.Password) && this.PersonID > 0;
        }

    }

}
