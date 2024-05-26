using System;
using System.Collections.Generic;

namespace StoreDbOnboarding.Models;

public partial class Store
{
    public int StoreId { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
