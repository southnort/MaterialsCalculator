using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaterialsCalculatorDirty.Models
{
    public class MaterialInfo
    {
        public Material Material { get; set; }
        public decimal Count { get; set; }

        public decimal GetSumm()
        {
            return Material.Price * Count;
        }

    }
}
