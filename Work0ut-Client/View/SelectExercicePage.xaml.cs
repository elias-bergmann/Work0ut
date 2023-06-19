using Work0ut.Service;
using Work0ut.ViewModel;

namespace Work0ut;

public partial class SelectMovementPage : ContentPage
{
    public SelectMovementPage(MovementListViewModel exerciceListViewModel)
	{
		InitializeComponent();
		BindingContext = exerciceListViewModel;
	}
}

