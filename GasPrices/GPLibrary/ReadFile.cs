using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GPLibrary
{
    public class ReadFile
    {
        public static List<string> FileReader(string fileName)
        {
            List<string> returnList = new List<string>();
            StreamReader inputfile;
            try
            {
                inputfile = File.OpenText(fileName);

                while (inputfile.EndOfStream == false)
                {
                    returnList.Add(inputfile.ReadLine());
                }
                inputfile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            return returnList;
        }
        public static void FileWriter(string newName)
        {
            StreamWriter outFile;
            try
            {
                outFile = File.CreateText(newName);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
