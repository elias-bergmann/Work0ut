using System.Collections.ObjectModel;
using System.Diagnostics;
using Work0ut.Model;
using Work0ut.Service;
using CommunityToolkit;
using CommunityToolkit.Mvvm.Input;

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

        
        public ObservableCollection<Set> Sets { get; } = new();

        [RelayCommand]
        async Task GetWorkoutAsync()
        {
            if(IsBusy) return;

            try
            {
                IsBusy = true;

                Model.Workout workout = await workoutService.GetWorkout();

                if (Sets.Count != 0)
                {
                    Sets.Clear();
                }

                foreach (Set set in workout.Sets)
                {
                    Sets.Add(set);
                }
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
