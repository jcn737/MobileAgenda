using Agenda.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ViewModels
{
    public class AlunoViewModel : BaseViewModel
    {
        private Aluno _aluno;

        public Aluno Aluno
        {
            get { return _aluno; }
            set
            {
                //if (_cliente != value)
                //{
                //    _cliente = value;
                //    OnPropertyChanged(nameof(Cliente));
                //}
                SetProperty(ref _aluno, value);
            }
        }

        public void SetData(Aluno aluno)
        {
            Aluno = aluno;
        }
    }
}
