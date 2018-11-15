using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Test_Project.Models;

namespace Xamarin_Test_Project
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPracticePage : ContentPage
    {
        private ObservableCollection<Contact> _contacts;
        public ListPracticePage()
        {
            InitializeComponent();

            //_contacts = new ObservableCollection<Contact>{

            //         new Contact { Name = "Mosh", ImageUrl = "https://www.fillmurray.com/100/100"},


            //        new Contact { Name = "Josh", ImageUrl = "https://placekitten.com/100/100", Status = "Hey lets talk!"}
            //};

            ListView.ItemsSource = GetContacts();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ListView.SelectedItem = null;
            //var contact = e.SelectedItem as Contact;
            //DisplayAlert("Selected", contact.Name, "OK");
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "OK");
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            DisplayAlert("Call", contact.Name, "OK");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);

        }

        IEnumerable<Contact> GetContacts(string searchText = null)
        {
            var contacts = new List<Contact>{

                     new Contact { Name = "Mosh", ImageUrl = "https://www.fillmurray.com/100/100"},


                    new Contact { Name = "Josh", ImageUrl = "https://placekitten.com/100/100", Status = "Hey lets talk!"}
            };

            if (String.IsNullOrWhiteSpace(searchText))
            {
                return contacts;
            }

            return contacts.Where(c => c.Name.StartsWith(searchText));
        }
            
        private void ListView_Refreshing(object sender, EventArgs e)
        {
            ListView.ItemsSource = GetContacts();

            ListView.IsRefreshing = false;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListView.ItemsSource = GetContacts(e.NewTextValue);
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {

        }
    }
}