using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Runtime.Serialization;

namespace MyTicket.ViewModels
{
    
    public class Ticket : INotifyPropertyChanged
    {
        private string _tip;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        
        public string Tip
        {
            get
            {
                return _tip;
            }
            set
            {
                if (value != _tip)
                {
                    _tip = value;
                    NotifyPropertyChanged("Tip");
                }
            }
        }

        private string _par;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        
        public string Par
        {
            get
            {
                return _par;
            }
            set
            {
                if (value != _par)
                {
                    _par = value;
                    NotifyPropertyChanged("Par");
                }
            }
        }

        private double _koeficient;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        
        public double Koeficient
        {
            get
            {
                return _koeficient;
            }
            set
            {
                if (value != _koeficient)
                {
                    _koeficient = value;
                    NotifyPropertyChanged("Koeficient");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}