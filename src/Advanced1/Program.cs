using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Advanced1
{
    class Program
    {
        delegate void Print<T>(T t);

        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            DelegateAction myAction = new DelegateAction(numbers);
            DelegatePredicate myPredicate = new DelegatePredicate(5);
            DelegatesFunctions myFunctions = new DelegatesFunctions(numbers);
            Print<int> printToConsole = x => Console.WriteLine($"Print something to console... {x}");
            printToConsole(5);

            Entity anyPerson = new Entity
            {
                Age = 22,
                Email = "asaa@mail.com",
                Id = 1,
                Name = "pedro"
            };

            Action<Entity> action;
            Func<string, Entity, string> func;
            Predicate<Entity> predicate;

            action = (entity) =>
            {
                entity.Id += 1;
                Console.WriteLine($"New id of {entity.Name}: {entity.Id}");
            };

            func = (regex, entity) =>
            {
                bool isEmail = Regex.IsMatch(anyPerson.Email, regex);
                return isEmail ? entity.Email : $"{entity.Name}.{entity.Id}_{entity.Age}@.com";
            };

            predicate = entity => { return entity.Age >= 18; };

            action(anyPerson);
            anyPerson.Email = func(@"[a-z]+@mail\.com", anyPerson);
            Console.WriteLine(predicate(anyPerson)? "Great! and adult" : "Sorry, you have to be greater than 17 years old");
            predicate(anyPerson);
        }
    }
}