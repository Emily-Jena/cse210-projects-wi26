using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Clear();
        Console.WriteLine(" ~ Welcome to the Online Ordering Store ~ ");
        Console.WriteLine("Please enter the following details: ");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine();

        Console.Write("Full name: "); string name = Console.ReadLine();
        Console.Write("Address: "); string street = Console.ReadLine();
        Console.Write("City: "); string city = Console.ReadLine();
        Console.Write("State/Province: "); string state = Console.ReadLine();
        Console.Write("Country: "); string country = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine();

         // Create objects with user personal info & order
        Address userAddress = new Address(street, city, state, country);
        Customer userCustomer = new Customer(name, userAddress);
        Order userOrder = new Order(userCustomer);

        // List 
        List<Product> catalog = new List<Product>
        {
            new Product("Laptop", "L100", 1099.99, 1),
            new Product("Keyboard", "K240", 30.00, 1),
            new Product("HDMI", "C4", 5.50, 1),
            new Product("Mouse", "M25", 20.00, 1),
            new Product("Screen Cleaner Kit", "S500", 35.99, 1)
        };

        for (int i = 0; i < catalog.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {catalog[i].GetName()} - ${catalog[i].GetTotalCost():0.00}");
            }
            Console.WriteLine("0. Complete Checkout");


        bool addingProducts = true;
        while (addingProducts)
        {
            
            Console.WriteLine("------------------------------------------------");
            
            Console.Write("Select a product number to add to your cart: ");
            

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                    // 
                    // Console.Clear();
                    addingProducts = false;
                break;

                default:
                    if (int.TryParse(choice, out int index) && index > 0 && index <= catalog.Count)
                    {
                        Product selected = catalog[index - 1];
                        userOrder.AddProduct(selected);
                        Console.WriteLine($"ADDED ~ {selected.GetName()} ~ to your cart.");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number. Try again.");
                    }
                    break;
            }
        }


        // Display Receipt 
        Console.Clear();
        Console.WriteLine("===========================================================");
        Console.WriteLine("Store Receipt");
        Console.WriteLine("===========================================================");
        // Display label
        Console.WriteLine();
        Console.WriteLine(userOrder.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(userOrder.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine("------------------------------------");

        //Display totals
        double total = userOrder.CalculateTotal();
        string shippingCost = userAddress.StayInUSA() ? "$5.00" :"$35.00";

        Console.WriteLine();
        Console.WriteLine($"Shipping Fee: {shippingCost}");
        Console.WriteLine($"Grand Total: ${total.ToString("0.00")}");
        Console.WriteLine();

        Console.WriteLine("===========================================================");
        Console.WriteLine("Thank you for ordering! Do Visit Us Again!");
        Console.WriteLine("===========================================================");

    }
}