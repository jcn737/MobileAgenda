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
    public partial class RotEstudosPage : ContentPage
    {
		DataService dataService;
		List<RoteiroEstudo> roteiroEstudos = new List<RoteiroEstudo>();
		public RotEstudosPage()
        {
            InitializeComponent();
			dataService = new DataService();
			AtualizaDados();
		}
		async void AtualizaDados()
		{

			try
			{
				roteiroEstudos = await dataService.GetRoteiroEstudosAsync();
				listaRoteiroEstudos.ItemsSource = roteiroEstudos.Select(s => s).ToList();

			}
			catch (Exception ex)
			{
				await DisplayAlert("Erro", ex.Source, "OK");
				await DisplayAlert("Erro", ex.Message, "OK");
			}
		}
	}
}