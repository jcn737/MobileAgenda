using Agenda.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ViewModels.Meses
{
    public class AbrilViewModel : BaseViewModel
    {
        private Abril _abril;

        public Abril Abril
        {
            get { return _abril; }
            set
            {
                //if (_cliente != value)
                //{
                //    _cliente = value;
                //    OnPropertyChanged(nameof(Cliente));
                //}
                SetProperty(ref _abril, value);
            }
        }

        public void SetData(Abril abril)
        {
            Abril = abril;
        }
    }
}
