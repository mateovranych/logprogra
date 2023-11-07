using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginProgramacionFinal.Models;

public partial class Profesore
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int Sexo { get; set; }

    public int? Legajo { get; set; }

    public int? Dni { get; set; }

  
}
