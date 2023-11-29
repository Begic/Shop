using System.ComponentModel.DataAnnotations;

namespace Shop.DB.Entities;

public class PriceList
{
    public int Id { get; set; }
    [MaxLength(200)] public string Title { get; set; }
    public DateTime ValidFrom { get; set; }
    public DateTime ValidTo { get; set; }

    public Currency Currency { get; set; }
    public int CurrencyId { get; set; }

    public List<PriceListPosition> PriceListPositions { get; set; } = new();
    public List<Customer> Customers { get; set; } = new();
}