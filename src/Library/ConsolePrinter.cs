using System;


namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter : IConsolePrinter{

        public  void Print(string printable){
            
            Console.WriteLine(printable);

        }


    }

}