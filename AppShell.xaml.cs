namespace Workout;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(ExerciceListPage), typeof(ExerciceListPage));
    }
}
