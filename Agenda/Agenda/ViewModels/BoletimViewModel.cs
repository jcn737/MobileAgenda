using Agenda.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ViewModels
{
    public class BoletimViewModel : BaseViewModel
    {
        private Boletim _boletim;

        public Boletim Boletim
        {
            get { return _boletim; }
            set
            {
                //if (_cliente != value)
                //{
                //    _cliente = value;
                //    OnPropertyChanged(nameof(Cliente));
                //}
                SetProperty(ref _boletim, value);
            }
        }

        public void SetData(Boletim boletim)
        {
            Boletim = boletim;
        }
    }
}
