namespace ExamenJulianZ.Models;

public class Estudiante
{
    public string Usuario { get; set; } = "";
    public string Nombre { get; set; } = "";
    public string Apellido { get; set; } = "";
    public int Edad { get; set; }
    public DateTime Fecha { get; set; }
    public string Pais { get; set; } = "";
    public string Ciudad { get; set; } = "";
    public double MontoInicial { get; set; }
    public double PagoMensual { get; set; }
}