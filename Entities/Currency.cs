using System.ComponentModel.DataAnnotations;

namespace Shop.DB.Entities;

public class Currency
{
    public int Id { get; set; }

    [MaxLength(200)] public string Title { get; set; }
    [MaxLength(200)] public string Symbol { get; set; }

    public List<PriceList> PriceLists { get; set; } = new();
    public List<Customer> Customers { get; set; } = new();
}