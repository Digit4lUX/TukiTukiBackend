namespace TukiTukiBackend.Models;

public class Product
{
    public int id { get; set; }
    public string title { get; set; }
    public string price { get; set; }
    public string details { get; set; }

    public Product(string title, string price, string details)
    {
        this.title = title;
        this.price = price;
        this.details = details;
    }
}