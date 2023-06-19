using Work0ut.Service;
using Work0ut.ViewModel;

namespace Work0ut;

public partial class CreateWorkoutPage : ContentPage
{
    public CreateWorkoutPage(WorkoutViewModel workoutViewModel)
	{
		InitializeComponent();
		BindingContext = workoutViewModel;
	}
}

