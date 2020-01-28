using Agenda.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ViewModels
{
    public class ReuniaoViewModel : BaseViewModel
    {
        private Reuniao _reuniao;

        public Reuniao Reuniao
        {
            get { return _reuniao; }
            set
            {
                //if (_cliente != value)
                //{
                //    _cliente = value;
                //    OnPropertyChanged(nameof(Cliente));
                //}
                SetProperty(ref _reuniao, value);
            }
        }

        public void SetData(Reuniao reuniao)
        {
            Reuniao = reuniao;
        }
    }
}
