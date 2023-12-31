﻿using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Supply
{
    public int Id { get; set; }

    public decimal UnitPrice { get; set; }

    public short Quantity { get; set; }

    public byte Status { get; set; }

    public DateTime RegisterDate { get; set; }

    public DateTime? LastUpdate { get; set; }

    public int IdRawMaterial { get; set; }

    public int IdSupplir { get; set; }

    public string UserId { get; set; } = null!;

    public virtual RawMaterial IdRawMaterialNavigation { get; set; } = null!;

    public virtual Supplier IdSupplirNavigation { get; set; } = null!;
}
