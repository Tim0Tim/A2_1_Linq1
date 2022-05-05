using System;
using System.Linq;

namespace A2_1_LINQ1
{
    class Program
    {
        static void Main()
        {
            var invoice = new[]
            {
                new Invoice(83,"Electric sander",7,57.98M),
                new Invoice(24,"Power saw", 18,9.99M),
                new Invoice(7,"Sledge hammer",11,21.50M),
                new Invoice(77,"Hammer",76,11.99M),
                new Invoice(39,"Lawn mower",3,79.50M),
                new Invoice(68,"Screwdriver", 106,6.99M),
                new Invoice(56, "Jig saw", 21, 11.00M),
                new Invoice(3, "Wrench",34,7.50M)
            };

            Console.WriteLine("type 1 to sort by part description\ntype 2 to sort by price\ntype 3 to show only items and sort by quantity\ntype 4 to only show items sort by value\ntype 5 to sort items by value between $200 & $500");
            int sss = Int32.Parse(Console.ReadLine());

            if (sss == 1)
            {
                var bydes =
                    from e in invoice
                    orderby e.PartDescription
                    select e;
                Console.WriteLine("order by item\n");

                foreach (var element in bydes)
                {
                    Console.WriteLine(element);
                }
            }
            else if (sss == 2)
            {
                var bypri =
                    from e in invoice
                    orderby e.Price
                    select e;

                Console.WriteLine("order by price\n");

                foreach (var element in bypri)
                {
                    Console.WriteLine(element);
                }
            }
            else if (sss == 3)
            {
                var bypdq =
                    from e in invoice
                    orderby e.Quantity
                    select e;

                Console.WriteLine("order by quantity\n");

                foreach( var element in bypdq)
                {
                    Console.WriteLine(element.Quantity + "    " + element.PartDescription);
                }
            }
            else if (sss == 4)
            {
                var byqpa =
                    from e in invoice
                    orderby e.Quantity * e.Price
                    select e;

                Console.WriteLine("sorted by value\n");

                foreach(var element in byqpa)
                {
                    Console.WriteLine(element + "   TotalValue: $" +(element.Quantity*element.Price));
                }
            }
            else if (sss == 5)
            {
                var byqtp =
                    from e in invoice
                    where (e.Price * e.Quantity >= 200) && (e.Price * e.Quantity <= 500)
                    select e;

                foreach(var element in byqtp)
                {
                    Console.WriteLine(element+ "    TotalValue: $"+ (element.Price*element.Quantity));
                }
            }
            else
            {
                Console.WriteLine("invalid integer submitted");
            }
        }
    }
}
