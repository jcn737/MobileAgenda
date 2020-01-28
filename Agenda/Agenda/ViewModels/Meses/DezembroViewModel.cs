using Agenda.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ViewModels.Meses
{
    public class DezembroViewModel : BaseViewModel
    {
        private Dezembro _dezembro;

        public Dezembro Dezembro
        {
            get { return _dezembro; }
            set
            {
                //if (_cliente != value)
                //{
                //    _cliente = value;
                //    OnPropertyChanged(nameof(Cliente));
                //}
                SetProperty(ref _dezembro, value);
            }
        }

        public void SetData(Dezembro dezembro)
        {
            Dezembro = dezembro;
        }
    }
}
