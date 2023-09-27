using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIO_Desafio_blindando_codigo_com_TDD_Net_core.Model;
using DIO_Desafio_blindando_codigo_com_TDD_Net_core.Interfaces;

namespace DIO_Desafio_blindando_codigo_com_TDD_Net_core.Services
{
    public class StudentValidator : IValidator
    {        

        public Student? Student { get; set; }

        public StudentValidator(Student student)
        {
            this.Student = student;            
        }

        public StudentValidator()
        {
            
        }

        public bool StudentFirstNameValidate()
        {
             if (String.IsNullOrEmpty(this.Student?.FirstName))
             {
                return false;
             }

            return true;
        }

        public bool StudentLastNameValidate()
        {
             if (String.IsNullOrEmpty(this.Student?.LastName))
             {
                return false;
             }

            return true;
        }

        public bool SudentGradeValidate()
        {
            if (this.Student?.Grade < 0){
                return false;
            }

           if (this.Student?.Grade > 10){
                return false;
            }            
            
            return true;
        }

        public string Validate()
        {
            String message = "";

            if (!this.StudentFirstNameValidate())
            {
                message = "Primeiro nome do aluno inválido.";
            }

            if (!this.StudentLastNameValidate())
            {
                message += "Ultimo nome do aluno inválido.";
            }

            if (!this.SudentGradeValidate())
            {
                message += "Nota do aluno inválida.";
            }

            if (!String.IsNullOrEmpty(message))
            {
                throw new Exception(message);
            }
            else
            {
                message = "Estudante Válido.";
            }

            return message;
        }

        public void SetItemForValidation(Object item)
        {
            this.Student = (Student) item;
        }
    }
}