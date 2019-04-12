using System;
using System.Collections.Generic;
using System.IO;
using NLog;

namespace EssentialTrainingApp
{
    class Program
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public static List<string> Words;
        static void Main(string[] args)
        {
            logger.Trace("The program started");
            Words = new List<string>();
            Words.Add("Bread");
            Words.Add("Milk");
            Words.Add("Cheese");

            CrazyMathProblem();
            ReadTextFile();
            Console.ReadLine();
        }

        private static void ReadTextFile()
        {
            try
            {
                using (var sr = new StreamReader(@"C:\temp\test.txt"))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }

            catch (System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("Could not find the directory" + ex.Message);
                logger.Error("The directory was not found" + ex.Message);
            }

            catch(System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("Could not find the File" + ex.Message);
                logger.Error(ex.Message);
            }

            catch(Exception ex)
            {
                Console.WriteLine("Unknown error occurred" + ex.Message);
            }

            finally
            {
                Console.WriteLine("The finally runs all the time");
            }
        }
        private static int CrazyMathProblem()
        {
            var income = 1000;
            for (var i = 10; i > 0; i--)
            {
                income = income = (income / i);
            }

            return income;
        }
    }
}
