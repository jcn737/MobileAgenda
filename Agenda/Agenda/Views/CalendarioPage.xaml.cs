using Agenda.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agenda.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarioPage : ContentPage
    {
		//DataService dataService;
		//List<> boletim = new List<Boletim>();
		public CalendarioPage()
        {
            InitializeComponent();
			//DataService = new DataService();
			//AtualizaDados();
		}
		//async void AtualizaDados()
		//{

		//	try
		//	{
		//		boletim = await dataService.get();
		//		listaBoletim.ItemsSource = boletim.Select(s => s).ToList();

		//	}
		//	catch (Exception ex)
		//	{
		//		await DisplayAlert("Erro", ex.Source, "OK");
		//		await DisplayAlert("Erro", ex.Message, "OK");
		//	}
		//}
	}
}