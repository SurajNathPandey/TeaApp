using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using TeaApp.View;
using System.Collections.ObjectModel;

namespace TeaApp.ViewModel
{
    public class MmenuViewModelcs:BaseClassViewModel
    {
        //public ICommand Aboutimage { get; set; }
        public MmenuViewModelcs()
        {
            Ordertea = new Command(ordertea);
            async void ordertea()
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new OrderView());

            }
             
            Detailstea = new Command(detailstea);
            async void detailstea()
            {

                await App.Current.MainPage.Navigation.PushModalAsync(new CheakamountView());
            }
            Bout = new Command(bout);
            async void bout()
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new CheakorderView());
            }
            Mybout = new Command(mybout);
            async void mybout()
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new CheaklocationView());
            }


        }
        public ICommand Bout { get; set; }
        public ICommand Mybout { get; set; }
        public ICommand Ordertea { get; set; }
        public ICommand Detailstea { get; set; }


    }
}

