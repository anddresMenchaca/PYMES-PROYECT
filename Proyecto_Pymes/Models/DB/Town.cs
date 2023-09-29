﻿using System;
using System.Collections.Generic;

namespace Proyecto_Pymes.Models.DB;

public partial class Town
{
    public byte Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<TownShip> TownShips { get; set; } = new List<TownShip>();
}
