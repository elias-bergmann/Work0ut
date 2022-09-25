using Work0ut.ViewModel;

namespace Work0ut;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel mainViewModel)
	{
		InitializeComponent();
		BindingContext = mainViewModel;
	}

	private async void OnStartBtnClicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(ExerciceListPage));
    }
}

