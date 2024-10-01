using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1 {
    internal class  Program
    {
        public static void Main(string[] args)
        {
            Repository repository = new Repository();
            var Animals = repository.GetAnimals;
            var newAnimals = Animals?.MySkip(2)?.MyTake(4);
            if (newAnimals != null)
            {
                foreach (var item in newAnimals)
                {
                    Console.WriteLine(item.Id);
                }
            }
            Console.ReadLine();
        }
    }
    public static class MyExtentionClass 
    {
        public static IEnumerable<T> MySkip<T>(this IEnumerable<T> Collection,int count) where T : Animal
        {
            if(count > Collection.Count())
                throw new IndexOutOfRangeException();
            if(Collection == null)
            {
                throw new ArgumentNullException(nameof(Collection));
            }
            int i = 0;
            foreach (var item in Collection)
            {
                if (i > count)
                    yield return item;
                i++;
            }
        }
        public static IEnumerable<T> MyTake<T>(this IEnumerable<T> values,int Count)
        {
            if(Count > values.Count())
                throw new IndexOutOfRangeException();
            if(values == null)
                throw new ArgumentNullException(nameof(values));

            int index = 0;
            foreach (var item in values)
            {
                if (index < Count)
                {
                    index++;
                    yield return item;
                }
                else
                {
                   break;
                }
            }
        }
    }
}
