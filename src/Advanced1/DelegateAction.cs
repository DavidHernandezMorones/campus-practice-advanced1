using System;
using System.Collections.Generic;
using System.Linq;

namespace Advanced1
{
    public class DelegateAction
    {
        delegate void ListNumbers<T>(List<T> list);


        public DelegateAction(List<int> list)
        {
            ListNumbers<int> listEvenNumbers = list =>
            {
                foreach (var i in list.Where(x => x % 2 == 0))
                {
                    Console.WriteLine(i);
                }
            };

            ListNumbers<int> listOddNumbers = list =>
            {
                foreach (int i in list.Where(x => x % 2 != 0))
                {
                    Console.WriteLine(i);
                }
            };
            
            Console.WriteLine("Even numbers from list: ");
            listEvenNumbers(list);
            
            Console.WriteLine("Odd numbers from list: ");
            listOddNumbers(list);
        }
    }
}