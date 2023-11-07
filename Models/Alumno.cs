using System;
using System.Collections.Generic;

namespace LoginProgramacionFinal.Models;

public partial class Alumno
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int? Dni { get; set; }

    public string? Calle { get; set; }

    public int? Nro { get; set; }

  
}
