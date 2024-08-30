using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemData
{
    public class Student
    {
        public string firstName {  get; set; }
        public string lastName { get; set; }
        public string phoneNumber {  get; set; }

        public Career career { get; set; }


        public override string ToString()
        {
            return $"nombre: {firstName}  {lastName} telefono: {phoneNumber} carrera: {career.Name}";
        }
    }
}
