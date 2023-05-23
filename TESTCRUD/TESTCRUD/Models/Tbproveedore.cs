using System;
using System.Collections.Generic;

namespace TESTCRUD.Models;

public partial class Tbproveedore
{
    public int IdProveedor { get; set; }

    public string? RazonSocial { get; set; }

    public virtual ICollection<Tbarticulo> Tbarticulos { get; } = new List<Tbarticulo>();
}
