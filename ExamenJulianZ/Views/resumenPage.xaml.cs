using ExamenJulianZ.Models;

namespace ExamenJulianZ.Views;

public partial class resumenPage : ContentPage
{
    public resumenPage(Estudiante estudiante)
    {
        InitializeComponent();

        lblUsuario.Text = estudiante.Usuario;
        lblNombre.Text = estudiante.Nombre;
        lblApellido.Text = estudiante.Apellido;
        lblEdad.Text = estudiante.Edad.ToString();
        lblFecha.Text = estudiante.Fecha.ToShortDateString();
        lblPais.Text = estudiante.Pais;
        lblCiudad.Text = estudiante.Ciudad;

        lblMontoInicial.Text =
            estudiante.MontoInicial.ToString("F2");

        lblPagoMensual.Text =
            estudiante.PagoMensual.ToString("F2");

        double pagoTotal =
            estudiante.MontoInicial +
            (estudiante.PagoMensual * 4);

        lblPagoTotal.Text =
            pagoTotal.ToString("F2");
    }
}