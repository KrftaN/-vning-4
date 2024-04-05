using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_4
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public bool IsAdult
        {
            get { return (DateTime.Today.Year - BirthDate.Year) >= 18; }
        }

        public double BMI
        {
            get { return Weight / (Height * Height); }
        }
    }
}
