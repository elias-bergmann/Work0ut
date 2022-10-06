using Work0ut.Service;
using Work0ut.ViewModel;

namespace Work0ut;

public partial class WorkoutPage : ContentPage
{
    public WorkoutPage(WorkoutViewModel workoutViewModel)
	{
		InitializeComponent();
		BindingContext = workoutViewModel;
	}
}

