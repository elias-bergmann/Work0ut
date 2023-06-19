using System.Collections.ObjectModel;
using System.Diagnostics;
using Work0ut.Model;
using Work0ut.Service;
using CommunityToolkit;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Work0ut.ViewModel
{
    public partial class MovementListViewModel : BaseViewModel
    {
        MovementService movementService;
        public MovementListViewModel(MovementService movementService) 

        {
            Title = "Movements List";
            this.movementService = movementService;
            Task.Run(async () => { await GetExercicesAsync(); });
        }

        public ObservableCollection<Movement> Movements { get; } = new();

        [RelayCommand]
        async Task GetExercicesAsync()
        {
            if(IsBusy) return;

            try
            {
                IsBusy = true;
                List<Movement> exercices = await movementService.GetMovementList();

                if (Movements.Count != 0)
                {
                    Movements.Clear();
                }

                foreach (Movement exercice in exercices)
                {
                    Movements.Add(exercice);
                }
            }
            catch(Exception ex) 
            { 
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error !", "Unable to get Exercices", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
