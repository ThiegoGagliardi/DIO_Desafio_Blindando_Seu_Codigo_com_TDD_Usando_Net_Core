using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using  DIO_Desafio_blindando_codigo_com_TDD_Net_core.Model;
using  DIO_Desafio_blindando_codigo_com_TDD_Net_core.Services;

namespace DIO_Desafio_blindando_codigo_com_TDD_Net_core_test
{
    public class StudentApproverUnitTest
    {
        private readonly StudentApprover _approver = new  StudentApprover();
   
        [Theory]
        [InlineData(10)]
        [InlineData(9)]
        [InlineData(8)]        
        public void StudentIsApproved(int grade)
        { 
            // Arrange
            Student student = new Student("Fulano", " de Tall", grade);
            
            // Act
            var result = _approver.StudentIsApproved(student);

            // Assert
            Assert.Equal(StudentStatus.Passed ,result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]  
        [InlineData(3)]
        [InlineData(4)]
        public void StudentIsRepproved(int grade)
        {
            // Arrange
            Student student = new Student("Fulano", " de Tall", grade);

            // Act
            var result = _approver.StudentIsApproved(student);

            // Assert
            Assert.Equal(StudentStatus.Failed ,result);            
        }

        [Theory]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]          
        public void StudentInRecovery(int grade)
        {
            // Arrange
            Student student = new Student("Fulano", " de Tall", grade);

            // Act
            var result = _approver.StudentIsApproved(student);

            // Assert
            Assert.Equal(StudentStatus.Recovery ,result);  
        }
    }
}