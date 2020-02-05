using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyFirstPage : ContentPage
    {
        public int Count { get; set; } = 8;

        public MyFirstPage()
        {
            InitializeComponent();
            TestListView.ItemsSource = new string[] { "Hello", "Goodbye" };
            CountView.Text = Count.ToString();
        }

        public void Increment()
        {
            Count++;
        }
    }
}