using System;
using System.Collections.Generic;

namespace CloudComp.Models;

public partial class    Table
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public string? NameNoIndex { get; set; }

    public string? NameIndexed { get; set; }
}