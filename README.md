# Blindando Seu Código com TDD e Testes Unitários Usando .NET Core
 Desafio de projeto da trilha de estudos .Net, para fixar o conceito de TDD (Desenvolvimento Orientado por Testes), utilizando testes unitários e o framework Xunit.

 ## Projeto
O instrutor utilizou uma calculadora para o projeto de exemplo, e seguindo a didática dele desenvolvi um projeto simples, com um classe modelo Aluno, e duas classes de serviços uma para validar o aluno e outra para verificar se o aluno está aprovado, em recuperação ou reprovado

*Diretorio com as regras de negócio DIO_desafio_blindando_codigo_com_TDD_Net_core
*Diretorio com os teste unitários DIO_desafio_blindando_codigo_com_TDD_Net_core_test


### Classe Modelo Aluno (Student) 
  O aluno tem os campos Primeiro Nome, Ultimo Nome e Nota.

### Validaçao do aluno (StudentValidator)
  A classe de serviço de validação do aluno, verifica se o primeiro e o ultimo nome estão preenchidos e se a nota é maior ou igual a zero (0)

### Aprovação do Aluno (StudentApprover)
  A classe de serviço  para aprovação do aluno, verifica a nota, caso ela seja inferior a 5 o aluno está reporvado, de 5 a 7 em recuperação, de 8 a 10 aprovado.

### Classes utilitárias
Existe uma classe Enum (StudentStatus)  para manter o status do aluno (StudentStatus)
```
    public enum StudentStatus
    {
        Passed,
        Failed,
        Recovery,
    }
```

##Testes Unitários e TDD
A partir do projeto de teste unitários, efetuei primeiramente os testes de validação do cliente (StudentValidatorUnitTest.cs), desenvolvenfo teste:

 - Validar se o campo primeiro nome está preenchido (SutdentFirstNameNotEmpty)
 - Validar se o campo primeiro nome não está preenchido (SutdentFirstNameIsEmpty)
 - Validar se o campo sobrenome está preenchido (SutdentLastNameNotEmpty)
 - Validar se o campo sobrenome não está preenchido (SutdentLastNameIsEmpty)
 - Validar se o campo nota é menor que zero(0) (SudentGradeMinorThanZero)
 - Validar se o campo nota é maior que zero(0) (SudentGradeBiggerThanZero)
 - Efetuar o validação geral do aluno, caso tenha algum erro, é gerada uma exceçao (SudentNotIsValid)
 - Efetuar o validação geral do aluno, caso tenha algum erro, é gerada uma exceçao (SudentIsValid)

Após isso foi criado uma classe nova para validar a aprovaçao do aluno (StudentApproverUnitTest) desenvolvendo os testes: 
- Verificar se o estudante está aprovado usando Theory e inline data com as notas 10,9 e 8 (StudentIsApproved)
- Verificar se o estudante está em reprovado usando Theory e inline data com as notas 0,1,2,3,4 (StudentIsRepproved)
- Verificar se o estudante está em recuperação usando Theory e inline data com as notas 5,6 e 7 (StudentIsDependent)
