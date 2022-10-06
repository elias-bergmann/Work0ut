using System.Collections.ObjectModel;
using System.Diagnostics;
using Work0ut.Model;
using Work0ut.Service;
using CommunityToolkit;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Work0ut.ViewModel
{
    public partial class ExerciceListViewModel : BaseViewModel
    {
        ExerciceService exerciceService;
        public ExerciceListViewModel(ExerciceService exerciceService) 

        {
            Title = "Exercices List";
            this.exerciceService = exerciceService;
            Task.Run(async () => { await GetExerciesAsync(); });
        }

        public ObservableCollection<Exercice> Exercices { get; } = new();

        [RelayCommand]
        async Task GetExerciesAsync()
        {
            if(IsBusy) return;

            try
            {
                IsBusy = true;
                List<Exercice> exercices = await exerciceService.FetchExercices();

                if (Exercices.Count != 0)
                {
                    Exercices.Clear();
                }

                foreach (Exercice exercice in exercices)
                {
                    Exercices.Add(exercice);
                }
            }
            catch(Exception ex) 
            { 
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error !", "Unable to get exercies", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
