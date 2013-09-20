
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;



namespace MyTicket.ViewModels
{
    /// <remarks/>

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class rsp : INotifyPropertyChanged
    {

        private rspFD fdField;

        private string statusField;

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fd", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public rspFD fd
        {
            get
            {
                return this.fdField;
            }
            set
            {
                this.fdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }

    /// <remarks/>

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rspFD
    {

        private string fdTimeField;

        private rspFDSportsSport[] sportsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fdTime
        {
            get
            {
                return this.fdTimeField;
            }
            set
            {
                this.fdTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("sport", typeof(rspFDSportsSport), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public rspFDSportsSport[] sports
        {
            get
            {
                return this.sportsField;
            }
            set
            {
                this.sportsField = value;
            }
        }
    }

    /// <remarks/>

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rspFDSportsSport
    {

        private string idField;

        private rspFDSportsSportLeaguesLeague[] leaguesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("league", typeof(rspFDSportsSportLeaguesLeague), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public rspFDSportsSportLeaguesLeague[] leagues
        {
            get 
            {
                return this.leaguesField;
            }
            set
            {
                this.leaguesField = value;
            }
        }
    }

    /// <remarks/>

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rspFDSportsSportLeaguesLeague : INotifyPropertyChanged
    {

        private string idField;

        private rspFDSportsSportLeaguesLeagueEventsEvent[] eventsField;

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("event", typeof(rspFDSportsSportLeaguesLeagueEventsEvent), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public rspFDSportsSportLeaguesLeagueEventsEvent[] events
        {
            get
            {
                return this.eventsField;
            }
            set
            {
                this.eventsField = value;
                NotifyPropertyChanged("events");
            }
        }
    }

    /// <remarks/>

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rspFDSportsSportLeaguesLeagueEventsEvent : INotifyPropertyChanged
    {

        private string startDateTimeField;

        private string idField;

        private string isLiveField;

        private string statusField;

        private string drawRotNumField;

        private rspFDSportsSportLeaguesLeagueEventsEventHomeTeam[] homeTeamField;

        private rspFDSportsSportLeaguesLeagueEventsEventAwayTeam[] awayTeamField;

        private rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriod[] periodsField;

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string startDateTime
        {
            get
            {
                return this.startDateTimeField;
            }
            set
            {
                this.startDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IsLive
        {
            get
            {
                return this.isLiveField;
            }
            set
            {
                this.isLiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string drawRotNum
        {
            get
            {
                return this.drawRotNumField;
            }
            set
            {
                this.drawRotNumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("homeTeam", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public rspFDSportsSportLeaguesLeagueEventsEventHomeTeam[] homeTeam
        {
            get
            {
                return this.homeTeamField;
            }
            set
            {
                this.homeTeamField = value;
                NotifyPropertyChanged("homeTeam");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("awayTeam", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public rspFDSportsSportLeaguesLeagueEventsEventAwayTeam[] awayTeam
        {
            get
            {
                return this.awayTeamField;
            }
            set
            {
                this.awayTeamField = value;
                NotifyPropertyChanged("awayTeam");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("period", typeof(rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriod), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriod[] periods
        {
            get
            {
                return this.periodsField;
            }
            set
            {
                this.periodsField = value;
            }
        }
    }

    /// <remarks/>

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rspFDSportsSportLeaguesLeagueEventsEventHomeTeam : INotifyPropertyChanged
    {

        private string nameField;

        private string rotNumField;

        private string typeField;

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                NotifyPropertyChanged("name");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string rotNum
        {
            get
            {
                return this.rotNumField;
            }
            set
            {
                this.rotNumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rspFDSportsSportLeaguesLeagueEventsEventAwayTeam : INotifyPropertyChanged
    {

        private string nameField;

        private string rotNumField;

        private string typeField;

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                NotifyPropertyChanged("name");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string rotNum
        {
            get
            {
                return this.rotNumField;
            }
            set
            {
                this.rotNumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriod : INotifyPropertyChanged
    {

        private string numberField;

        private string descriptionField;

        private string cutoffDateTimeField;

        private rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodSpreadsSpread[] spreadsField;

        private rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodTotalsTotal[] totalsField;

        private rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodMoneyLine[] moneyLineField;

        private rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodTeamTotals[] teamTotalsField;

        private rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodMaxBetAmount[] maxBetAmountField;

        private string lineIdField;

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cutoffDateTime
        {
            get
            {
                return this.cutoffDateTimeField;
            }
            set
            {
                this.cutoffDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("spread", typeof(rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodSpreadsSpread), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodSpreadsSpread[] spreads
        {
            get
            {
                return this.spreadsField;
            }
            set
            {
                this.spreadsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("total", typeof(rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodTotalsTotal), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodTotalsTotal[] totals
        {
            get
            {
                return this.totalsField;
            }
            set
            {
                this.totalsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("moneyLine", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodMoneyLine[] moneyLine
        {
            get
            {
                return this.moneyLineField;
            }
            set
            {
                this.moneyLineField = value;
                NotifyPropertyChanged("moneyLine");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("teamTotals", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodTeamTotals[] teamTotals
        {
            get
            {
                return this.teamTotalsField;
            }
            set
            {
                this.teamTotalsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("maxBetAmount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodMaxBetAmount[] maxBetAmount
        {
            get
            {
                return this.maxBetAmountField;
            }
            set
            {
                this.maxBetAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lineId
        {
            get
            {
                return this.lineIdField;
            }
            set
            {
                this.lineIdField = value;
            }
        }
    }

    /// <remarks/>

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodSpreadsSpread : INotifyPropertyChanged
    {

        private string awaySpreadField;

        private string awayPriceField;

        private string homeSpreadField;

        private string homePriceField;

        private string altLineIdField;

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string awaySpread
        {
            get
            {
                return this.awaySpreadField;
            }
            set
            {
                this.awaySpreadField = value;
            }
        }



        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string awayPrice
        {
            get
            {
                return this.awayPriceField;
            }
            set
            {
                this.awayPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string homeSpread
        {
            get
            {
                return this.homeSpreadField;
            }
            set
            {
                this.homeSpreadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string homePrice
        {
            get
            {
                return this.homePriceField;
            }
            set
            {
                this.homePriceField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string altLineId
        {
            get
            {
                return this.altLineIdField;
            }
            set
            {
                this.altLineIdField = value;
            }
        }
    }

    /// <remarks/>

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodTotalsTotal
    {

        private string pointsField;

        private string overPriceField;

        private string underPriceField;

        private string altLineIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string points
        {
            get
            {
                return this.pointsField;
            }
            set
            {
                this.pointsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string overPrice
        {
            get
            {
                return this.overPriceField;
            }
            set
            {
                this.overPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string underPrice
        {
            get
            {
                return this.underPriceField;
            }
            set
            {
                this.underPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string altLineId
        {
            get
            {
                return this.altLineIdField;
            }
            set
            {
                this.altLineIdField = value;
            }
        }
    }

    /// <remarks/>

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodMoneyLine : INotifyPropertyChanged
    {

        private string awayPriceField;

        private string homePriceField;

        private string drawPriceField;

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string awayPrice
        {
            get
            {
                return this.awayPriceField;
            }
            set
            {
                this.awayPriceField = value;
                NotifyPropertyChanged("awayPrice");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string homePrice
        {
            get
            {
                return this.homePriceField;
            }
            set
            {
                this.homePriceField = value;
                NotifyPropertyChanged("homePrice");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string drawPrice
        {
            get
            {
                return this.drawPriceField;
            }
            set
            {
                this.drawPriceField = value;
                NotifyPropertyChanged("drawPrice");
            }
        }
    }

    /// <remarks/>

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodTeamTotals
    {

        private rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodTeamTotalsHomeTeamTotal[] homeTeamTotalField;

        private rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodTeamTotalsAwayTeamTotal[] awayTeamTotalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("homeTeamTotal", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodTeamTotalsHomeTeamTotal[] homeTeamTotal
        {
            get
            {
                return this.homeTeamTotalField;
            }
            set
            {
                this.homeTeamTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("awayTeamTotal", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodTeamTotalsAwayTeamTotal[] awayTeamTotal
        {
            get
            {
                return this.awayTeamTotalField;
            }
            set
            {
                this.awayTeamTotalField = value;
            }
        }
    }

    /// <remarks/>

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodTeamTotalsHomeTeamTotal
    {

        private string totalField;

        private string overPriceField;

        private string underPriceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string overPrice
        {
            get
            {
                return this.overPriceField;
            }
            set
            {
                this.overPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string underPrice
        {
            get
            {
                return this.underPriceField;
            }
            set
            {
                this.underPriceField = value;
            }
        }
    }

    /// <remarks/>

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodTeamTotalsAwayTeamTotal
    {

        private string totalField;

        private string overPriceField;

        private string underPriceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string overPrice
        {
            get
            {
                return this.overPriceField;
            }
            set
            {
                this.overPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string underPrice
        {
            get
            {
                return this.underPriceField;
            }
            set
            {
                this.underPriceField = value;
            }
        }
    }

    /// <remarks/>

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rspFDSportsSportLeaguesLeagueEventsEventPeriodsPeriodMaxBetAmount
    {

        private string spreadField;

        private string totalPointsField;

        private string moneyLineField;

        private string teamTotalsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string spread
        {
            get
            {
                return this.spreadField;
            }
            set
            {
                this.spreadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string totalPoints
        {
            get
            {
                return this.totalPointsField;
            }
            set
            {
                this.totalPointsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string moneyLine
        {
            get
            {
                return this.moneyLineField;
            }
            set
            {
                this.moneyLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string teamTotals
        {
            get
            {
                return this.teamTotalsField;
            }
            set
            {
                this.teamTotalsField = value;
            }
        }
    }

    /// <remarks/>

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class NewDataSet
    {

        private rsp[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rsp")]
        public rsp[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

}
