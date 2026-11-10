using ExamenJulianZ.Views;

namespace ExamenJulianZ;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new loginPage());
    }
}