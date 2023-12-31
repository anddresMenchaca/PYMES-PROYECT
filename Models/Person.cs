﻿using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Person
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? SecondLastName { get; set; }

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string Ci { get; set; } = null!;

    public byte Status { get; set; }

    public DateTime RegisterDate { get; set; }

    public DateTime? LastUpdate { get; set; }

    public virtual BusinessManager? BusinessManager { get; set; }

    public virtual Producer? Producer { get; set; }

    public User? User { get; set; }
}
