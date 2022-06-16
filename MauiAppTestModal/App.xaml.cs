namespace MauiAppTestModal;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
        Routing.RegisterRoute("testModalPAge", typeof(TestModalPAge));
    }
}
