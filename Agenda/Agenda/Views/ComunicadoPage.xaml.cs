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
    public partial class ComunicadoPage : ContentPage
    {
		DataService dataService;
		List<Comunicado> comunicados = new List<Comunicado>();
		public ComunicadoPage()
        {
            InitializeComponent();
			dataService = new DataService();
			AtualizaDados();
		}
		async void AtualizaDados()
		{

			try
			{
				comunicados = await dataService.GetComunicadoAsync();
				listaComunicados.ItemsSource = comunicados.Select(s => s.ID_Aluno).ToList();
			}
			catch (Exception ex)
			{
				await DisplayAlert("Erro", ex.Source, "OK");
				await DisplayAlert("Erro", ex.Message, "OK");
			}
		}


		//private void BtnEmail_Clicked(object sender, EventArgs e)
		//{
		//	string foneCliente = null;
		//	string nomeCliente = null;

		//	if (string.IsNullOrEmpty(txtNome.Text) && string.IsNullOrEmpty(txtTelefone.Text))
		//	{
		//		DisplayAlert("Cliente", "Informe o nome do cliente", "OK");
		//	}
		//	else
		//	{
		//		foneCliente = txtTelefone.Text;
		//		nomeCliente = txtNome.Text;
		//	}
		//	try
		//	{
		//		var SmsTask = CrossMessaging.Current.SmsMessenger;

		//		if (SmsTask.CanSendSms)
		//			SmsTask.SendSms(foneCliente, titulo + " " + nomeCliente + "Operação realizada com sucesso");
		//		else
		//			DisplayAlert("Atenção", "Não foi possível enviar mensagem ao cliente", "OK");

		//	}
		//	catch (Exception ex)
		//	{
		//		DisplayAlert("Erro: ", ex.Message, "OK");
		//	}
		//}
	}
}