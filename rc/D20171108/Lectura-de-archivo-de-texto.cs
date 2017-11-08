/*El siguiente código utiliza la clase StreamReader para abrir, 
leer y cerrar el archivo de texto. La ruta de acceso de un archivo 
de texto puede pasar al constructor StreamReader para abrir el archivo
 automáticamente. El método ReadLine lee cada línea de texto e incrementa 
 el puntero de archivo a la siguiente línea como lo lee. Cuando el método 
 ReadLine alcanza el final del archivo, devuelve una referencia nula. */


/*using System;
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
            String line; try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\Sample.txt");

                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
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

*/
