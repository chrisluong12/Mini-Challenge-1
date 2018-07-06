using System;
using System.IO;
using System.Text;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            String file = "";
            String content = "";
            int count = 0;

            Console.WriteLine("Document");
            Console.WriteLine("\n");

            Console.WriteLine("Please enter the name of the document");
            file = Console.ReadLine();

            Console.WriteLine("Please enter content of the document");
            content = Console.ReadLine();

            file += ".txt";

            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamWriter sw = new StreamWriter(file);

                sw.Write(content);
                sw.Close();

                //Read the first line of text

                StreamReader sr = new StreamReader(file);
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(content);
                    //Read the next line
                    line = sr.ReadLine();
                    count++; //this will count the line
                }

                Console.WriteLine(file + " was successfully saved. The document contains " + count + " characters." + file + " and " + count + " are placeholders for the filename of the document and the number of characters it contains");

                //close the file
                sr.Close();
               // Console.ReadLine();
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
