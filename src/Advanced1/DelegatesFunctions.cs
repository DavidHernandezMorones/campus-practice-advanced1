using System;
using System.Collections.Generic;
using System.Linq;

namespace Advanced1
{
    public class DelegatesFunctions
    {
        public delegate List<T> ListSorts<T>(List<T> list);

        public delegate T GetValueList<T>(List<T> list);

        public delegate double GetValues<T>(List<T> list);

        public DelegatesFunctions(List<int> list)
        {
            ListSorts<int> ascending = AscendingOrder;
            ListSorts<int> descending = DescendingOrder;
            GetValueList<int> maxValue = GetMaxValue;
            GetValueList<int> minValue = GetMinValue;
            GetValues<int> average = GetAvgValue;
            GetValues<int> rootMeanSquare = RmS;

            Console.WriteLine("Ascending order");
            ascending(list).ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Descending order");
            descending(list).ForEach(x => Console.WriteLine(x));
            
            Console.WriteLine($"Max value from list: {maxValue(list)}");
            Console.WriteLine($"Min value from list: {minValue(list)}");
            Console.WriteLine($"Average value from list: {average(list)}");
            Console.WriteLine($"Root mean square value from list: {rootMeanSquare(list)}");
        }

        List<int> DescendingOrder(List<int> list)
        {
            list.Sort((a, b) => b.CompareTo(a));
            return list;
        }

        List<int> AscendingOrder(List<int> list)
        {
            list.Sort((a, b) => a.CompareTo(b));
            return list;
        }

        T GetMaxValue<T>(List<T> list)
        {
            return list.Max();
        }

        T GetMinValue<T>(List<T> list)
        {
            return list.Min();
        }

        double GetAvgValue(List<int> list)
        {
            return list.Average();
        }

        double RmS(List<int> list)
        {
            double powerSum = list.Sum(x => x * x);
            return Math.Sqrt(powerSum / list.Count);
        }
    }
}