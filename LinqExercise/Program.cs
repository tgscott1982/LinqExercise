﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqExercise;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine($"{numbers.Sum()}\n");
            //TODO: Print the Average of numbers
            Console.WriteLine($"{numbers.Average()}\n");
            //TODO: Order numbers in ascending order and print to the console
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            //TODO: Order numbers in decsending order adn print to the console
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            //TODO: Print to the console only the numbers greater than 6
            numbers.Where(x => x > 6).ToList ().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            numbers.OrderBy(x => x).Take(4).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            numbers.SetValue(40, 4);
            numbers.OrderByDescending(x =>x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.
            employees.Where(x => x.FirstName[0] == 'S' || x.FirstName[0] == 'C').OrderBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();
            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35
            employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).ToList(); Console.WriteLine($"YOE Sum = {employees.Sum(x => x.YearsOfExperience)} and Average YOE = {employees.Average(x => x.YearsOfExperience)}");
            Console.WriteLine();
            //TODO: Add an employee to the end of the list without using employees.Add()
            var newemployees = employees.Append(new Employee() { FirstName = "Travis", LastName = "Gersch", Age = 40, YearsOfExperience = (3 / 52) });

            Console.WriteLine();
            newemployees.ToList().ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName + " " + "|| Age " + x.Age + ", " + "YOE " + x.YearsOfExperience));
            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        public static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
