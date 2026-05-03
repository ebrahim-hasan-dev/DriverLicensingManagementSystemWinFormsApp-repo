

namespace DLMApp_ModulesLayer
{
    public class clsApplicationType
    {
        public byte ApplicationTypeID { get; set; }
        public string ApplicationTypeName { get; set; }
        public float ApplicationTypeFees { get; set; }

        public bool IsFull()
        {
            return this.ApplicationTypeID > 0 && !string.IsNullOrWhiteSpace(this.ApplicationTypeName) && this.ApplicationTypeFees > 0;
        }

    }
}
