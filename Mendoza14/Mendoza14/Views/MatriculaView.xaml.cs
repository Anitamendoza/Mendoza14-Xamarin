using Mendoza14.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mendoza14.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MatriculaView : ContentPage
    {
        public MatriculaView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModelMatricula();
        }
    }
}