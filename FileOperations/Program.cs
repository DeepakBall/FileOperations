using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadATextFile
{
    class Program
    {
        // Default folder    
        static readonly string rootFolder = @"C:\Users\deepak.balla\OneDrive - ServiceNow\Desktop\Automations\C#\";    
            //Default file. MAKE SURE TO CHANGE THIS LOCATION AND FILE PATH TO YOUR FILE   
  static readonly string textFile = @"C:\Users\deepak.balla\OneDrive - ServiceNow\Desktop\Automations\C#\Authors.txt";

        static void Main(string[] args)
        {
            if (File.Exists(textFile))
            {
                // Read entire text file content in one string    
                string text = File.ReadAllText(textFile);
                Console.WriteLine(text);
            }

            if (File.Exists(textFile))
            {
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(textFile);
                foreach (string line in lines)
                    Console.WriteLine(line);
            }

            if (File.Exists(textFile))
            {
                // Read file using StreamReader. Reads file line by line  
                using (StreamReader file = new StreamReader(textFile))
                {
                    int counter = 0;
                    string ln;

                    while ((ln = file.ReadLine()) != null)
                    {
                        Console.WriteLine(ln);
                        counter++;
                    }
                    file.Close();
                    
                }
            }

            Console.ReadKey();
        }
    }
}