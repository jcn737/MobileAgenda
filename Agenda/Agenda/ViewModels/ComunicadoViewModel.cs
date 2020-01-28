using Agenda.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ViewModels
{
    public class ComunicadoViewModel : BaseViewModel
    {
        private Comunicado _comunicado;

        public Comunicado Comunicado
        {
            get { return _comunicado; }
            set
            {
                //if (_cliente != value)
                //{
                //    _cliente = value;
                //    OnPropertyChanged(nameof(Cliente));
                //}
                SetProperty(ref _comunicado, value);
            }
        }

        public void SetData(Comunicado comunicado)
        {
            Comunicado = comunicado;
        }
    }
}
