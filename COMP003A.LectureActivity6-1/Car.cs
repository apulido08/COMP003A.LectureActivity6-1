using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.LectureActivity6_1
{
    class Car : Vehicle
    {
        // Auto-implemented properties

        public int Doors { get; set; }

        /// <summary>
        /// Constructs a car with the specific brand, year, and number of doors.
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="year"></param>
        ///  <param name="doors"></param>
        
        public Car(string brand, int year, int doors)
        {
            Brand = brand;
            Year = year;
            Doors = doors;
        }

        /// <summary>
        /// Displays car details including inherited properties
        /// </summary>


        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Doors: {Doors}");
        }
    }
}
