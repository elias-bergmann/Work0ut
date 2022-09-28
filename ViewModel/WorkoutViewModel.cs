using System.Collections.ObjectModel;
using System.Diagnostics;
using Work0ut.Model;
using Work0ut.Service;
using CommunityToolkit;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Work0ut.ViewModel
{

    public partial class WorkoutViewModel : BaseViewModel
    {
        WorkoutService workoutService;
        public WorkoutViewModel(WorkoutService workoutService) 

        {
            this.workoutService = workoutService;
            Task.Run(async () => { await GetWorkoutAsync(); });
        }


        [ObservableProperty]
        Workout workout;


        [RelayCommand]
        async Task GetWorkoutAsync()
        {
            if(IsBusy) return;

            try
            {
                IsBusy = true;

                Workout = await workoutService.GetWorkout();
            }
            catch(Exception ex) 
            { 
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error !", "Unable to get workout", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
