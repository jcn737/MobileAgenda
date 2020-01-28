using Agenda.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ViewModels.Meses
{
    public class NovembroViewModel : BaseViewModel
    {
        private Novembro _novembro;

        public Novembro Novembro
        {
            get { return _novembro; }
            set
            {
                //if (_cliente != value)
                //{
                //    _cliente = value;
                //    OnPropertyChanged(nameof(Cliente));
                //}
                SetProperty(ref _novembro, value);
            }
        }

        public void SetData(Novembro novembro)
        {
            Novembro = novembro;
        }
    }
}
