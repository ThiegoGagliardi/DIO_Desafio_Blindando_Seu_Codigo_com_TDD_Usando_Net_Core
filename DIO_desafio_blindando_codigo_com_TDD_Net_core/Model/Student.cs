using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_Desafio_blindando_codigo_com_TDD_Net_core.Model
{
    public class Student
    {

        public String? FirstName { get; set; }

        public String? LastName { get; set; }

        public int Grade { get; set; }

        public Student(String firstName, String lastName, int grade )
        {
            this.FirstName = firstName;
            this.LastName  = lastName;
            this.Grade     = grade;           
        }

        public Student()
        {
            
        }        
    }
}