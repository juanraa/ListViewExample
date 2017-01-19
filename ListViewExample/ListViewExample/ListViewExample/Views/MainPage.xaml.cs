using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ListViewExample.ViewModels;
using System.Collections.ObjectModel;

namespace ListViewExample
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<ElementsViewModel> elements { get; set; }
        public MainPage()
        {
            InitializeComponent();
            elements = new ObservableCollection<ElementsViewModel>();
            elements.Add(new ElementsViewModel
            {
                Image = "icon.png",
                Name = "José",
                Type = "Persona"
            });
            elements.Add(new ElementsViewModel
            {
                Image = "icon.png",
                Name = "Andres",
                Type = "Persona"
            });
            elements.Add(new ElementsViewModel
            {
                Image = "icon.png",
                Name = "Perro",
                Type = "Animal"
            });
            elements.Add(new ElementsViewModel
            {
                Image = "icon.png",
                Name = "Gato",
                Type = "Animal"
            });
            listView.ItemsSource = elements;
        }
    }
}
