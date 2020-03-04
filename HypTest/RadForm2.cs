using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using UserClassLibrary;

namespace HypTest
{
    public partial class RadForm2 : Telerik.WinControls.UI.RadForm
    {
        public RadForm2()
        {
            InitializeComponent();
        }

        public int Hash { get; set; } = 0;

        public OneSample oneSample { get; set; } = new OneSample();

        public List<SimpleDouble> items { get; set; } = new List<SimpleDouble>();

        private void RadForm2_Load(object sender, EventArgs e)
        {
            items.Clear();

            oneSample.Init(Hash, 100, 200, 5.4, 6);
            oneSample.Generate();
            for (int i = 0; i < oneSample.N; i++)
            {
                items.Add(new SimpleDouble() { Id = i + 1, Value = Math.Round(oneSample.items[i],2) });
            }

            this.radGridView1.DataSource = items;
            radGridView1.BestFitColumns();

            
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            double v = (oneSample.fromToNormal.From + oneSample.fromToNormal.To) / 2.0 ;
            MessageBox.Show($"Проверить гипотезу о равенстве среднего в выборке величине {Math.Round(v,2)}");
        }
    }
}
