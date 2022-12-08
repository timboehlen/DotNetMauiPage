namespace Frontend_Tim;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("fächer");
    }

    private void Button_Clicked2(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("fächerTwo");
    }

    private void AddSemester(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("addSemester");
    }
}

