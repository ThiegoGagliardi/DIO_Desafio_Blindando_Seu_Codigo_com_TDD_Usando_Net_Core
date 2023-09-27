using  DIO_Desafio_blindando_codigo_com_TDD_Net_core.Model;
using  DIO_Desafio_blindando_codigo_com_TDD_Net_core.Services;
using  DIO_Desafio_blindando_codigo_com_TDD_Net_core.Interfaces;
using System.Linq.Expressions;
try
{

    Student student1 = new Student("Fulano", "De tall", 10);
    Student student2 = new Student("Beltrano", "De Tall", 05);
    Student student3 = new Student("Ciclano", "de Tall", 01);

    IValidator validator = new StudentValidator();

    validator.SetItemForValidation(student1);
    validator.Validate();

    validator.SetItemForValidation(student2);
    validator.Validate();

    validator.SetItemForValidation(student3);
    validator.Validate();

    StudentApprover Approver = new StudentApprover();
    Console.WriteLine($"{student1.FirstName} {student1.LastName} , Nota: {student1.Grade}, {Approver.StudentIsApproved(student1)}");
    Console.WriteLine($"{student2.FirstName} {student2.LastName} , Nota: {student2.Grade}, {Approver.StudentIsApproved(student2)}");
    Console.WriteLine($"{student3.FirstName} {student3.LastName} , Nota: {student3.Grade}, {Approver.StudentIsApproved(student3)}");


    Student student = new Student();
    student.Grade = -1;
    validator.SetItemForValidation(student);
    validator.Validate();
}
catch (Exception ex)
{
    Console.WriteLine($"Estudante Inválido, verificar erros: {ex.Message}");
}