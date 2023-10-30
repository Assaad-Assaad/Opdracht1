using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    public class Person
    {

        private int _age;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 18 || value > 99)
                {
                    Console.WriteLine("Age has to be between 18 & 99");
                }
                else
                {
                    _age = value;
                }
            }
        }

        public string GetFullName()
        {
            return $"{GetType().Name} {FirstName} {LastName}";
        }

    }
}
