using System.ComponentModel.DataAnnotations;

namespace Shop.DB.Entities;

public class CustomerState
{
    public int Id { get; set; }
    [MaxLength(200)] public string Title { get; set; }
    [MaxLength(200)] public string Notes { get; set; }

    public List<Customer> Customers { get; set; } = new();
}