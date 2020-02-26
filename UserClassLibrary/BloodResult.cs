using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserClassLibrary
{
    public class BloodResult
    {
        /// <summary>
        /// 
        /// </summary>
        [Category("0 Идентификатор результатов")]
        [DisplayName("Код")]
        public int ID { get; set; } = 0;
        [Category("0 Идентификатор результатов")]
        [DisplayName("Имя пациента")]
        public string Name { get; set; } = "";

        /// <summary>
        /// 
        /// </summary>
        //        Общий белок 65-84 г/л 65-85 г/л
        [Category("результаты анализа")] 
        public double Total_protein { get; set; } = 0;

        //Белковые фракции:
        //                    - альбумины 34-44 г/л 21-35 г/л
        [Category("результаты анализа")]
        public double Albumin { get; set; } = 0;
        //                    - глобулины 35-45 г/л 21-34,9 г/л
        [Category("результаты анализа")]
        public double Globulin { get; set; } = 0;
        //                    Гемоглобин 130-150 г/л 120-140 г/л
        [Category("результаты анализа")]
        public double Hemoglobin { get; set; } = 0;
        //                    Мочевина 2,5-8,2 ммоль/л 2,4-8,2 ммоль/л
        [Category("результаты анализа")]
        public double Urea { get; set; } = 0;
        //                    Мочевая кислота 0,12-0,42 ммоль/л 0,24-0,54 ммоль/л
        [Category("результаты анализа")]
        public double Uric_acid { get; set; } = 0;
        //                    Глюкоза 3,3-5,5 ммоль/л 3,2-5,5 ммоль/л
        [Category("результаты анализа")]
        public double Glucose { get; set; } = 0;
        //                    Креатинин 61-114 мкмоль/л 52-96 мкмоль/л
        [Category("результаты анализа")]
        public double Creatinine { get; set; } = 0;
        //                    Холестерин общий 3,4-6,4 ммоль/л 3,4-6,4 ммоль/л
        [Category("результаты анализа")]
        public double Total_cholesterol { get; set; } = 0;
        //                    ЛПНП До 3 ммоль/л До 3 ммоль/л
        [Category("результаты анализа")]
        public double LDL { get; set; } = 0;
        //                    ЛПВП 1 ммоль/л 0-1,2 ммоль/л
        [Category("результаты анализа")]
        public double HDL { get; set; } = 0;
        //                    Триглицериды До 1,6 ммоль/л До 1,7 ммоль/л
        [Category("результаты анализа")]
        public double Trigliceride { get; set; } = 0;
        //                    Билирубин(общий) 5-20 мкмоль/л 5-20 мкмоль/л
        [Category("результаты анализа")]
        public double Total_bilirubin { get; set; } = 0;
        //                    Билирубин прямой 2,2-5,0 мкмоль/л 2,2-5,0 мкмоль/л
        [Category("результаты анализа")]
        public double Direct_bilirubin { get; set; } = 0;
        //                    АЛТ(аланинаминотрансфераза) Не более 45 ед/л Не более 30 ед/л
        [Category("результаты анализа")]
        public double ALT { get; set; } = 0;
        //                    АСТ(аспартатаминотрансфераза) До 45 ед/л До 30 ед/л
        [Category("результаты анализа")]
        public double AST { get; set; } = 0;
        //                    Щелочная фосфатаза До 260 ед/л До 250 ед/л
        [Category("результаты анализа")]
        public double Alcaline_phospharase { get; set; } = 0;
        //                    ГГТ(гамма-глутамилтрансфераза) До 33 ед/л До 47 ед/л
        [Category("результаты анализа")]
        public double GGT { get; set; } = 0;
        //                    Липаза 0-187 ед/л 0-187 ед/л
        [Category("результаты анализа")]
        public double Lipase { get; set; } = 0;
        //                    Панкреатическая амилаза 0-50 ед/л 0-50 ед/л
        [Category("результаты анализа")]
        public double Pancreatic_amylase { get; set; } = 0;
        //                    Креатинкиназа(КК) До 180 ед/л До 180 ед/л
        [Category("результаты анализа")]
        public double Creatine_Kinase { get; set; } = 0;
        //                    Натрий 130-150 ммоль/л 130-150 ммоль/л
        [Category("результаты анализа")]
        public double Sodium { get; set; } = 0;
        //                    Калий 3,3-5,3 ммоль/л 3,35-5,3 ммоль/л
        [Category("результаты анализа")]
        public double Potassium { get; set; } = 0;
        //                    Альфа-амилаза 27-99 ед/л 28-100 ед/л
        [Category("результаты анализа")]
        public double Alpha_amilase { get; set; } = 0;


    }
}
