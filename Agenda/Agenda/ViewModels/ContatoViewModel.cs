using Agenda.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ViewModels
{
	public class ContatoViewModel : BaseViewModel
	{
		private Contato _contato;

		public Contato Contato
		{
			get { return _contato; }
			set
			{
				//if (_cliente != value)
				//{
				//    _cliente = value;
				//    OnPropertyChanged(nameof(Cliente));
				//}
				SetProperty(ref _contato, value);
			}
		}

		public void SetData(Contato contato)
		{
			Contato = contato;
		}
	}

	
}
