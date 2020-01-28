using Agenda.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ViewModels
{
    public class HoraAulaViewModel : BaseViewModel
    {
        private HoraAula _horaAula;

        public HoraAula HoraAula
        {
            get { return _horaAula; }
            set
            {
                //if (_cliente != value)
                //{
                //    _cliente = value;
                //    OnPropertyChanged(nameof(Cliente));
                //}
                SetProperty(ref _horaAula, value);
            }
        }

        public void SetData(HoraAula horaAula)
        {
            HoraAula = horaAula;
        }
    }
}
