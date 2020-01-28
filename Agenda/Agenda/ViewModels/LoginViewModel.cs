using Agenda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Agenda.AlunoDAL;

namespace Agenda.ViewModels
{
	public class LoginViewModel
	{
		private string _usuario;		
		public string Usuario
		{
			get { return _usuario; }
			set
			{
				if (_usuario != value)
				{
					_usuario = value;
					LoginCommand.ChangeCanExecute();
				}
			}
		}

		private string _senha;
		public string Senha
		{
			get { return _senha; }
			set
			{
				if (_senha != value)
				{
					_senha = value;
					LoginCommand.ChangeCanExecute();
				}
			}
		}

		//public ICommand IncluirUsuario
		//{
		//    get
		//    {
		//        var clienteDAL = new ClienteDAL();
		//        return new Command(() =>
		//        {
		//            Usuario cli = new Usuario();
		//            cli.Nome = "mac";
		//            cli.Senha = "numsey";
		//            clienteDAL.Add(cli);
		//            App.Current.MainPage.DisplayAlert("Novo Usuario", "Inclusão realizada com sucesso", "OK");
		//        });
		//    }
		//}

		public Command LoginCommand { get; }
		private INavigation _navigation;

		public LoginViewModel(INavigation navigation)
		{
			LoginCommand = new Command<string>(VerificarLogin);
			_navigation = navigation;
		}

		private void VerificarLogin(string senha)
		{
			Usuario usuario = new Usuario();
			//var alunoDAL = new AlunoDAL();
			//usuario = alunoDAL.GetUsuarioLogin(senha);
			//if (usuario != null)
			//{
			//	_navigation.PushAsync(new MainPage());
			//}
			//else
			//{
			//	App.Current.MainPage.DisplayAlert("Não foi possível logar", "Dados inválidos...", "Ok");
			//}
		}
	}
}
