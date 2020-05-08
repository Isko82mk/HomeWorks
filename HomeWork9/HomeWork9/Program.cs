using System;
using System.Collections.Generic;

namespace HomeWork9
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBookUser john = new PhoneBookUser( 1,"John",070632985);
            PhoneBookUser mike = new PhoneBookUser(2, "Mike", 065638782);
            PhoneBookUser jack = new PhoneBookUser(3, "Jack", 070222782);
            PhoneBookUser bill = new PhoneBookUser(4, "Bill", 073772772);
            PhoneBookUser villiam = new PhoneBookUser(5,"Villiam",075687687);

            Dictionary<int, PhoneBookUser> phoneBook = new Dictionary<int, PhoneBookUser>();
            phoneBook.Add(john.ID,john);
            phoneBook.Add(mike.ID,mike);
            phoneBook.Add(jack.ID,jack);
            phoneBook.Add(bill.ID, jack);
            phoneBook.Add(villiam.ID,villiam);

            PhoneBookUser John = phoneBook[1];
            PhoneBookUser Mike = phoneBook[2];
            PhoneBookUser Jack = phoneBook[3];
            PhoneBookUser Bill = phoneBook[4];
            PhoneBookUser Villiam = phoneBook[5];

            Console.WriteLine("Enter name");
            string userImput = Console.ReadLine();
            bool noName = false;
            foreach (KeyValuePair<int, PhoneBookUser> keyValue in phoneBook)
            {
                PhoneBookUser user = keyValue.Value;
                if (userImput == user.Name)
                {
                    Console.WriteLine($"User {user.Name} phone number is {user.PhoneNumber} ");
                    noName = true;
                }
            }
            if (!noName)
            {
                Console.WriteLine("Error....no such name");
            }
            
            Console.ReadLine();
        }
        public class PhoneBookUser
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int PhoneNumber { get; set; }

            public PhoneBookUser(int id,string name,int phoneNumber)
            {
                ID = id;
                Name = name;
                PhoneNumber = phoneNumber;
            }
        }

    }
}
