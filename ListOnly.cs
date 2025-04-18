using System;


namespace lab2
{
    class ListOnly
    {
        public static List<string> makeListFull(List<string> list)//заполнение списка пользователем
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

        public static void printList<T>(List<T> list)//вывод списка
        {
            foreach (T el in list)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }

        public static LinkedList<T> fromListToLinkedList<T>(List<T> list)//перенос списка в двусвязный список
        {
            LinkedList<T> L = new LinkedList<T>(list);
            return L;
        }

        public static List<T> deleteDublicates<T>(List<T> list)//удалить повторы в списке
        {
            T elementBefore = list[0];
            for (int i = 1;i<list.Count;i++)
            {
                if (EqualityComparer<T>.Default.Equals(list[i], elementBefore))
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
