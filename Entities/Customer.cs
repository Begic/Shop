﻿using System.ComponentModel.DataAnnotations;

namespace Shop.DB.Entities;

public class Customer
{
    public int Id { get; set; }

    [MaxLength(200)] public string FirstName { get; set; }
    [MaxLength(200)] public string LastName { get; set; }
    public DateTime Birthday { get; set; }
    public decimal Discount  { get; set; }
    [MaxLength(200)] public string Notes { get; set; }

    public CustomerType CustomerType { get; set; }
    public int CustomerTypeId { get; set; }

    public Currency Currency{ get; set; }
    public int CurrencyId { get; set; }

    public DateTime Created { get; set; }
    [MaxLength(200)] public string CreatedBy { get; set; }
    public DateTime? Modified { get; set; }
    [MaxLength(200)] public string? ModifiedBy { get; set; }

    public PriceList PriceList { get; set; }
    public int PriceListId { get; set; }
}