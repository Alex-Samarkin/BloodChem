using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserClassLibrary
{
    public class OneSampleWithCode : IntFromToUniform
    {
            public int Seed { get; set; } = 0;
            public FromToNormal fromToNormal { get; set; } = new FromToNormal();
            public IntFromToUniform codeUniform { get; set; } = new IntFromToUniform();


            public int N { get; set; } = 0;
            public void Init(int newSeed, int countfrom, int countto, double normalFrom, double normalTo, int codefrom, int codeto)
            {
                this.MyRandom = new MyRandom();
                MyRandom.Init(newSeed);
                this.From = countfrom;
                this.To = countto;
                N = this.Next();

                fromToNormal.MyRandom = this.MyRandom;
                fromToNormal.From = normalFrom;
                fromToNormal.To = normalTo;

                codeUniform.MyRandom = this.MyRandom;
                codeUniform.From = codefrom;
                codeUniform.To = codeto;
            }

            public List<double> items { get; set; } = new List<double>();
            public List<int> codes { get; set; } = new List<int>();

            public void Generate()
            {
                items.Clear();
                codes.Clear();

                for (int i = 0; i < N; i++)
                {
                    items.Add(fromToNormal.Next(this.MyRandom));
                    codes.Add(codeUniform.Next());
                }
            }

    }
}
