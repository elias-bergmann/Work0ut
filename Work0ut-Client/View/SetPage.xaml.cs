using Work0ut.Service;
using Work0ut.ViewModel;
using Work0ut.Model;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Work0ut;

[QueryProperty(nameof(Set), nameof(Set))]
public partial class SetPage : ContentPage
{
    public SetPage(ExerciceService exerciceService)
    {
        InitializeComponent();
        BindingContext = this;
        this.exerciceService = exerciceService;
        Task.Run(async () => { await exerciceService.FetchExercices(); });

    }

    private Set set;
    private Exercice exercice;
    private readonly ExerciceService exerciceService;

    public Set Set
    {
        get => set;
        set
        {
            set = value;
            OnPropertyChanged(nameof(Set));
            Exercice = exerciceService.GetExercieByName(set.ExerciceName);
        }
    }

    public Exercice Exercice
    {
        get => exercice; 
        set
        {
            exercice = value;
            OnPropertyChanged(nameof(Exercice));
        }
    }
}

