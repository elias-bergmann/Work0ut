using Work0ut.ViewModel;

namespace Work0ut;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel mainViewModel)
	{
		InitializeComponent();
		BindingContext = mainViewModel;
	}
}

