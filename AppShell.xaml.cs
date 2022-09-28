namespace Work0ut;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(ExerciceListPage), typeof(ExerciceListPage));
        Routing.RegisterRoute(nameof(WorkoutPage), typeof(WorkoutPage));
    }
}
