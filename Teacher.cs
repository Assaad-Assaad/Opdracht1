using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    public class Teacher : Person
    {
        public string[] Subjects { get; set; } = new string[3];
    }
}
