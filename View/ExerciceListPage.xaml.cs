using Workout.Service;
using Workout.ViewModel;

namespace Workout;

public partial class ExerciceListPage : ContentPage
{
    public ExerciceListPage(ExerciceListViewModel exerciceListViewModel)
	{
		InitializeComponent();
		BindingContext = exerciceListViewModel;
	}
}

