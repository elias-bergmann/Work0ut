using Work0ut.Service;
using Work0ut.ViewModel;
using Work0ut.Model;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Work0ut;

[QueryProperty(nameof(Set), nameof(Set))]
public partial class SetPage : ContentPage
{
    public SetPage(MovementService exerciceService)
    {
        InitializeComponent();
        BindingContext = this;
        this.exerciceService = exerciceService;
        Task.Run(async () => { await exerciceService.GetMovementList(); });

    }

    private Set set;
    private Movement exercice;
    private readonly MovementService exerciceService;

    public Set Set
    {
        get => set;
        set
        {
            set = value;
            OnPropertyChanged(nameof(Set));
            Movement = exerciceService.GetMovementByName(set.Movement.Name);
        }
    }

    public Movement Movement
    {
        get => exercice; 
        set
        {
            exercice = value;
            OnPropertyChanged(nameof(Movement));
        }
    }
}

