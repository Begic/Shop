namespace Shop.DB.Entities;

public class PriceListPosition
{
    public int Id { get; set; }
    public int? PositionNumber { get; set; }
    public decimal? Price  { get; set; }

    public Product Product { get; set; }
    public int? ProductID { get; set; }

    public PriceList PriceList { get; set; }
    public int? PriceListId { get; set; }
}