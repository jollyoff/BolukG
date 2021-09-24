using System;

namespace ConsoleApp1 { 
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student { FirstName = "Болюк", SecondName = "Георгий", Fathers = "Юрьевич", age = "02.01.2003", course = "12-241", facultet = "ФКНФМ" };
            student.PrintName();
            student.PrintStudent();
            Student student1 = new Student { FirstName = "Пупкин", SecondName = "Василий", Fathers = "Петрович", age = "02.01.2000", course = "12-141м", facultet = "ФКНФМ" };
            student1.PrintName();
            student1.PrintStudent();
            Teacher teacher = new Teacher { FirstName = "Калчев", SecondName = "Юрий", Fathers = "Витальевич", age = "22.11.1983", dolzhnost = "Доцент", kafedra = "Оброзотворче мистецтво" };
            teacher.PrintName();
            teacher.PrintTeacher();
        }
    }
}
