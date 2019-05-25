using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaterialsCalculatorDirty.Models
{
    public class SubProject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<MaterialInfo> Materials { get; set; }
        public List<JobInfo> Jobs { get; set; }

        public SubProject()
        {
            Materials = new List<MaterialInfo>();
            Jobs = new List<JobInfo>();
        }

        public decimal GetSumm()
        {
            decimal result = 0;
            foreach (var item in Materials)
                result += item.GetSumm();

            foreach (var item in Jobs)
                result += item.GetSumm();

            return result;

        }

    }
}
