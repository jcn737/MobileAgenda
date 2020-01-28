using Agenda.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ViewModels.Meses
{
    public class SetembroViewModel : BaseViewModel
    {
        private Setembro setembro;

        public Setembro Setembro
        {
            get { return setembro; }
            set
            {
                //if (_cliente != value)
                //{
                //    _cliente = value;
                //    OnPropertyChanged(nameof(Cliente));
                //}
                SetProperty(ref setembro, value);
            }
        }

        public void SetData(Setembro setembro)
        {
            Setembro = setembro;
        }
    }
}
