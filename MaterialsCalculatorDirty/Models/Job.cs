using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaterialsCalculatorDirty.Models
{
    /// <summary>
    /// Класс описывает один из видов работ для выполнения проекта
    /// </summary>
    public class Job
    {
        public string Name { get; set; }
        public string MeasureUnit { get; set; }
        public decimal Price { get; set; }

    }
}
