using Agenda.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ViewModels.Meses
{
    public class JunhoViewModel : BaseViewModel
    {
        private Junho _junho;

        public Junho Junho
        {
            get { return _junho; }
            set
            {
                //if (_cliente != value)
                //{
                //    _cliente = value;
                //    OnPropertyChanged(nameof(Cliente));
                //}
                SetProperty(ref _junho, value);
            }
        }

        public void SetData(Junho junho)
        {
            Junho = junho;
        }
    }
}
