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
	public partial class ListaMatPage : ContentPage
	{
		DataService dataService;
		List<ListaMaterial> listaMaterials = new List<ListaMaterial>();
		ListaMaterial list = new ListaMaterial();
		public ListaMatPage()
		{
			InitializeComponent();
			dataService = new DataService();
			AtualizaDados();
		}
		async void AtualizaDados()
		{

			try
			{
				listaMaterials = await dataService.GetListaMaterialAsync();
				listaMat.ItemsSource = listaMaterials.Select(s => s).ToList();

			}
			catch (Exception ex)
			{
				await DisplayAlert("Erro", ex.Message, "OK");
			}
		}

		private void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var listaMaterial = e.SelectedItem as ListaMaterial;
			DisplayAlert("Materiais Primeira Série:", listaMaterial.Primeira, "OK");
			//string list = listaMaterial.ToString();

			//switch (list)
			//{
			//	case "Primeira":
			//		DisplayAlert("Materiais Primeira Série:", listaMaterial.Primeira, "OK");
			//		break;
			//	case "Segunda":
			//		DisplayAlert("Materiais Primeira Série:", listaMaterial.Segunda, "OK");
			//		break;
			//	case "Terceira":
			//		DisplayAlert("Materiais Primeira Série:", listaMaterial.Terceira, "OK");
			//		break;
			//	case "Quarta":
			//		DisplayAlert("Materiais Primeira Série:", listaMaterial.Quarta, "OK");
			//		break;
			//	case "Quinta":
			//		DisplayAlert("Materiais Primeira Série:", listaMaterial.Quinta, "OK");
			//		break;
			//	case "Sexta":
			//		DisplayAlert("Materiais Primeira Série:", listaMaterial.Sexta, "OK");
			//		break;
			//	case "Setima":
			//		DisplayAlert("Materiais Primeira Série:", listaMaterial.Setima, "OK");
			//		break;
			//	case "Oitava":
			//		DisplayAlert("Materiais Primeira Série:", listaMaterial.Oitava, "OK");
			//		break;
			//	case "Nona":
			//		DisplayAlert("Materiais Primeira Série:", listaMaterial.Nona, "OK");
			//		break;
			//	default:
			//		listaMat = null;
			//		break;
			//}

			listaMat = null;
		}
	}
}