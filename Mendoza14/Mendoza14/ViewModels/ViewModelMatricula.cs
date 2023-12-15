using Mendoza14.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;


namespace Mendoza14.ViewModels
{
    public class ViewModelMatricula : BaseViewModel
    {
        private string color;
        public string Color
        {
            get { return this.color; }
            set { SetValue(ref this.color, value); }
        }


        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Matricula> people;
        public List<Matricula> People
        {
            get { return this.people; }
            set { SetValue(ref this.people, value); }
        }


        public ICommand SearchCommand { get; set; }

        public ViewModelMatricula()
        {

            SearchCommand = new Command(() =>
            {
             MatriculaService service = new MatriculaService();
                People = service.GetByText(Filter);
                if (People.Count > 3)
                    Color = "Red";
                else
                    Color = "Blue";

            });


        }


    
}
}
