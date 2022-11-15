using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var records = new List<PhoneRecord>();
            records.Add(new PhoneRecord() {Name = "Jone 1", Mobile = "12345", Email = "john1@gmail.com" });
            records.Add(new PhoneRecord() { Name = "Jone 2", Mobile = "22345", Email = "john2@gmail.com" });
            records.Add(new PhoneRecord() { Name = "Jone 3", Mobile = "32345", Email = "john3@gmail.com" });
            using (var writer = new StreamWriter(@"C:\Users\yanan\source\repos\.NET-learning\FileHandling\PhoneBook2.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }


            /*using (var reader = new StreamReader(@"C:\Users\yanan\source\repos\.NET-learning\FileHandling\PhoneBook.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<PhoneRecord>();
                foreach (var record in records)
                {
                    Console.WriteLine($"{record.Name} - {record.Mobile} - {record.Email}");
                }
            }*/





            /*Console.WriteLine("Enter the text to save in external file: ");
            string writeText = Console.ReadLine();
            File.WriteAllText("testfile.txt", writeText.ToUpper());

            string readText = File.ReadAllText("testfile.txt");
            Console.WriteLine(readText);*/
        }
    }
}
