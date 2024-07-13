
using System;

namespace lab3
{
    class Omar
    {
        static void Main()
        {

            Book bo1 = new Book(1, "omar", "action", "2005", "2225", true);
            Book bo2 = new Book(2, "omar", "action", "2005", "2225", true);
            bo1.printt();

            Console.WriteLine(bo1.Deleted());
            Console.WriteLine(Book.count);
        }
    }
 
    class Book
    {
        int id;
        string name;
        string type;
        string createdon;
        bool isDeleted;
        string price;
        public static int count = 0;

        public Book(int id, string name)
        {
            this.id = id;
            this.name = name;

        }
        public Book(string type, string createdon)
        {
            this.type = type;
            this.createdon = createdon;
        }
        public Book(int id, string name, string type, string createdon, string price, bool isDeleted)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.createdon = createdon;
            this.price = price;
            this.isDeleted = isDeleted;
            count++;

        }
        public void printt()
        {
            Console.WriteLine($"{id} - {name} - {type} - {createdon} - {price} - {isDeleted}");
        }
        public string Deleted()
        {
            return isDeleted ? "book is deleted" : "book is not deleted";
        }

    }

}

