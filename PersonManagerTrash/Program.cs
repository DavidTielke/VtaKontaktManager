using System;
using System.Collections.Generic;
using VTA.ContactManager.CrossCutting.DataClasses;
using VTA.ContactManager.Logic.PersonManagement;

namespace VTA.ContactManager.UI.PersonManagerTrash
{
    class Program
    {
        private static PersonManager _manager;

        static void Main(string[] args)
        {
            _manager = new PersonManager();
            var adults = _manager.GetAllAdults();
            var children = _manager.GetAllChildren();

            Show(adults, children);

            Console.ReadKey();
        }

        private static void Show(List<Person> adults, List<Person> children)
        {
            PrintTable("Erwachsene", adults);
           PrintTable("Kinder", children);
        }

        private static void PrintTable(string title, List<Person> adults)
        {
            Console.WriteLine($"### {title} ({adults.Count})###");
            adults.ForEach(a => Console.WriteLine("{0,-5} {1,-10} {2,-5}", a.Id, a.Name, a.Age));
        }
    }
}
