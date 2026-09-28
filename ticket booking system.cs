using System;
using System.Collections.Generic;
using System.Text;

namespace practiceC_
{
    class Driver
    {
        public string name;
        public string phone;
        public int age;
    }

    class Bus
    {
        public string vehicle_no;
        public string model;
        public string color;
    }

    class Passenger
    {
        public string name;
        public string phone;
        public int age;
    }

    class Ticket
    {
        public string ticket_no;
        public string seat_no;

        public void GenerateReport(Driver d, Bus b, Passenger p)
        {
            Console.WriteLine("Ticket Number: " + ticket_no);
            Console.WriteLine("Ticket Seat No: " + seat_no);
            Console.WriteLine();

            Console.WriteLine("Driver Name: " + d.name);
            Console.WriteLine("Driver Age: " + d.age);
            Console.WriteLine("Driver Phone: " + d.phone);
            Console.WriteLine();

            Console.WriteLine("Bus Vehicle No: " + b.vehicle_no);
            Console.WriteLine("Bus Model: " + b.model);
            Console.WriteLine("Bus Color: " + b.color);
            Console.WriteLine();

            Console.WriteLine("Passenger Name: " + p.name);
            Console.WriteLine("Passenger Age: " + p.age);
            Console.WriteLine("Passenger Phone: " + p.phone);
        }
    }

    internal class ticket_booking_system
    {
        static void Main()
        {
            Driver[] d = new Driver[1];
            Bus[] b = new Bus[1];
            Passenger[] p = new Passenger[1];
            Ticket[] t = new Ticket[1];

            string ticket;

            for (int i = 0; i < 1; i++)
            {
                d[i] = new Driver();
                p[i] = new Passenger();
                b[i] = new Bus();
                t[i] = new Ticket();

                Console.Write("Enter name of " + (i + 1) + " driver: ");
                d[i].name = Console.ReadLine();

                Console.Write("Enter age of " + (i + 1) + " driver: ");
                d[i].age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number of " + (i + 1) + " driver: ");
                d[i].phone = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Enter name of " + (i + 1) + " passenger: ");
                p[i].name = Console.ReadLine();

                Console.Write("Enter age of " + (i + 1) + " passenger: ");
                p[i].age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number of " + (i + 1) + " passenger: ");
                p[i].phone = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Enter number of " + (i + 1) + " vehicle: ");
                b[i].vehicle_no = Console.ReadLine();

                Console.Write("Enter color of " + (i + 1) + " vehicle: ");
                b[i].color = Console.ReadLine();

                Console.Write("Enter model of " + (i + 1) + " vehicle: ");
                b[i].model = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Enter ticket " + (i + 1) + " ticket number: ");
                t[i].ticket_no = Console.ReadLine();

                Console.Write("Enter seat number of " + (i + 1) + " this ticket: ");
                t[i].seat_no = Console.ReadLine();
            }

            for (int i = 0; i < 1; i++)
            {
                Console.Write("Enter your ticket number for info: ");
                ticket = Console.ReadLine();

                if (ticket == t[i].ticket_no)
                {
                    t[i].GenerateReport(d[i], b[i], p[i]);
                }
            }
        }
    }
}
