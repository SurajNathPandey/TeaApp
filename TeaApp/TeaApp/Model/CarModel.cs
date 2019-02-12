using System;
using System.Collections.Generic;
using System.Text;
using TeaApp.View;

namespace TeaApp.Model
{
    public class CarModel
    {
        public int CarID { get; set; }
        public string Make { get; set; }
        public int YearOfModel { get; set; }// this is api call property

    }
    public class Productmodel //this is hardcoded property
    {
        public string Pcity { get; set; }
        public string Pname { get; set; }
    }
}
