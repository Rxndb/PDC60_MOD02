using System;
using System.Collections.Generic;
using PDC60_MOD02.ViewModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC60_MOD02.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageView1 : ContentPage
    {
        public PageView1()
        {
            InitializeComponent();
            BindingContext = new StudentInformationViewModel();
        }
    }
}