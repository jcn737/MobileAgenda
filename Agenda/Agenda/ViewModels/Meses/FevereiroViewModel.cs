using Agenda.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ViewModels.Meses
{
    public class FevereiroViewModel : BaseViewModel
    {
        private Fevereiro _fevereiro;

        public Fevereiro Fevereiro
        {
            get { return _fevereiro; }
            set
            {
                //if (_cliente != value)
                //{
                //    _cliente = value;
                //    OnPropertyChanged(nameof(Cliente));
                //}
                SetProperty(ref _fevereiro, value);
            }
        }

        public void SetData(Fevereiro fevereiro)
        {
            Fevereiro = fevereiro;
        }
    }
}
