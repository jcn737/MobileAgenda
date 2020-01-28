using Agenda.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ViewModels.Meses
{
    public class JaneiroViewModel : BaseViewModel
    {
        private Janeiro _janeiro;

        public Janeiro Janeiro
        {
            get { return _janeiro; }
            set
            {
                //if (_cliente != value)
                //{
                //    _cliente = value;
                //    OnPropertyChanged(nameof(Cliente));
                //}
                SetProperty(ref _janeiro, value);
            }
        }

        public void SetData(Janeiro janeiro)
        {
            Janeiro = janeiro;
        }
    }
}
