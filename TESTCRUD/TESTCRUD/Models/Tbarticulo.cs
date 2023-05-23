using System;
using System.Collections.Generic;

namespace TESTCRUD.Models;

public partial class Tbarticulo
{
    public int Id { get; set; }

    public string? Descripcion { get; set; }

    public int? Estado { get; set; }

    public int? FkIdProveedor { get; set; }

    public virtual Tbproveedore? FkIdProveedorNavigation { get; set; }
}
