using EntregaFinal2._0_NelOjeda_ListaTareas.MVVM.ViewModels;

namespace EntregaFinal2._0_NelOjeda_ListaTareas.MVVM.View;

public partial class PaginaCrear : ContentPage
{
	public PaginaCrear()
	{
		InitializeComponent();
        BindingContext = new TareaViewModel();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Application.Current!.MainPage!.Navigation.PopAsync();
    }
}