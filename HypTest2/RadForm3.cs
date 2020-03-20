using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using UserClassLibrary;

namespace HypTest2
{
    public partial class RadForm3 : Telerik.WinControls.UI.RadForm
    {
        public RadForm3()
        {
            InitializeComponent();
        }
        public int HCode { get; set; } = 0;

        public OneSample oneSample { get; set; } = new OneSample();

        public List<SimpleDouble> items { get; set; } = new List<SimpleDouble>();


        private void RadForm3_Load(object sender, EventArgs e)
        {
            items.Clear();

            oneSample.Init(HCode, 10, 70, 160, 210);
            oneSample.Generate();
            for (int i = 0; i < oneSample.N; i++)
            {
                items.Add(new SimpleDouble() { Id = i + 1, Value = Math.Round(oneSample.items[i], 2) });
            }

            this.radGridView1.DataSource = items;
            radGridView1.BestFitColumns();
        }
    }
}
