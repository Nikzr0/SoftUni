using System;
using System.Collections.Generic;
using System.Linq;
internal class Program
{
    static void Main()
    {

    }
}

internal class MyWhere
{
    static List<int> MyWhere(List<int> list, Func<int, bool> condition)
    {
        List<int> newList = new List<int>();
        foreach (var item in list)
        {
            if (condition(item))
            {
                newList.Add(item);
            }
        }
        return newList;
    }


    //static void Main()
    //{
    //    var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    //    List<int> newListInt = list.MyWhere(x => x % 2 == 0); // ? 
    //    Console.WriteLine(String.Join(" ", newListInt));
    //}
}

internal class WorkWithAction
{

    static void sayHi(string name)
    {

        Console.WriteLine($"Hi :) {name}");
    }

    //static void Main()
    //{
    //    string name = Console.ReadLine();
    //    Action<string> action = sayHi;
    //    action(name);
    //}
}
internal class TaxesExWithFunk
{

    static double Taxes(double tax)
    {
        return tax / 5;
    }

    static double SalaryAfterTaxes(double salary, Func<double, double> funk)
    {
        return salary - funk(salary);
    }

    //static void Main()
    //{
    //    Func<double, double> funk = Taxes;
    //    double salary = double.Parse(Console.ReadLine());
    //    Console.WriteLine(SalaryAfterTaxes(salary, Taxes/*funl*/));
    //}
}
class FunkInsideOfAMethod
{
    static double Taxes(double tax)
    {
        return tax / 5;
    }

    static double SalaryAfterTaxes(double salary, Func<double, double> funk)
    {
        return salary - funk(salary);
    }

    //static void Main()
    //{
    //    Func<double, double> funk = Taxes;
    //    double salary = double.Parse(Console.ReadLine());
    //    Console.WriteLine(SalaryAfterTaxes(salary, funk));
    //}
}
class Storage
{
    static string SyaHi(string name)
    {
        return $"Hi {name}";
    }

    static double TaxCalculator(double salory)
    {
        return salory / 5;
    }

    static double SalaryAftreTaxes(double salory)
    {
        return salory - salory / 5;
    }

    //static void Main()
    //{
    //    string name = Console.ReadLine();
    //    Func<string, string> hiFunk = SyaHi; // It's used to make code easier for updates

    //    Console.WriteLine(hiFunk(name));

    //    double salary = int.Parse(Console.ReadLine());
    //    Func<double, double> salaryCal = TaxCalculator;
    //    Console.WriteLine(salaryCal(salary));

    //    Func<double, double> salaryAfterTaxes = SalaryAftreTaxes;
    //    Console.WriteLine(salaryAfterTaxes(salary));

    //}
}