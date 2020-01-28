using Agenda.Models;
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
    public partial class ReunioesPage : ContentPage
    {
		DataService dataService;
		List<Reuniao> reunioes = new List<Reuniao>();
		public ReunioesPage()
        {
            InitializeComponent();
			dataService = new DataService();
			AtualizaDados();
		}
		async void AtualizaDados()
		{

			try
			{
				reunioes = await dataService.GetReuniaosAsync();
				listaReunioes.ItemsSource = reunioes.Select(s => s).ToList();

			}
			catch (Exception ex)
			{
				await DisplayAlert("Erro", ex.Source, "OK");
				await DisplayAlert("Erro", ex.Message, "OK");
			}
		}

		//var hora = new TimePicker
		//{
		//	Format = "HH:mm",
		//	Time = DateTime.Now.TimeOfDay
		//};

	}
}