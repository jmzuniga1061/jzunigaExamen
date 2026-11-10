namespace ExamenJulianZ.Views;

public partial class loginPage : ContentPage
{
    string[,] usuarios =
    {
        { "estudiante", "moviles" },
        { "suda", "2025" }
    };

    public loginPage()
    {
        InitializeComponent();
    }

    private async void BtnLogin_Clicked(object sender, EventArgs e)
    {
        bool acceso = false;

        string usuario = txtUsuario.Text;
        string clave = txtClave.Text;

        for (int i = 0; i < 2; i++)
        {
            if (usuario == usuarios[i, 0] &&
                clave == usuarios[i, 1])
            {
                acceso = true;
                break;
            }
        }

        if (acceso)
        {
            await Navigation.PushAsync(
                new registroPage(usuario));
        }
        else
        {
            await DisplayAlert(
                "Error",
                "Usuario o contraseña incorrecta",
                "Aceptar");
        }
    }
}