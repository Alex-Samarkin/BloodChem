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

namespace HypTest2
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        public UserClassLibrary.User user { get; set; } = new User();

        private void RadForm1_Load(object sender, EventArgs e)
        {
            user.Title = "проверка гипотез о виде распределения";
            this.radPropertyGrid1.SelectedObject = user;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            RadForm2 radForm = new RadForm2();
            radForm.Text = $"Равновероятное распределение {user.HashCode}";
            radForm.HCode = user.HashCode;
            radForm.ShowDialog();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            RadForm3 radForm = new RadForm3();
            radForm.Text = $"Нормальное распределение - малая выборка {user.HashCode}";
            radForm.HCode = user.HashCode;
            radForm.ShowDialog();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            RadForm4 radForm = new RadForm4();
            radForm.Text = $"Нормальное распределение {user.HashCode}";
            radForm.ShowDialog();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            RadForm5 radForm = new RadForm5();
            radForm.Text = $"Большие данные {user.HashCode}";
            radForm.ShowDialog();
        }
    }
}
