using EntregaFinal2._0_NelOjeda_ListaTareas.MVVM.ViewModels;

namespace EntregaFinal2._0_NelOjeda_ListaTareas.MVVM.View;

public partial class PaginaPrincipal : ContentPage
{
	public PaginaPrincipal()
	{
		InitializeComponent();
		BindingContext = new TareaViewModel();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Application.Current!.MainPage!.Navigation.PushAsync(new PaginaCrear());
    }
}