using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Messaging;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Agenda.Models;
using Agenda.Service;
using Agenda.ViewModels;
using Newtonsoft.Json;
using System.Net.Http;

namespace Agenda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContatoPage : ContentPage
	{
		private ContatoViewModel ViewModel { get; }
		DataService dataService;
		List<Contato> _contato = new List<Contato>();
		private Contato contato;
		HttpClient client = new HttpClient();

		string telefoneDiretoria;
		string telefoneCoordenadoria;
		string telefoneSecretaria;
		string telefoneFinanceiro;
		string telefoneProfessora;
		string emailDiretoria;
		string emailCoordenadoria;
		string emailSecretaria;
		string emailFinanceiro;
		string emailProfessora;

		public ContatoPage()
		{
			InitializeComponent();
			dataService = new DataService();			
			AtualizaDados();
		}

		public ContatoPage(Contato con)
		{
			InitializeComponent();
			dataService = new DataService();
			AtualizaDados();
			contato = con;
			BindingContext = ViewModel = new ContatoViewModel();
			ViewModel.SetData(con);
		}

		async void AtualizaDados()
		{

			try
			{
				string url = "http://www.agenda.somee.com/api/contato/";
				var response = await client.GetStringAsync(url);
				var usuario = JsonConvert.DeserializeObject<List<Contato>>(response);

				foreach (var con in usuario)
				{
					try
					{
						telefoneDiretoria = con.Telefone_Diretoria;
						telefoneCoordenadoria = con.Telefone_Coordenadoria;
						telefoneSecretaria = con.Telefone_Secretaria;
						telefoneFinanceiro = con.Telefone_Financeiro;
						telefoneProfessora = con.Telefone_Professora;
						emailDiretoria = con.Email_Diretoria;
						emailCoordenadoria = con.Email_Coordenadoria;
						emailSecretaria = con.Email_Secretaria;
						emailFinanceiro = con.Email_Financeiro;
						emailProfessora = con.Email_Professora;
					}
					catch (Exception ex)
					{
						await DisplayAlert("Erro : ", ex.Message, "OK");
					}
				}
				
			}
			catch (Exception ex)
			{
				await DisplayAlert("Erro", ex.Message, "OK");
			}
		}
		private void OnTapTelefoneDiretoria(object sender, EventArgs e)
		{
			var PhoneCallTask = CrossMessaging.Current.PhoneDialer;

			if (PhoneCallTask.CanMakePhoneCall)
			{
				//PhoneCallTask.MakePhoneCall("19 38847284");
				PhoneCallTask.MakePhoneCall(telefoneDiretoria);
			}
			else
			{
				DisplayAlert("Erro", "Não foi possível fazer chamadas telefonicas", "OK");
			}
		}
		private void OnTapTelefoneCoordenadoria(object sender, EventArgs e)
		{
			var PhoneCallTask = CrossMessaging.Current.PhoneDialer;

			if (PhoneCallTask.CanMakePhoneCall)
			{
				//PhoneCallTask.MakePhoneCall(contato.TelefoneCoordenadoria);
				PhoneCallTask.MakePhoneCall("19 38847288");
			}
			else
			{
				DisplayAlert("Erro", "Não foi possível fazer chamadas telefonicas", "OK");
			}
		}
		private void OnTapTelefoneSecretaria(object sender, EventArgs e)
		{
			var PhoneCallTask = CrossMessaging.Current.PhoneDialer;

			if (PhoneCallTask.CanMakePhoneCall)
			{
				//PhoneCallTask.MakePhoneCall(contato.TelefoneSecretaria);
				PhoneCallTask.MakePhoneCall("19 38847542");
			}
			else
			{
				DisplayAlert("Erro", "Não foi possível fazer chamadas telefonicas", "OK");
			}
		}
		private void OnTapTelefoneFinanceiro(object sender, EventArgs e)
		{
			var PhoneCallTask = CrossMessaging.Current.PhoneDialer;

			if (PhoneCallTask.CanMakePhoneCall)
			{
				//PhoneCallTask.MakePhoneCall(contato.TelefoneFinanceiro);
				PhoneCallTask.MakePhoneCall("19 38847296");
			}
			else
			{
				DisplayAlert("Erro", "Não foi possível fazer chamadas telefonicas", "OK");
			}
		}
		private void OnTapTelefoneProfessora(object sender, EventArgs e)
		{
			var PhoneCallTask = CrossMessaging.Current.PhoneDialer;

			if (PhoneCallTask.CanMakePhoneCall)
			{
				//PhoneCallTask.MakePhoneCall(contato.TelefoneProfessora);
				PhoneCallTask.MakePhoneCall("19 38846544");
			}
			else
			{
				DisplayAlert("Erro", "Não foi possível fazer chamadas telefonicas", "OK");
			}
		}

		private void OnTapEmailDiretoria(object sender, EventArgs e)
		{
			var EmailTask = CrossMessaging.Current.EmailMessenger;

			string assunto = "Exemplo de envio de email";
			string texto = "Envio de email usando o plugin XAM.Plugins.Messaging";

			if (EmailTask.CanSendEmail)
			{
				//EmailTask.SendEmail(contato.EmailDiretoria, assunto, texto);
				EmailTask.SendEmail("diretoria@agendaescola.com.br", assunto, texto);
			}
			else
			{
				DisplayAlert("Erro", "Não foi possível enviar o email", "OK");
			}
		}
		private void OnTapEmailCoordenadoria(object sender, EventArgs e)
		{
			var EmailTask = CrossMessaging.Current.EmailMessenger;

			string assunto = "Exemplo de envio de email";
			string texto = "Envio de email usando o plugin XAM.Plugins.Messaging";

			if (EmailTask.CanSendEmail)
			{
				//EmailTask.SendEmail(contato.EmailCoordenadoria, assunto, texto);
				EmailTask.SendEmail("coordenadoria@agendaescola.com.br", assunto, texto);
			}
			else
			{
				DisplayAlert("Erro", "Não foi possível enviar o email", "OK");
			}
		}
		private void OnTapEmailSecretaria(object sender, EventArgs e)
		{
			var EmailTask = CrossMessaging.Current.EmailMessenger;

			string assunto = "Exemplo de envio de email";
			string texto = "Envio de email usando o plugin XAM.Plugins.Messaging";

			if (EmailTask.CanSendEmail)
			{
				//EmailTask.SendEmail(contato.EmailSecretaria, assunto, texto);
				EmailTask.SendEmail("secretaria@agendaescola.com.br", assunto, texto);
			}
			else
			{
				DisplayAlert("Erro", "Não foi possível enviar o email", "OK");
			}
		}
		private void OnTapEmailFinanceiro(object sender, EventArgs e)
		{
			var EmailTask = CrossMessaging.Current.EmailMessenger;

			string assunto = "Exemplo de envio de email";
			string texto = "Envio de email usando o plugin XAM.Plugins.Messaging";

			if (EmailTask.CanSendEmail)
			{
				//EmailTask.SendEmail(contato.EmailFinanceiro, assunto, texto);
				EmailTask.SendEmail("financeiro@agendaescola.com.br", assunto, texto);
			}
			else
			{
				DisplayAlert("Erro", "Não foi possível enviar o email", "OK");
			}
		}
		private void OnTapEmailProfessora(object sender, EventArgs e)
		{
			var EmailTask = CrossMessaging.Current.EmailMessenger;

			string assunto = "Exemplo de envio de email";
			string texto = "Envio de email usando o plugin XAM.Plugins.Messaging";

			if (EmailTask.CanSendEmail)
			{
				//EmailTask.SendEmail(contato.EmailProfessora, assunto, texto);
				EmailTask.SendEmail("professora@agendaescola.com.br", assunto, texto);
			}
			else
			{
				DisplayAlert("Erro", "Não foi possível enviar o email", "OK");
			}
		}
	}
}