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
    public partial class BoletimPage : ContentPage
    {
		DataService dataService;
		List<Boletim> boletim = new List<Boletim>();
		public BoletimPage()
        {
            InitializeComponent();
			dataService = new DataService();
			AtualizaDados();
		}
		async void AtualizaDados()
		{
			try
			{
				boletim = await dataService.GetBoletimAsync();
				listaBoletim.ItemsSource = boletim.Select(s => s.ID_Aluno).ToList();
			}
			catch (Exception ex)
			{
				await DisplayAlert("Erro", ex.Source, "OK");
				await DisplayAlert("Erro", ex.Message, "OK");
			}
		}
	}
}