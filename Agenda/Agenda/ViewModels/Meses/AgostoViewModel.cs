using Agenda.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ViewModels.Meses
{
    public class AgostoViewModel : BaseViewModel
    {
        private Agosto _agosto;

        public Agosto Agosto
        {
            get { return _agosto; }
            set
            {
                //if (_cliente != value)
                //{
                //    _cliente = value;
                //    OnPropertyChanged(nameof(Cliente));
                //}
                SetProperty(ref _agosto, value);
            }
        }

        public void SetData(Agosto agosto)
        {
            Agosto = agosto;
        }
    }
}
