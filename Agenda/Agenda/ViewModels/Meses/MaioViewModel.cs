using Agenda.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ViewModels.Meses
{
    public class MaioViewModel : BaseViewModel
    {
        private Maio _maio;

        public Maio Maio
        {
            get { return _maio; }
            set
            {
                //if (_cliente != value)
                //{
                //    _cliente = value;
                //    OnPropertyChanged(nameof(Cliente));
                //}
                SetProperty(ref _maio, value);
            }
        }

        public void SetData(Maio maio)
        {
            Maio = maio;
        }
    }
}
