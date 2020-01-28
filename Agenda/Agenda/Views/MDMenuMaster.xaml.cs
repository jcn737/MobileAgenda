using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agenda.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MDMenuMaster : ContentPage
    {
        public ListView ListView;

        public MDMenuMaster()
        {
            InitializeComponent();

            BindingContext = new MDMenuMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MDMenuMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MDMenuMenuItem> MenuItems { get; set; }

            public MDMenuMasterViewModel()
            {
                MenuItems = new ObservableCollection<MDMenuMenuItem>(new[]
                {
                    new MDMenuMenuItem { Id = 0, Title = "Agenda" },
                    new MDMenuMenuItem { Id = 1, Title = "Calendário" },
                    new MDMenuMenuItem { Id = 2, Title = "Horário Aulas" },
                    new MDMenuMenuItem { Id = 3, Title = "Roteiro Estudos" },
                    new MDMenuMenuItem { Id = 4, Title = "Lista Materiais" },
                    new MDMenuMenuItem { Id = 5, Title = "Boletim" },
                    new MDMenuMenuItem { Id = 6, Title = "Reuniões" },
                    new MDMenuMenuItem { Id = 7, Title = "Comunicado" },
                    new MDMenuMenuItem { Id = 7, Title = "Contato" },
                    new MDMenuMenuItem { Id = 8, Title = "Aluno" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}