using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing push from VS 2022 -and now from sublime merge
            Secondary AuxiliarClass = new Secondary();
            Entity  EntityModel =  AuxiliarClass.CreateInstance();
            Console.WriteLine(string.Format( "This is the description for the entity model : {0}", EntityModel.Description) );
            Console.ReadLine();
        }
    }
}