using Agenda.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ViewModels.Meses
{
    public class OutubroViewModel : BaseViewModel
    {
        private Outubro _outubro;

        public Outubro Outubro
        {
            get { return _outubro; }
            set
            {
                //if (_cliente != value)
                //{
                //    _cliente = value;
                //    OnPropertyChanged(nameof(Cliente));
                //}
                SetProperty(ref _outubro, value);
            }
        }

        public void SetData(Outubro outubro)
        {
            Outubro = outubro;
        }
    }
}
