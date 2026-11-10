using ExamenJulianZ.Models;

namespace ExamenJulianZ.Views;

public partial class registroPage : ContentPage
{
    string usuarioActual;
    public registroPage(string usuario)
    {
        InitializeComponent();

        lblUsuario.Text = $"Usuario conectado: {usuario}";
    }
    private void BtnCalcular_Clicked(object sender, EventArgs e)
    {
        double costoCurso = 1500;

        double montoInicial =
            Convert.ToDouble(txtMontoInicial.Text);

        double saldo = costoCurso - montoInicial;

        double cuota = saldo / 4;

        double interes = costoCurso * 0.04;

        double pagoMensual = cuota + interes;

        txtPagoMensual.Text =
            pagoMensual.ToString("F2");
    }
    private async void BtnResumen_Clicked(object sender, EventArgs e)

    {

        Estudiante estudiante = new Estudiante()
        {
            Usuario = usuarioActual,
            Nombre = txtNombre.Text,
            Apellido = txtApellido.Text,
            Edad = Convert.ToInt32(txtEdad.Text),
            Fecha = dpFecha.Date ?? DateTime.Now,
            Pais = pkPais.SelectedItem.ToString(),
            Ciudad = pkCiudad.SelectedItem.ToString(),
            MontoInicial = Convert.ToDouble(txtMontoInicial.Text),
            PagoMensual = Convert.ToDouble(txtPagoMensual.Text)
        };

        await Navigation.PushAsync(
            new resumenPage(estudiante));
    }
}