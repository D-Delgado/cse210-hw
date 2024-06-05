using System;

class Program
{
    static void Main(string[] args)
    {
        var lecture = new Lecture(
            "Spring Equinox History",
            "Learn the history of the Spring Equinox",
            "3/21/2024",
            "10:00 AM",
            new Address("50 W Viking St", "Rexburg", "ID", "83460", "USA"),
            "Persephone Hades",
            100
        );

        var reception = new Reception(
            "Fall Equinox Reception",
            "Celebration of the Fall",
            "9/21/2024",
            "6:00 PM",
            new Address("28 Carlson Ave", "Rexburg", "ID", "83460", "USA"),
            "rsvp@events.com"
        );

        var outdoor = new Outdoor(
            "Summer Solstice Picnic",
            "Join us for a picnic on the longest day of the year",
            "6/21/2024",
            "5:00 PM",
            new Address("50 W 2nd N", "Rexburg", "ID", "83440", "USA"),
            "Sunny"
        );

        var events = new List<Event> { lecture, reception, outdoor };

        foreach (var ev in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("Full Details:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("Short Description:");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }
    }
}