using lab2;
using System;
using System.IO;


internal class Program
{
    private static void Main()
    {
        bool globalFlag = true;
        while (globalFlag == true)
        {
            Console.WriteLine("Введите номер задания(от 1 до 10), на q выход ");
            string numberOfTask = Console.ReadLine();

            if (numberOfTask == "1")//задание 1
            {
                ListAndFileWorker.somethingToFile("C:/Users/алексей/Desktop/f.txt", 1);
                
                bool flagOfFirstTask = true;
                double max;
                double min;
                string[] fileNumbers = [];
                while (flagOfFirstTask == true)
                {
                    fileNumbers = ListAndFileWorker.fromFileToList("C:/Users/алексей/Desktop/f.txt");
                    if (fileNumbers[0] == "Error")
                    {
                        Console.WriteLine("мистаке");
                    }
                    else
                    {
                        flagOfFirstTask = false;
                    }
                }

                Console.WriteLine("Содержимое файла:");
                foreach (string i in fileNumbers)
                {
                    Console.Write(i + " ");
                }
                max = ListAndFileWorker.maxInList(fileNumbers);
                min = ListAndFileWorker.minInList(fileNumbers);
                double res = (max - min) * (max - min);
                string[] result = [res + ""];
                ListAndFileWorker.fromListToFile("C:/Users/алексей/Desktop/output.txt", result);
                Console.WriteLine("Число: " + result[0] + " добавлено в файл - это квадрат разности чисел: " + max + " и " + min);
            }

            else if (numberOfTask == "2")//задание 2
            {
                ListAndFileWorker.somethingToFile("C:/Users/алексей/Desktop/f.txt");

                bool flagOfFirstTask = true;
                double summa;
                string[] fileNumbers = [];
                while (flagOfFirstTask == true)
                {
                    fileNumbers = ListAndFileWorker.fromFileToList("C:/Users/алексей/Desktop/f.txt");
                    if (fileNumbers[0] == "Error")
                    {
                        Console.WriteLine("мистаке");
                        continue;
                    }
                    else
                    {
                        flagOfFirstTask = false;
                    }
                }

                Console.WriteLine("Содержимое файла:");
                foreach (string i in fileNumbers)
                {
                    Console.Write(i + " ");
                }
                summa = ListAndFileWorker.summaOddElements(fileNumbers);
                string[] result = [summa+""];
                ListAndFileWorker.fromListToFile("C:/Users/алексей/Desktop/output.txt", result);
                Console.WriteLine("Число: " + result[0] + " добавлено в файл - это сумма нечетных элементов");
            }

            else if (numberOfTask == "3")//задание 3
            {
                bool flagOfFirstTask = true;
                double summa;
                string[] fileNumbers = [];
                while (flagOfFirstTask == true)
                {
                    fileNumbers = ListAndFileWorker.fromFileToLetterArray("C:/Users/алексей/Desktop/f1.txt");
                    if (fileNumbers[0] == "Error")
                    {
                        Console.WriteLine("мистаке");
                        continue;
                    }
                    else
                    {
                        flagOfFirstTask = false;
                    }
                }

                Console.WriteLine("Содержимое файла:");
                foreach (string i in fileNumbers)
                {
                    Console.Write(i + " ");
                }
                ListAndFileWorker.createFile("C:/Users/алексей/Desktop/baobab.txt");
                ListAndFileWorker.fromListToFile("C:/Users/алексей/Desktop/baobab.txt", fileNumbers);
                Console.WriteLine(" добавлено в файл baobab.txt");
            }

            else if(numberOfTask == "4")
            {
                ListAndFileWorker.somethingToFileBinary("C:/Users/алексей/Desktop/f.txt");

                bool flagOfFirstTask = true;
                double summa;
                string[] fileNumbers = [];
                while (flagOfFirstTask == true)
                {
                    fileNumbers = ListAndFileWorker.somethingFromFileBinary("C:/Users/алексей/Desktop/f.txt");
                    if (fileNumbers[0] == "Error")
                    {
                        Console.WriteLine("мистаке");
                        continue;
                    }
                    else
                    {
                        flagOfFirstTask = false;
                    }
                }
                int counter = ListAndFileWorker.counterOfWtf(fileNumbers);
                Console.WriteLine("Содержимое файла:");
                foreach (string i in fileNumbers)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                string[] result = [counter + ""];
                ListAndFileWorker.fromListToFile("C:/Users/алексей/Desktop/output.txt", result);
                Console.WriteLine("Число странных элементов закинуто в файл output.txt, а всего их: " + counter);
            }
            else if(numberOfTask == "5")
            {

            }

            else if (numberOfTask == "6")
            {
                Console.WriteLine("Прошу заполнить список, на q закончить ввод");
                List<string> list = ListOnly.makeListFull([]);

                ListOnly.printList(list);

                Console.WriteLine("А теперь удалим повторения");

                list = ListOnly.deleteDublicates(list);

                ListOnly.printList(list);

            }

            else if (numberOfTask == "7")
            {
                Console.WriteLine("Прошу заполнить список, на q закончить ввод");
                List<string> list = ListOnly.makeListFull([]);

                ListOnly.printList(list);

                Console.WriteLine("А теперь из него сделаем двусвязный");

                LinkedList<string> L = ListOnly.fromListToLinkedList(list);

                ListOnly.printList(list);

            }

            else if (numberOfTask == "q")
            {
                globalFlag = false;
            }
            else
            {
                Console.WriteLine("Неверный номер задания");
            }
        }
    }
}