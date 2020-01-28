using Agenda.MenuItems;
using Agenda.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Agenda
{
    public partial class MainPage : MasterDetailPage
    {

        public List<MasterPageItem> menuList { get; set; }

        public MainPage()
        {

            InitializeComponent();

            menuList = new List<MasterPageItem>();

            // Creating our pages for menu navigation
            // Here you can define title for item, 
            // icon on the left side, and page that you want to open after selection
            var page1 = new MasterPageItem() { Title = "Agenda", Icon = "ic_inbox.png", TargetType = typeof(AgendaPage) };
            var page2 = new MasterPageItem() { Title = "Calendário", Icon = "ic_event.png", TargetType = typeof(CalendarioPage) };
            var page3 = new MasterPageItem() { Title = "Horário Aulas", Icon = "ic_schedule.png", TargetType = typeof(HorAulaPage) };
            var page4 = new MasterPageItem() { Title = "Roteiro Estudos", Icon = "ic_import_contacts.png", TargetType = typeof(RotEstudosPage) };
            var page5 = new MasterPageItem() { Title = "Lista Materiais", Icon = "ic_view_list.png", TargetType = typeof(ListaMatPage) };
            var page6 = new MasterPageItem() { Title = "Boletim", Icon = "ic_list.png", TargetType = typeof(BoletimPage) };
            var page7 = new MasterPageItem() { Title = "Reuniões", Icon = "ic_group.png", TargetType = typeof(ReunioesPage) };
            var page8 = new MasterPageItem() { Title = "Comunicado", Icon = "ic_message.png", TargetType = typeof(ComunicadoPage) };
			var page9 = new MasterPageItem() { Title = "Contato", Icon = "ic_email_black.png", TargetType = typeof(ContatoPage) };
            var page10 = new MasterPageItem() { Title = "Aluno", Icon = "ic_face_black_36dp.png", TargetType = typeof(AlunoTabbedPage) };
            // Adding menu items to menuList
            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
            menuList.Add(page4);
            menuList.Add(page5);
            menuList.Add(page6);
            menuList.Add(page7);
            menuList.Add(page8);
			menuList.Add(page9);
            menuList.Add(page10);

            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;

            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Inicial)));
            
        }

        // Event for Menu Item selection, here we are going to handle navigation based
        // on user selection in menu ListView
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));            
            IsPresented = false;
        }
    }
}
