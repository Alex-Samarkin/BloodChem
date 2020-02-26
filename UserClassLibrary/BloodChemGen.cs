using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserClassLibrary
{
    public class BloodChemGen
    {
        public MyRandom myRandom { get; set; } = new MyRandom();
        public int Seed { get; set; } = 0;
        public int From { get; set; } = 300;
        public int To { get; set; } = 600;

        public IntFromToUniform NGen { get; set; } = new IntFromToUniform();

        public RandomNames NamesGen { get; set; } = new RandomNames();

        #region Property of blood
        /*
                Показатель анализа Норма для мужчин Норма для женщин
                    Общий белок 65-84 г/л 65-85 г/л
                    Белковые фракции:
                    - альбумины 34-44 г/л 21-35 г/л
                    - глобулины 35-45 г/л 21-34,9 г/л
                    Гемоглобин 130-150 г/л 120-140 г/л
                    Мочевина 2,5-8,2 ммоль/л 2,4-8,2 ммоль/л
                    Мочевая кислота 0,12-0,42 ммоль/л 0,24-0,54 ммоль/л
                    Глюкоза 3,3-5,5 ммоль/л 3,2-5,5 ммоль/л
                    Креатинин 61-114 мкмоль/л 52-96 мкмоль/л
                    Холестерин общий 3,4-6,4 ммоль/л 3,4-6,4 ммоль/л
                    ЛПНП До 3 ммоль/л До 3 ммоль/л
                    ЛПВП 1 ммоль/л 0-1,2 ммоль/л
                    Триглицериды До 1,6 ммоль/л До 1,7 ммоль/л
                    Билирубин(общий) 5-20 мкмоль/л 5-20 мкмоль/л
                    Билирубин прямой 2,2-5,0 мкмоль/л 2,2-5,0 мкмоль/л
                    АЛТ(аланинаминотрансфераза) Не более 45 ед/л Не более 30 ед/л
                    АСТ(аспартатаминотрансфераза) До 45 ед/л До 30 ед/л
                    Щелочная фосфатаза До 260 ед/л До 250 ед/л
                    ГГТ(гамма-глутамилтрансфераза) До 33 ед/л До 47 ед/л
                    Липаза 0-187 ед/л 0-187 ед/л
                    Панкреатическая амилаза 0-50 ед/л 0-50 ед/л
                    Креатинкиназа(КК) До 180 ед/л До 180 ед/л
                    Натрий 130-150 ммоль/л 130-150 ммоль/л
                    Калий 3,3-5,3 ммоль/л 3,35-5,3 ммоль/л
                    Альфа-амилаза 27-99 ед/л 28-100 ед/л
        */

        //        Общий белок 65-84 г/л 65-85 г/л
        public FromToNormal Total_protein { get; set; }
        //Белковые фракции:
        //                    - альбумины 34-44 г/л 21-35 г/л
        public FromToNormal Albumin { get; set; }
        //                    - глобулины 35-45 г/л 21-34,9 г/л
        public FromToNormal Globulin { get; set; }
        //                    Гемоглобин 130-150 г/л 120-140 г/л
        public FromToNormal Hemoglobin { get; set; }
        //                    Мочевина 2,5-8,2 ммоль/л 2,4-8,2 ммоль/л
        public FromToNormal Urea { get; set; }
        //                    Мочевая кислота 0,12-0,42 ммоль/л 0,24-0,54 ммоль/л
        public FromToNormal Uric_acid { get; set; }
        //                    Глюкоза 3,3-5,5 ммоль/л 3,2-5,5 ммоль/л
        public FromToNormal Glucose { get; set; }
        //                    Креатинин 61-114 мкмоль/л 52-96 мкмоль/л
        public FromToNormal Creatinine { get; set; }
        //                    Холестерин общий 3,4-6,4 ммоль/л 3,4-6,4 ммоль/л
        public FromToNormal Total_cholesterol { get; set; }
        //                    ЛПНП До 3 ммоль/л До 3 ммоль/л
        public FromToNormal LDL { get; set; }
        //                    ЛПВП 1 ммоль/л 0-1,2 ммоль/л
        public FromToNormal HDL { get; set; }
        //                    Триглицериды До 1,6 ммоль/л До 1,7 ммоль/л
        public FromToNormal Trigliceride { get; set; }
        //                    Билирубин(общий) 5-20 мкмоль/л 5-20 мкмоль/л
        public FromToNormal Total_bilirubin { get; set; }
        //                    Билирубин прямой 2,2-5,0 мкмоль/л 2,2-5,0 мкмоль/л
        public FromToNormal Direct_bilirubin { get; set; }
        //                    АЛТ(аланинаминотрансфераза) Не более 45 ед/л Не более 30 ед/л
        public FromToNormal ALT { get; set; }
        //                    АСТ(аспартатаминотрансфераза) До 45 ед/л До 30 ед/л
        public FromToNormal AST { get; set; }
        //                    Щелочная фосфатаза До 260 ед/л До 250 ед/л
        public FromToNormal Alcaline_phospharase { get; set; }
        //                    ГГТ(гамма-глутамилтрансфераза) До 33 ед/л До 47 ед/л
        public FromToNormal GGT { get; set; }
        //                    Липаза 0-187 ед/л 0-187 ед/л
        public FromToNormal Lipase { get; set; }
        //                    Панкреатическая амилаза 0-50 ед/л 0-50 ед/л
        public FromToNormal Pancreatic_amylase { get; set; }
        //                    Креатинкиназа(КК) До 180 ед/л До 180 ед/л
        public FromToNormal Creatine_Kinase { get; set; }
        //                    Натрий 130-150 ммоль/л 130-150 ммоль/л
        public FromToNormal Sodium { get; set; }
        //                    Калий 3,3-5,3 ммоль/л 3,35-5,3 ммоль/л
        public FromToNormal Potassium { get; set; }
        //                    Альфа-амилаза 27-99 ед/л 28-100 ед/л
        public FromToNormal Alpha_amilase { get; set; }
        #endregion

        public void Init(int newSeed)
        {
            Seed = newSeed;
            myRandom = new MyRandom();
            myRandom.Init(Seed);

            NGen = new IntFromToUniform() { From = this.From, To = this.To, MyRandom = myRandom };
            NamesGen = new RandomNames();
            NamesGen.Init(myRandom);

            //        Общий белок 65-84 г/л 65-85 г/л
            Total_protein = new FromToNormal() { From = 65, To = 85 };
            //Белковые фракции:
            //                    - альбумины 34-44 г/л 21-35 г/л
            Albumin = new FromToNormal() { From = 21, To = 44 };
            //                    - глобулины 35-45 г/л 21-34,9 г/л
            Globulin = new FromToNormal() { From = 21, To = 45 };
            //                    Гемоглобин 130-150 г/л 120-140 г/л
            Hemoglobin = new FromToNormal() { From = 120, To = 150 };
            //                    Мочевина 2,5-8,2 ммоль/л 2,4-8,2 ммоль/л
            Urea = new FromToNormal() { From = 2.4, To = 8.2 };
            //                    Мочевая кислота 0,12-0,42 ммоль/л 0,24-0,54 ммоль/л
            Uric_acid = new FromToNormal() { From = 0.12, To = 0.54 };
            //                    Глюкоза 3,3-5,5 ммоль/л 3,2-5,5 ммоль/л
            Glucose = new FromToNormal() { From = 3.2, To = 5.5 };
            //                    Креатинин 61-114 мкмоль/л 52-96 мкмоль/л
            Creatinine = new FromToNormal() { From = 52, To = 114 };
            //                    Холестерин общий 3,4-6,4 ммоль/л 3,4-6,4 ммоль/л
            Total_cholesterol = new FromToNormal() { From = 3.4, To = 6.4 };
            //                    ЛПНП До 3 ммоль/л До 3 ммоль/л
            LDL = new FromToNormal() { From = 0, To = 3 };
            //                    ЛПВП 1 ммоль/л 0-1,2 ммоль/л
            HDL = new FromToNormal() { From = 0, To = 1.2 };
            //                    Триглицериды До 1,6 ммоль/л До 1,7 ммоль/л
            Trigliceride = new FromToNormal() { From = 0, To = 1.7 };
            //                    Билирубин(общий) 5-20 мкмоль/л 5-20 мкмоль/л
            Total_bilirubin = new FromToNormal() { From = 5, To = 20 };
            //                    Билирубин прямой 2,2-5,0 мкмоль/л 2,2-5,0 мкмоль/л
            Direct_bilirubin = new FromToNormal() { From = 2.2, To = 5 };
            //                    АЛТ(аланинаминотрансфераза) Не более 45 ед/л Не более 30 ед/л
            ALT = new FromToNormal() { From = 10, To = 45 };
            //                    АСТ(аспартатаминотрансфераза) До 45 ед/л До 30 ед/л
            AST = new FromToNormal() { From = 10, To = 45 };
            //                    Щелочная фосфатаза До 260 ед/л До 250 ед/л
            Alcaline_phospharase = new FromToNormal() { From = 10, To = 260 };
            //                    ГГТ(гамма-глутамилтрансфераза) До 33 ед/л До 47 ед/л
            GGT = new FromToNormal() { From = 5, To = 47 };
            //                    Липаза 0-187 ед/л 0-187 ед/л
            Lipase = new FromToNormal() { From = 5, To = 187 };
            //                    Панкреатическая амилаза 0-50 ед/л 0-50 ед/л
            Pancreatic_amylase = new FromToNormal() { From = 2, To = 50 };
            //                    Креатинкиназа(КК) До 180 ед/л До 180 ед/л
            Creatine_Kinase = new FromToNormal() { From = 5, To = 180 };
            //                    Натрий 130-150 ммоль/л 130-150 ммоль/л
            Sodium = new FromToNormal() { From = 130, To = 150 };
            //                    Калий 3,3-5,3 ммоль/л 3,35-5,3 ммоль/л
            Potassium = new FromToNormal() { From = 3.3, To = 5.3 };
            //                    Альфа-амилаза 27-99 ед/л 28-100 ед/л
            Alpha_amilase = new FromToNormal() { From = 27, To = 100 };
        }
        public BloodResult GenerateOne()
        {
            BloodResult result = new BloodResult();

            result.Name = NamesGen.NextName;

            //        Общий белок 65-84 г/л 65-85 г/л
            result.Total_protein = Total_protein.Next(this.myRandom);
            //Белковые фракции:
            //                    - альбумины 34-44 г/л 21-35 г/л
            result.Albumin = Albumin.Next(this.myRandom);
            //                    - глобулины 35-45 г/л 21-34,9 г/л
            result.Globulin = Globulin.Next(this.myRandom);
            //                    Гемоглобин 130-150 г/л 120-140 г/л
            result.Hemoglobin = Hemoglobin.Next(this.myRandom);
            //                    Мочевина 2,5-8,2 ммоль/л 2,4-8,2 ммоль/л
            result.Urea = Urea.Next(this.myRandom);
            //                    Мочевая кислота 0,12-0,42 ммоль/л 0,24-0,54 ммоль/л
            result.Uric_acid = Uric_acid.Next(this.myRandom);
            //                    Глюкоза 3,3-5,5 ммоль/л 3,2-5,5 ммоль/л
            result.Glucose = Glucose.Next(this.myRandom);
            //                    Креатинин 61-114 мкмоль/л 52-96 мкмоль/л
            result.Creatinine = Creatinine.Next(this.myRandom);
            //                    Холестерин общий 3,4-6,4 ммоль/л 3,4-6,4 ммоль/л
            result.Total_cholesterol = Total_cholesterol.Next(this.myRandom);
            //                    ЛПНП До 3 ммоль/л До 3 ммоль/л
            result.LDL = LDL.Next(this.myRandom);
            //                    ЛПВП 1 ммоль/л 0-1,2 ммоль/л
            result.HDL = HDL.Next(this.myRandom);
            //                    Триглицериды До 1,6 ммоль/л До 1,7 ммоль/л
            result.Trigliceride = Trigliceride.Next(this.myRandom);
            //                    Билирубин(общий) 5-20 мкмоль/л 5-20 мкмоль/л
            result.Total_bilirubin = Total_bilirubin.Next(this.myRandom);
            //                    Билирубин прямой 2,2-5,0 мкмоль/л 2,2-5,0 мкмоль/л
            result.Direct_bilirubin = Direct_bilirubin.Next(this.myRandom);
            //                    АЛТ(аланинаминотрансфераза) Не более 45 ед/л Не более 30 ед/л
            result.ALT = ALT.Next(this.myRandom);
            //                    АСТ(аспартатаминотрансфераза) До 45 ед/л До 30 ед/л
            result.AST = AST.Next(this.myRandom);
            //                    Щелочная фосфатаза До 260 ед/л До 250 ед/л
            result.Alcaline_phospharase = Alcaline_phospharase.Next(this.myRandom);
            //                    ГГТ(гамма-глутамилтрансфераза) До 33 ед/л До 47 ед/л
            result.GGT = GGT.Next(this.myRandom);
            //                    Липаза 0-187 ед/л 0-187 ед/л
            result.Lipase = Lipase.Next(this.myRandom);
            //                    Панкреатическая амилаза 0-50 ед/л 0-50 ед/л
            result.Pancreatic_amylase = Pancreatic_amylase.Next(this.myRandom);
            //                    Креатинкиназа(КК) До 180 ед/л До 180 ед/л
            result.Creatine_Kinase = Creatine_Kinase.Next(this.myRandom);
            //                    Натрий 130-150 ммоль/л 130-150 ммоль/л
            result.Sodium = Sodium.Next(this.myRandom);
            //                    Калий 3,3-5,3 ммоль/л 3,35-5,3 ммоль/л
            result.Potassium = Potassium.Next(this.myRandom);
            //                    Альфа-амилаза 27-99 ед/л 28-100 ед/л
            result.Alpha_amilase = Alpha_amilase.Next(this.myRandom);


            return result;
        }
    }
}
