using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class DataClasses
    {
        /*AUTHOR: NICHOLAS SIM
         DATE: 01-09-2019
         CLASS: CPG200
         OBJECTIVE: Create a program that reads database and provides detailed information on products.
        */
        public class Product
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public Product(int id, string name)
            {
                ID = id;
                Name = name;

            }
        }

        public class Supplier
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public Supplier(int id, string name)
            {
                ID = id;
                Name = name;

            }
        }

        public class Category
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public Category(int id, string name)
            {
                ID = id;
                Name = name;

            }
        }




    }
}
