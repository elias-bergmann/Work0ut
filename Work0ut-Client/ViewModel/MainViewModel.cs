using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work0ut.Model;

namespace Work0ut.ViewModel
{
    public partial class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            Title = "Home";
        }


        [RelayCommand]
        async Task GoToWorkoutPage()
        {
            await Shell.Current.GoToAsync(nameof(WorkoutPage));
        }
    }
}
