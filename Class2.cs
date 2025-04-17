using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace lab2
{
    class ListAndFileWorker
    {
        public static float maxInList(string[] list)
        {
            float max = 0;
            try
            {
                max = float.Parse(list[0]);
            }
            catch (FormatException)
            {
                Console.WriteLine("где то в файле не число ");
            }
            foreach (string i in list)
            {
                try
                {
                    float checkValue = float.Parse(i);
                    if (max < checkValue)
                    {
                        max = checkValue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("где то в файле не число ");
                }
            }
            return max;
        }

        public static float minInList(string[] list)
        {
            float min = 0;
            try
            {
                min = float.Parse(list[0]);
            }
            catch (FormatException)
            {
                Console.WriteLine("где то в файле не число ");
            }
            foreach (string i in list)
            {
                try
                {
                    float checkValue = float.Parse(i);
                    if (min > checkValue)
                    {
                        min = checkValue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("где то в файле не число ");
                }
            }
            return min;
        }

        public static float summaOddElements (string[] list)
        {
            {
                float min = 0;
                try
                {
                    min = float.Parse(list[0]);
                }
                catch (FormatException)
                {
                    Console.WriteLine("где то в файле не число ");
                }

                int len = 0;
                foreach (string i in list)
                {
                    len++;
                }
                float summa = 0;
                
                for (int i = 1; i<len; i+=2)
                {
                    try
                    {
                        float checkValue = float.Parse(list[i]);
                        summa += checkValue;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("где то в файле не число ");
                    }
                }
                return summa;
            }
        }

        public static int counterOfWtf(string[] list)
        {
            int counter = 0;

            foreach (string i in list)
            {
                try
                {
                    float checkValue = float.Parse(i);
                    if(((checkValue/2)%2)==1)
                    {
                        counter++;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("где то в файле не число ");
                }
            }
            return counter;
        }

        public static void createFile(string filename)
        {
            FileStream file = File.Create(filename);
            file.Close();
        }

        public static string[] fromFileToList(string filename)
        {
            string finalLine = "";
            try
            {
                StreamReader file = new StreamReader(filename);
                string line = file.ReadLine();
                finalLine = line;
                line = file.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    finalLine = finalLine + " " + line;
                    line = file.ReadLine();
                }
                file.Close();
            }
            catch
            {
                finalLine =  "Error";
            }
            string[] fileNumbers = finalLine.Split(" ");
            return fileNumbers;
        }

        public static string[] fromFileToLetterArray(string filename)
        {
            string finalLine = "";
            try
            {
                StreamReader file = new StreamReader(filename);
                string line = file.ReadLine();
                finalLine = line.Substring(line.Length - 1);
                line = file.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    finalLine = finalLine + " " + line.Substring(line.Length - 1);
                    line = file.ReadLine();
                }
                file.Close();
            }
            catch
            {
                finalLine = "Error";
            }
            string[] fileNumbers = finalLine.Split(" ");
            return fileNumbers;
        }


        public static void fromListToFile(string filename, string[] list)
        {
            try
            {
                StreamWriter file = new StreamWriter(filename);
                foreach (string i in list)
                {
                    try
                    {
                        file.WriteLine(i);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Something get wrong ");
                    }
                }
                file.Close();
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        public static void somethingToFile(string filename)
        {
            StreamWriter file = new StreamWriter(filename);
            Random rand = new Random();
            int len = rand.Next(20);
            int height = rand.Next(1,30);
            double firstNum = rand.Next(5000);
            string line = firstNum + "";
            for (int i = 0; i < height; i++)
            {
                for(int j = 0; j<len-1; j++)
                {
                    line = line +" "+ rand.Next(5000);
                }
                file.WriteLine(line);
                line = rand.Next(5000) + "";
                len = rand.Next(20);
            }
            file.Close();
        }

        public static void somethingToFile(string filename, byte len)
        {
            StreamWriter file = new StreamWriter(filename);
            Random rand = new Random();
            int height = rand.Next(1, 30);
            int firstNum = rand.Next(5000);
            string line = firstNum + "";
            for (byte i = 0; i < height; i++)
            {
                for (byte j = 0; j < len - 1; j++)
                {
                    line = line + " " + rand.Next(5000);
                }
                try
                {
                    file.WriteLine(line);
                }
                catch
                {
                    Console.WriteLine("Error");
                }
                line = rand.Next(5000) + "";
            }
            file.Close();
        }

        public static void somethingToFileBinary(string filename)
        {
            using BinaryWriter file = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate));
            {
                Random rand = new Random();
                int height = rand.Next(1, 30);
                for (int i = 0; i < height; i++)
                {
                    file.Write(rand.Next(5000));
                }
                file.Close();
            }
        }

        public static string[] somethingFromFileBinary(string filename)
        {
            using BinaryReader file = new BinaryReader(File.Open(filename, FileMode.OpenOrCreate));
            {
                try
                {
                    string line = " ";
                    line = file.ReadInt32() + "";
                    string finalLine = line;
                    bool finishFile = false;
                    while (finishFile == false)
                    {
                        try
                        {
                            line = file.ReadInt32() + "";
                            finalLine = finalLine + " " + line;
                        }
                        catch
                        {
                            finishFile = true;
                        }
                    }
                    file.Close();
                    string[] result = finalLine.Split(" ");
                    return result;

                }
                catch
                {
                    Console.WriteLine("Error");
                    string[] result = { "Error" };
                    return result;
                }
            }
        }
    }
}
