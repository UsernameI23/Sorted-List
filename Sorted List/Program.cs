using System.Collections.Generic;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedList<string, string> birthdayList = new SortedList<string, string>();

            birthdayList.Add("March", "31");
            birthdayList.Add("August", "2");
            birthdayList.Add("April", "17");
            birthdayList.Add("December", "18");
            birthdayList.Add("October", "5");

            Console.WriteLine("The clubs birthday list is");
            foreach (KeyValuePair<string, string> bl in birthdayList)
            {
                Console.WriteLine($"Key = {bl.Key}  Value={bl.Value}");
            }
            Console.WriteLine("When is your birth month");
            string month = Console.ReadLine();
            Console.WriteLine("When is your birth day?");
            string day = Console.ReadLine();

            if (birthdayList.ContainsValue(month))
                Console.WriteLine($"{month} is one of the values in your list");
            else
            {

                if (birthdayList.ContainsKey(day))
                {
                    Console.WriteLine($"{day} is invalid ");
                }
                else
                {
                    birthdayList.Add(day, month);
                    Console.WriteLine($"{month} {day} was added to your list");
                }
                birthdayList.RemoveAt(2);
            }

            foreach (KeyValuePair<string, string> bl in birthdayList)
            {
                Console.WriteLine($"Key = {bl.Key}  Value={bl.Value}");
            }
        }
    }
}
