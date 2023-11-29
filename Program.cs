using System;
using System.Linq;
namespace ExcelColumnTitleToColumnNumber
{
    class Program
    { 
    static void Main()
    {
        Console.Write("Enter Excel column title: ");
        string columnTitle = Console.ReadLine().ToUpper(); // Convert to uppercase 
        int columnNumber = ColumnTitleToColumnNumber(columnTitle);
        Console.WriteLine($"The column number for {columnTitle} is {columnNumber}");

        //solution using LINQ
        int alternativeColumnNumber = TitleToNumberLinq(columnTitle);
        Console.WriteLine($"(Linq) The column number for {columnTitle} is {alternativeColumnNumber}");
    }

    static int ColumnTitleToColumnNumber(string columnTitle)
    {
        int result = 0;

        foreach (char c in columnTitle)
        {
            Console.WriteLine("value :" +c);
            result = result * 26 + (c - 'A' + 1);
        }

        return result;
    }

    //  using LINQ
    static int TitleToNumberLinq(string columnTitle)
    {
        return columnTitle.Aggregate(0, (result, c) => result * 26 + (c - 'A' + 1));
    }
    }
}
