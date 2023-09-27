using  DIO_Desafio_blindando_codigo_com_TDD_Net_core.Model;
using  DIO_Desafio_blindando_codigo_com_TDD_Net_core.Services;
using Microsoft.VisualStudio.TestPlatform.Common.Utilities;

namespace DIO_Desafio_blindando_codigo_com_TDD_Net_core_test;

public class StudentValidatorUnitTest
{
   
    [Fact]
    public void SutdentFirstNameNotEmpty()
    {
       // Arrange
       Student student = new Student();
       student.FirstName = "Fulano";
       StudentValidator _validator  = new StudentValidator(student);
       
       // Act
       var result = _validator.StudentFirstNameValidate();

       // Assert
       Assert.True(result);
    }

    [Fact]
    public void SutdentFirstNameIsEmpty()
    {
       // Arrange
       Student student = new Student();       
       StudentValidator _validator  = new StudentValidator(student);
       
       // Act
       var result = _validator.StudentFirstNameValidate();

       // Assert
       Assert.False(result);
    }

    [Fact]
    public void SutdentLastNameNotEmpty()
    {
       // Arrange
       Student student  = new Student();
       student.LastName = "de Tall";

       StudentValidator _validator  = new StudentValidator(student);
       
       // Act
       var result = _validator.StudentLastNameValidate();

       // Assert
       Assert.True(result);
    }
    
    [Fact]
    public void SutdentLastNameIsEmpty()
    {
       // Arrange
       Student student = new Student();       
       StudentValidator _validator  = new StudentValidator(student);
       
       // Act
       var result = _validator.StudentFirstNameValidate();

       // Assert
       Assert.False(result);
    } 

    [Fact]
    public void SudentGradeMinorThanZero()
    {
       // Arrange
       Student student = new Student();
       student.Grade  = -10;
       StudentValidator _validator  = new StudentValidator(student);
       
       // Act
       var result = _validator.SudentGradeValidate();

       // Assert
       Assert.False(result);      
    }

    [Fact]
    public void SudentGradeBiggerThanZero()
    {
       // Arrange
       Student student = new Student();
       student.Grade  = 10;
       StudentValidator _validator  = new StudentValidator(student);
       
       // Act
       var result = _validator.SudentGradeValidate();

       // Assert
       Assert.True(result);
    }

    [Fact]
    public void SudentGradeBiggerThanTen()
    {
       // Arrange
       Student student = new Student();
       student.Grade  = 11;
       StudentValidator _validator  = new StudentValidator(student);
       
       // Act
       var result = _validator.SudentGradeValidate();

       // Assert
       Assert.False(result);
    }    

    [Fact]
    public void SudentNotIsValid()
    {
       // Arrange
       Student student = new Student();       
       StudentValidator _validator  = new StudentValidator(student);
       
       // Act
       // Assert
       Assert.Throws<Exception>(() => _validator.Validate());
    }

    [Fact]
    public void SudentIsValid()
    {
       // Arrange
       Student student = new Student("Fulano","de Tall",10);     
       StudentValidator _validator  = new StudentValidator(student);
       
       // Act              
       var message = _validator.Validate(); 
   
       //Assert
       Assert.Equal("Estudante Válido.", message);
    } 
}