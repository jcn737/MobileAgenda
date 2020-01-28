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
	public partial class FevereiroPage : ContentPage
	{
		DataService dataService;
		List<Fevereiro> fevereiro;
		public FevereiroPage()
		{
			InitializeComponent();
			dataService = new DataService();
			AtualizaDados();
		}

		async void AtualizaDados()
		{

			try
			{
				fevereiro = await dataService.GetFevereiroAsync();
				listaFevereiro.ItemsSource = fevereiro.ToList();
			}
			catch (Exception ex)
			{
				await DisplayAlert("Erro", ex.Source, "OK");
				await DisplayAlert("Erro", ex.Message, "OK");
			}
		}
	}
}