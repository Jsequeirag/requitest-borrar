using System;
using System.Collections.Generic;

namespace requitools_be.Entities;

public partial class InfoEmpleadosAkile
{
    public string Empleado { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? E_Mail { get; set; }

    public string Nomina { get; set; } = null!;

    public string? Grado { get; set; }

    public string Departamento { get; set; } = null!;

    public string Descrip_Departamento { get; set; } = null!;

    public string? Jefatura { get; set; }

    public string? Centro_Costo { get; set; } = null!;

    public string? Descrip_Centro_Costo { get; set; } = null!;

    public string? Puesto { get; set; } = null!;

    public string? Descrip_Puesto { get; set; } = null!;

    public DateTime Fecha_Ingreso { get; set; }

    public DateTime? Fecha_Salida { get; set; }

    public string Estado { get; set; } = null!;

    public string Activo { get; set; } = null!;

    public string? Supervisor { get; set; }

    public string? Nombre_Supervisor { get; set; }

    public string? Email_Supervisor { get; set; }

    public string Area { get; set; } = null!;

    public string Descrip_Area { get; set; } = null!;

    public string? Gerente { get; set; }

    public string? Login { get; set; }
}
