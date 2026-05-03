using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLMApp_PresentationLayer
{
    public partial class uctrlApplicationInfo : UserControl
    {
        public uctrlApplicationInfo()
        {
            InitializeComponent();
        }

        public void SetApplicationInfo(clsApplicationType ApplicationType)
        {
            lbApplicationTypeResult.Text = ApplicationType.ApplicationTypeName;
            lbApplicationFeesResult.Text = ApplicationType.ApplicationTypeFees.ToString();
            lbApplicationDateResult.Text = DateTime.Now.ToString("d-M-yyyy");
        }
    }
}
