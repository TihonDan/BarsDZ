using System;
using System.Collections.Generic;

namespace _2_Задание
{
    class Program
    {
        static List<Entity<string>> person = new List<Entity<string>>()
        {
                new Entity<string> (1, 0, "Root entity"),
                new Entity<string> (2, 1, "Child of 1 entity"),
                new Entity<string> (3 , 1,"Child of 1 entity"),
                new Entity<string> (4, 2, "Child of 2 entity"),
                new Entity<string> (5, 4, "Child of 4 entity")

        };

        static void Main(string[] args)
        {

        }

        static List<string> Method()
        {
            var list = new List<Entity<string>>();
            foreach(var per in person)
            {
                per.
            }
            
        }

        public class Entity<T>
        {
            public int Id { get; set; }
            public int ParentId { get; set; }
            public string Name { get; set; }

            public Entity(int id, int pID, string name)
            {
                Name = name;
                ParentId = pID;
                Id = id;
            }
        }

    }

    
}
