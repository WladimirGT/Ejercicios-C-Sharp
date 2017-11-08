/*El siguiente código utiliza la clase StreamWriter para abrir, 
escribir y cerrar el archivo de texto. De forma similar a la 
clase StreamReader, puede pasar la ruta de acceso de un archivo 
de texto al constructor StreamWriter para abrir el archivo 
automáticamente. El método WriteLine escribe una línea completa 
de texto en el archivo de texto. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace hola
{
    class Program
    {
        static void 
        Main(string[] args)
        {
          try {

//Pass the filepath and filename to the StreamWriter Constructor
StreamWriter sw = new StreamWriter("D:\\Test.txt");

//Write a line of text
sw.WriteLine("Hello World!!");

//Write a second line of text
sw.WriteLine("From the StreamWriter class");

sw.WriteLine("Hola mundo...");

//Close the file
sw.Close();
}
catch(Exception e)
{
Console.WriteLine("Exception: " + e.Message);
}
finally 
{
Console.WriteLine("Executing finally block.");
}
        }
    }
}

