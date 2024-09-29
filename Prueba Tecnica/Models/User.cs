using System;
using System.Collections.Generic;

namespace PruebaTecnica.Models;

public partial class User
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Contraseña { get; set; } = null!;
}
