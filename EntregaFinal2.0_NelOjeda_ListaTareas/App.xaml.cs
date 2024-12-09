using EntregaFinal2._0_NelOjeda_ListaTareas.MVVM.View;

namespace EntregaFinal2._0_NelOjeda_ListaTareas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PaginaPrincipal());
        }

        
    }
}
