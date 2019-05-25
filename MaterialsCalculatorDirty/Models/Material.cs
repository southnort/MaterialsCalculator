using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaterialsCalculatorDirty.Models
{
    /// <summary>
    /// Класс описывает один из материалов, для выполнения проекта
    /// </summary>
    public class Material
    {
        public string Name { get; set; }
        public string MeasureUnit { get; set; }
        public decimal Price { get; set; }

    }
}
