public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label: \n";
        Console.WriteLine();
        foreach (Product prod in _products)
        {
            label += $"\n  {prod.GetName()} (ID: {prod.GetProductId()})";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label: {_customer.GetName()}\n {_customer.GetAddress()}:\n {_customer.GetAddress().GetFullAddress()}";
    }
    public double CalculateTotal()
    {
        double total = 0;

        foreach (Product prod in _products)
        {
            total += prod.GetTotalCost();
        }
        if (_customer.StayInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }
}