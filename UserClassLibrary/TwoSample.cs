using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserClassLibrary
{
    public class TwoSample : IntFromToUniform
    {
        public int Seed { get; set; } = 0;
        public FromToNormal fromToNormal { get; set; } = new FromToNormal();
        public FromToNormal fromToNormal2 { get; set; } = new FromToNormal();


        public int N { get; set; } = 0;
        public void Init(int newSeed, int countfrom, int countto, double normalFrom, double normalTo, double normalFrom2, double normalTo2)
        {
            this.MyRandom = new MyRandom();
            MyRandom.Init(newSeed);
            this.From = countfrom;
            this.To = countto;
            N = this.Next();

            fromToNormal.MyRandom = this.MyRandom;
            fromToNormal.From = normalFrom;
            fromToNormal.To = normalTo;

            fromToNormal2.MyRandom = this.MyRandom;
            fromToNormal2.From = normalFrom2;
            fromToNormal2.To = normalTo2;


        }

        public List<double> items { get; set; } = new List<double>();
        public List<double> items2 { get; set; } = new List<double>();

        public void Generate()
        {
            items.Clear();
            items2.Clear();

            for (int i = 0; i < N; i++)
            {
                items.Add(fromToNormal.Next(this.MyRandom));
                items2.Add(fromToNormal2.Next(this.MyRandom));
            }
        }

    }
}
