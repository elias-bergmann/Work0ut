using Work0ut.Service;
using Work0ut.ViewModel;

namespace Work0ut;

public partial class ExerciceListPage : ContentPage
{
    public ExerciceListPage(ExerciceListViewModel exerciceListViewModel)
	{
		InitializeComponent();
		BindingContext = exerciceListViewModel;
	}
}

