using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TeaApp.Api;
using TeaApp.Model;
namespace TeaApp.ViewModel
{
   public class OrderViewModel:BaseClassViewModel
    {
        private ObservableCollection<CarModel> items;
        public ObservableCollection<CarModel> Items
        {
            get { return items; }
            set
            {

                items = value;
            }
        }

        private ObservableCollection<Productmodel> newitem;
        public ObservableCollection<Productmodel> Newitem
        {
            get { return newitem; }
            set { newitem = value; }
        }

        public OrderViewModel()
        {

            Newitem = new ObservableCollection<Productmodel>()
            {
                new Productmodel()
                {
                    Pcity="Chennai",
                    Pname="Xamal",

                },
                new Productmodel()
                {
                    Pname="Mobile",
                    Pcity="Hyderabad",

                },

            };
            Items = new ObservableCollection<CarModel>() {
                new CarModel()
                {
                    CarID = 1,
                    Make = "Tesla Model S",
                    YearOfModel = 2015
                },
                  new CarModel()
                {
                    CarID = 2,
                    Make = "Audi R8",
                    YearOfModel = 2012
                },

            };


            CarApi.GetAllNewsAsync(list =>
            {
                foreach (CarModel item in list)
                {
                    Items.Add(item);
                }
            });
        }


    }
}

