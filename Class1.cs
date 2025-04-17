using System;


namespace lab2
{
    class ListOnly
    {
        public static List<string> makeListFull(List<string> list)
        {
            Console.WriteLine("Введите что-то");
            string element = Console.ReadLine();
            while (element != "q")
            {
                list.Add(element);
                Console.WriteLine("Введите что-то");
                element = Console.ReadLine();
            }
            return list;
        }

        public static void printList(List<string> list)
        {
            foreach (string el in list)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }

        public static LinkedList<string> fromListToLinkedList(List<string> list)
        {
            LinkedList<string> L = new LinkedList<string>(list);
            return L;
        }

        public static List<string> deleteDublicates(List<string> list)
        {
            string elementBefore = "q";
            for (int i =0;i<list.Count;i++)
            {
                if (list[i] == elementBefore)
                {
                    list.RemoveAt(i);
                    i--;
                }
                else
                {
                    elementBefore = list[i];
                }
            }
            return list;
        }
    }
}
