using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataFormXamarin
{
    public class DataFormModel : INotifyPropertyChanged
    {
        private string fruits;
        public string Fruits
        {
            get { return fruits; }
            set
            {
                fruits = value;
                this.RaisePropertyChanged("Fruits");
            }
        }
        private int? qty;
        public int? Qty
        {
            get { return qty; }
            set
            {
                qty = value;
                this.RaisePropertyChanged("Qty");
            }
        }
    
        public DataFormModel()
        {

        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(String Name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(Name));
        }
    }
}
