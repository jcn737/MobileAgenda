using Agenda.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ViewModels
{
    public class ListaMaterialViewModel : BaseViewModel
    {
        private ListaMaterial _listaMaterial;

        public ListaMaterial ListaMaterial
        {
            get { return _listaMaterial; }
            set
            {
                //if (_cliente != value)
                //{
                //    _cliente = value;
                //    OnPropertyChanged(nameof(Cliente));
                //}
                SetProperty(ref _listaMaterial, value);
            }
        }

        public void SetData(ListaMaterial listaMaterial)
        {
            ListaMaterial = listaMaterial;
        }
    }
}
