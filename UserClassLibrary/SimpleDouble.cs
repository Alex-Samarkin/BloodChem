using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserClassLibrary
{
    public class SimpleDouble
    {
        [DisplayName("Код")]
        public int Id { get; set; } = 0;
        [DisplayName("Значение")]
        public double Value { get; set; } = 0;
    }
    public class SimpleTwoDouble
    {
        [DisplayName("Код")]
        public int Id { get; set; } = 0;
        [DisplayName("Выборка 1")]
        public double Value { get; set; } = 0;
        [DisplayName("Выборка 2")]
        public double Value2 { get; set; } = 0;
    }
    public class SimpleDoubleWithGroup
    {
        [DisplayName("Код")]
        public int Id { get; set; } = 0;
        [DisplayName("Выборка 1")]
        public double Value { get; set; } = 0;
        [DisplayName("Код группы")]
        public int GroupCode { get; set; } = 0;
    }
}
