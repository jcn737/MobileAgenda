using Agenda.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ViewModels.Meses
{
    public class JulhoViewModel : BaseViewModel
    {
        private Julho _julho;

        public Julho Julho
        {
            get { return _julho; }
            set
            {
                //if (_cliente != value)
                //{
                //    _cliente = value;
                //    OnPropertyChanged(nameof(Cliente));
                //}
                SetProperty(ref _julho, value);
            }
        }

        public void SetData(Julho julho)
        {
            Julho = julho;
        }
    }
}
