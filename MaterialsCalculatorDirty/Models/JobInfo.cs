using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaterialsCalculatorDirty.Models
{
    public class JobInfo
    {
        public Job Job { get; set; }
        public decimal Count { get; set; }

        public decimal GetSumm()
        {
            return Job.Price * Count;
        }

    }
}
