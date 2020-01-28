using Agenda.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ViewModels.Meses
{
    public class MarcoViewModel : BaseViewModel
    {
        private Marco _marco;

        public Marco Marco
        {
            get { return _marco; }
            set
            {
                //if (_cliente != value)
                //{
                //    _cliente = value;
                //    OnPropertyChanged(nameof(Cliente));
                //}
                SetProperty(ref _marco, value);
            }
        }

        public void SetData(Marco marco)
        {
            Marco = marco;
        }
    }
}
