using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using MyTicket.Resources;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace MyTicket.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Tickets = new ObservableCollection<Ticket>();
            this.Zaedno = new ObservableCollection<Zaednicka>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<Ticket> Tickets { get; private set; }
        public ObservableCollection<Zaednicka> Zaedno { get; private set; }

               

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            WebClient FixturesClient = new WebClient();
            FixturesClient.DownloadStringCompleted += FixturesClient_DownloadStringCompleted;
            FixturesClient.DownloadStringAsync(new Uri("http://api.pinnaclesports.com/v1/feed?sportid=29&leagueid=2630&clientid=VP593091&apikey=a41afd57-a20d-46bd-84e7-44c7c4a8ab4a&&oddsformat=1&islive=0&currencycode=EUR"));

            this.IsDataLoaded = true;
        }

        private void FixturesClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(rsp));
            XmlReader reader = XmlReader.Create(new StringReader(e.Result));
            object obj = serializer.Deserialize(reader);
            rsp rsp = (rsp)obj;
            reader.Close();
            rspFD fd = rsp.fd;
            rspFDSportsSport sport = (rspFDSportsSport)fd.sports[0];
            rspFDSportsSportLeaguesLeague league = (rspFDSportsSportLeaguesLeague)sport.leagues[0];
            rspFDSportsSportLeaguesLeagueEventsEvent[] nastani = league.events;
            ObservableCollection<Zaednicka> z = new ObservableCollection<Zaednicka>();
            foreach (var nastan in nastani)
            {
                Zaednicka klasa = new Zaednicka();
                klasa.Nastan = nastan;
                NotifyPropertyChanged("Nastan");
                rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriod period = (rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriod)nastan.periods[0];
                rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodMoneyLine odds = (rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodMoneyLine)period.moneyLine[0];
                klasa.Odds = odds;
                NotifyPropertyChanged("Odds");
                z.Add(klasa);
            }
            this.Zaedno = z;
            NotifyPropertyChanged("Zaedno");
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