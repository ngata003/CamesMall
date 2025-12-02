using CamesMall.Models;
using CamesMall.PageModels;

namespace CamesMall.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}