using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTicket.ViewModels
{
    public class Zaednicka : INotifyPropertyChanged
    {
        private ViewModels.rspFDSportsSportLeaguesLeagueEventsEvent _Nastan;
        private ViewModels.rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodMoneyLine _Odds;

        

        public ViewModels.rspFDSportsSportLeaguesLeagueEventsEvent Nastan
        {
            get { return _Nastan; }
            set
            {
                if (value != _Nastan)
                {
                    _Nastan = value;
                    NotifyPropertyChanged("Nastan");
                }
            }
        }

        public ViewModels.rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodMoneyLine Odds
        {
            get { return _Odds; }
            set
            {
                if (value != _Odds)
                {
                    _Odds = value;
                    NotifyPropertyChanged("Odds");
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
