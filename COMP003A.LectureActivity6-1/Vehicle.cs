using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.LectureActivity6_1
{/// <summary>
/// Represents a general vehicle
/// </summary>

    internal class Vehicle
    {
        // Fields
        private string brand;

        // Properties

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int Year { get; set; }

        /// <summary>
        /// Displays vehicle details
        /// </summary>
        /// 
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Year: {Year}");
        }
    }
}
