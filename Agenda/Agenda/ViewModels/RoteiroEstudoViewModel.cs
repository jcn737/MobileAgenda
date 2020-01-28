using Agenda.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ViewModels
{
    public class RoteiroEstudoViewModel : BaseViewModel
    {
        private RoteiroEstudo _roteiroEstudo;

        public RoteiroEstudo RoteiroEstudo
        {
            get { return _roteiroEstudo; }
            set
            {
                //if (_cliente != value)
                //{
                //    _cliente = value;
                //    OnPropertyChanged(nameof(Cliente));
                //}
                SetProperty(ref _roteiroEstudo, value);
            }
        }

        public void SetData(RoteiroEstudo roteiroEstudo)
        {
            RoteiroEstudo = roteiroEstudo;
        }
    }
}
