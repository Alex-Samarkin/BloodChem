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
    public partial class RadForm4 : Telerik.WinControls.UI.RadForm
    {
        public RadForm4()
        {
            InitializeComponent();
        }

        public int Hash { get; set; } = 0;

        public OneSampleWithCode oneSample { get; set; } = new OneSampleWithCode();

        public List<SimpleDoubleWithGroup> items { get; set; } = new List<SimpleDoubleWithGroup>();

        private void RadForm4_Load(object sender, EventArgs e)
        {
            items.Clear();

            oneSample.Init(Hash, 800, 1200, 19, 32,0,6);
            oneSample.Generate();
            for (int i = 0; i < oneSample.N; i++)
            {
                items.Add(new SimpleDoubleWithGroup() { Id = i + 1, Value = Math.Round(oneSample.items[i],1),GroupCode = oneSample.codes[i] });
            }

            this.radGridView1.DataSource = items;
            radGridView1.BestFitColumns();
        }
    }
}
