using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserClassLibrary
{
    public class OneSample : IntFromToUniform
    {
        public int Seed { get; set; } = 0;
        public FromToNormal fromToNormal { get; set; } = new FromToNormal();

        public OneSample()
        {
            
        }

        public int N { get; set; } = 0;
        public void Init(int newSeed, int countfrom, int countto, double normalFrom, double normalTo)
        {
            this.MyRandom = new MyRandom();
            MyRandom.Init(newSeed);
            this.From = countfrom;
            this.To = countto;
            N = this.Next();

            fromToNormal.MyRandom = this.MyRandom;
            fromToNormal.From = normalFrom;
            fromToNormal.To = normalTo;
        }

        public List<double> items { get; set; } = new List<double>();

        public void Generate()
        {
            items.Clear();

            for (int i = 0; i < N; i++)
            {
                items.Add(fromToNormal.Next(this.MyRandom));
            }
        }

    }
}
