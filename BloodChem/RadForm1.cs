using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using UserClassLibrary;

namespace BloodChem
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();

            radPropertyGrid1.SelectedObject = User;
            //radPropertyGrid1.SelectedObject = bloodResult;
            blood.Init(User.HashCode);

        }

        public User User { get; set; } = new User();
        public BloodChemGen blood { get; set; } = new BloodChemGen();
        public BloodResult bloodResult { get; set; } = new BloodResult();

        private void radRadioButton1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (radRadioButton1.IsChecked)
            {
                radPropertyGrid1.SelectedObject = User;
            }
            if (radRadioButton2.IsChecked)
            {
                radPropertyGrid1.SelectedObject = bloodResult;
            }

        }
    }
}
