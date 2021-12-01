using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab4
{
    class List:IEnumerable //Интерфейс, читай на метаните, я сам не понимаю
    {
        private readonly List<int> list1; //Список элементов для КАЖДОГО ЭКЗЕМПЛЯРА отдельно 

        public List(List<int> list1) //Конструктор
        {
            this.list1 = list1;
        }

        public IEnumerator GetEnumerator() //Задает перечисление, чтоб можно было пользоваться foreach
        {
            return list1.GetEnumerator();
        }

        public static List<int> operator +(List item1, int item2)
        {
            item1.list1.Add(item2);
            return item1.list1;
        }
        public static List operator --(List list)
        {
            list.list1.RemoveAt(list.list1.Count-1); //Удаляет последний (индекс с 0)
            return list;
        }

        public static bool operator !=(List list1, List list2)
        {
            if (list1.list1.Count != list2.list1.Count)
                return true;
            else
            {
                for (int i = 0; i < list1.list1.Count; i++)
                {
                    if (list1.list1[i] == list2.list1[i])
                        continue;
                    else
                        return true;
                }
            }
            return false;
        }
        public static bool operator == (List list1, List list2)
        {
            if (list1.list1.Count != list2.list1.Count)
                return false;
            else
            {
                for (int i = 0; i < list1.list1.Count; i++)
                {
                    if (list1.list1[i] == list2.list1[i])
                        continue;
                    else
                        return false;
                }
            }
            return true;
        }
        public static bool operator true(List list)
        {
            {
                for (int i = 0; i < list.list1.Count - 1; i++)
                {
                    if (list.list1[i] < list.list1[i + 1])
                        continue;
                    else
                        return false;
                }
                return true;

            }
        }
        public static bool operator false(List list)
        {
            for (int i = 0; i < list.list1.Count-1; i++)
            {
                if (list.list1[i] > list.list1[i + 1])
                    continue;
                else
                    return false;
            }
            return true;

        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

    }
}
