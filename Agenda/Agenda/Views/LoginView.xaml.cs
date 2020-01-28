using Agenda.Models;
using Agenda.Service;
using Agenda.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agenda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginView : ContentPage
	{
		DataService dataService;
		//List<Usuario> _usuario = new List<Usuario>();
		private Usuario usuario = new Usuario();
		HttpClient client = new HttpClient();

		public LoginView()
		{
			InitializeComponent();
			//BindingContext = new LoginViewModel(Navigation);
			//NavigationPage.SetHasNavigationBar(this, false);
			//dataService = new DataService();
			//AtualizaDados();
		}
		//string token = "";

		private async void BtnLogar_Clicked(object sender, EventArgs e)
		{
			try
			{
				if (txtUsuario.Text != null && txtSenha.Text != null)
				{
					string url = "http://www.agenda.somee.com/api/usuarios/";
					var response = await client.GetStringAsync(url);
					var usuario = JsonConvert.DeserializeObject<List<Usuario>>(response);
					string _nome = txtUsuario.Text;
					string _senha = txtSenha.Text;
					//string nome = usuario.Where(s => s.Nome.Contains(_nome)).ToString();
					//string senha = usuario.Where(s => s.Senha.Contains(_senha)).ToString();

					foreach (var d in usuario)
					{
						if (d.Nome == _nome && d.Senha == _senha)
						{
							await Navigation.PushModalAsync(new MainPage());
						}						
					}
				}
			}

			catch (Exception ex)
			{
				await DisplayAlert("Erro : ", ex.Message, "OK");
			}
		}
	}
}




//var mi = ((MenuItem)sender);
//var aluno = mi.CommandParameter as Aluno;
//if (aluno != null)
//	{
//		await Navigation.PushAsync(new MainPage());
//	}
//else
//{
//	return;
//}


//using(var client = new HttpClient())
//{
//	client.BaseAddress = new Uri("http://agenda.somee.com");

//	var body = String.Format(
//		"grant_type=password&username={0}&password={1}",
//		txtUsuario.Text, txtSenha.Text);

//	StringContent theContent = new
//		StringContent(body, System.Text.Encoding.UTF8,
//		"application/x-www-form-urlencoded");

//	var result = await client.PostAsync("token", theContent);
//	string resultContent = await result.Content.ReadAsStringAsync();

//	if (result.IsSuccessStatusCode)
//	{
//		var o = JsonConvert.DeserializeObject<UsuarioDado>(resultContent);
//		token = o.acess_token; 
//	}
//	else
//	{					
//		throw new Exception("Dificuldades ao fazer Login\n" + result.StatusCode);
//	}
//}