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
    public partial class fmAdd_UpdatePersonScreen : Form
    {
        // =========================================================

        clsPerson _Person = null;

        public event Action<clsPerson> AddedEventHandler;

        // =========================================================

        protected virtual void OnAddedEventHandler(clsPerson Person)
        {
            AddedEventHandler?.Invoke(Person);
        }

        public fmAdd_UpdatePersonScreen()
        {
            InitializeComponent();
        }

        public fmAdd_UpdatePersonScreen(clsPerson Person)
        {
            InitializeComponent();

            _Person = Person;

            lbAddOrUpdatePerson.Text = "Update Person Screen";

            uctrlAddOrUpdatePerson1.SetPersonInfoToUpdate(_Person);
        }

        void uctrlAddOrUpdatePerson1_AddedEventHandler(clsPerson Person)
        {
            _Person = Person;
            OnAddedEventHandler(_Person);
        }





    }
}
