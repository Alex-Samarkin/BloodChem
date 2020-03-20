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

namespace HypTest
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();


        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            user.Title = "Проверка статистических гипотез";
            this.radPropertyGrid1.SelectedObject = user;

        }

        public UserClassLibrary.User user { get; set; } = new User();

        private void radButton1_Click(object sender, EventArgs e)
        {
            RadForm2 form2 = new RadForm2();
            form2.Hash = this.user.HashCode;
            form2.Text = form2.Hash.ToString();
            form2.ShowDialog();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            RadForm3 form3 = new RadForm3();
            form3.Hash = this.user.HashCode;
            form3.Text = form3.Hash.ToString();
            form3.ShowDialog();

        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            RadForm4 form4 = new RadForm4();
            form4.Hash = this.user.HashCode;
            form4.Text = form4.Hash.ToString();
            form4.ShowDialog();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В задании 2 выполните проверку гипотезы об однородности дисперсий");
        }
    }
}
               