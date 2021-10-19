using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Calculator
{
    class Numbers : INotifyPropertyChanged
    {
        private double num1;
        private double num2;
        public double result;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public string Num1
        {
            get
            {
                return num1.ToString();
            }
            set
            {
                double number;
                bool parsed = double.TryParse(value, out number);
                if (parsed)
                {
                    num1 = number;
                }
                OnPropertyChanged("Num1");
                OnPropertyChanged("Result");
            }
        }
        public string Num2
        {
            get
            {
                return num2.ToString();
            }
            set
            {
                double number;
                bool parsed = double.TryParse(value, out number);
                if (parsed)
                {
                    num2 = number;
                }
                OnPropertyChanged("Num2");
                OnPropertyChanged("Result");
            }
        }
        public string Result 
        {
            get
            {
                return result.ToString();
            }
            set
            {
                double number;
                bool parsed = double.TryParse(value, out number);
                result = number;
                OnPropertyChanged("Result");
            }
        }
    }
}
