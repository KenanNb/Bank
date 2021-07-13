using System;

namespace Bank
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Card CreditCard { get; set; }
        public User[] user { get; set; }
        public User()
        {
        }
        
        void show()
        {
            Console.WriteLine("=============User Info===========");
            Console.WriteLine($"Name : ");
        }

    }
}
