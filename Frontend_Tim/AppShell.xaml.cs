namespace Frontend_Tim;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("fächer", typeof(Faecher));
		Routing.RegisterRoute("fächerTwo", typeof(FaecherTwo));
		Routing.RegisterRoute("addSemester", typeof(AddSemester));
	}
}
