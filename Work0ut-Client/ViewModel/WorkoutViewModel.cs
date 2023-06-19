using System.Collections.ObjectModel;
using System.Diagnostics;
using Work0ut.Model;
using Work0ut.Service;
using CommunityToolkit;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Linq;
using System.Text.Json;

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
        async Task DisplaySet(object parameter)
        {
            Set set = parameter as Set;
            var navigationParameter = new Dictionary<string, object>
            {
                { "Set", set }
            };
            await Shell.Current.GoToAsync(nameof(SetPage),navigationParameter);
        }

        async Task GetWorkoutAsync()
        {
            if(IsBusy) return;

            try
            {
                IsBusy = true;

                Workout = (await workoutService.GetWorkoutList()).FirstOrDefault();
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
