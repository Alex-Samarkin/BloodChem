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
    public partial class RadForm3 : Telerik.WinControls.UI.RadForm
    {
        public RadForm3()
        {
            InitializeComponent();
        }

        public int Hash { get; set; } = 0;

        public TwoSample oneSample { get; set; } = new TwoSample();

        public List<SimpleTwoDouble> items { get; set; } = new List<SimpleTwoDouble>();


        private void radButton1_Click(object sender, EventArgs e)
        {
            double v = (oneSample.fromToNormal.From + oneSample.fromToNormal.To) / 2.0;
            MessageBox.Show($"Проверить гипотезу о равенстве среднего в выборке величине {Math.Round(v, 2)}");
        }

        private void RadForm3_Load(object sender, EventArgs e)
        {
            items.Clear();

            oneSample.Init(Hash, 80, 180, 120, 140, 125, 140);
            oneSample.Generate();
            for (int i = 0; i < oneSample.N; i++)
            {
                items.Add(new SimpleTwoDouble() { Id = i + 1, Value = Math.Round(oneSample.items[i]), Value2 = Math.Round(oneSample.items2[i]) });
            }

            this.radGridView1.DataSource = items;
            radGridView1.BestFitColumns();
        }
    }
}
