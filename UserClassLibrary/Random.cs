using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomNameGeneratorLibrary;
using MathNet.Numerics.Random;
using MathNet.Numerics.Distributions;

namespace UserClassLibrary
{
    public class MyRandom
    {
        public int Seed { get; set; } = 0;
        public Random GeneratorRandom { get; set; } = new Random();

        public void Init(int newSeed, int runsBefore = 0)
        {
            Seed = newSeed;
            GeneratorRandom = new Random(newSeed);
            if (runsBefore>0)
            {
                for (int i = 0; i < runsBefore; i++)
                {
                    int tmp = GeneratorRandom.Next();
                }
            }
        }


    }

    public class IntFromToUniform
    {
        public MyRandom MyRandom { get; set; } = new MyRandom();

        public int From { get; set; } = 0;
        public int To { get; set; } = 100;

        int Nex() => MyRandom.GeneratorRandom.Next(From, To);

    }

    public class FromToNormal
    {
        public MyRandom MyRandom { get; set; } = new MyRandom();

        public double From { get; set; } = 0;
        public double To { get; set; } = 100;

        public double H => (To - From);
        public double mu => (To + From) / 2.0;
        public double sigma => H / 6.0;

        double Nex() => Normal.Sample(MyRandom.GeneratorRandom, mu, sigma);
    }

    public class RandomNames
    {
        public MyRandom MyRandom { get; set; } = new MyRandom();
        public PersonNameGenerator NameGenerator { get; set; } = new PersonNameGenerator();
        public void Init(MyRandom myRandom)
        {
            MyRandom = new MyRandom();
            NameGenerator = new PersonNameGenerator(MyRandom.GeneratorRandom);
        }

        public string NextName => NameGenerator.GenerateRandomFirstAndLastName();
    }
}
