using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIO_Desafio_blindando_codigo_com_TDD_Net_core.Model;
using DIO_Desafio_blindando_codigo_com_TDD_Net_core.Interfaces;

namespace DIO_Desafio_blindando_codigo_com_TDD_Net_core.Services
{
    public class StudentApprover
    {

        public StudentStatus StudentIsApproved(Student student)
        {
            if (student.Grade < 5)
            {
                return StudentStatus.Failed;
            }

            if (student.Grade >= 8)
            {
                return StudentStatus.Passed;
            }

            return StudentStatus.Recovery;

        }

    }
}