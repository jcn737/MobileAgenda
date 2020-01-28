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
    public partial class HorAulaPage : ContentPage
    {
		DataService dataService;
		List<HoraAula> horaAula = new List<HoraAula>();
		public HorAulaPage()
        {
            InitializeComponent();
			dataService = new DataService();
			AtualizaDados();
		}
		async void AtualizaDados()
		{

			try
			{
				horaAula = await dataService.GetHoraAulaAsync();
				listaHoraAula.ItemsSource = horaAula.Select(s => s).ToList();

			}
			catch (Exception ex)
			{
				await DisplayAlert("Erro", ex.Source, "OK");
				await DisplayAlert("Erro", ex.Message, "OK");
			}
		}
	}
}