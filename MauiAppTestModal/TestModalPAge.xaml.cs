namespace MauiAppTestModal;

public partial class TestModalPAge : ContentPage
{
	public TestModalPAge()
	{
		InitializeComponent();
	}

	private void NavBTN_Clicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync("..");
     
   
    }
}