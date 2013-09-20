using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MyTicket.Resources;
using Microsoft.Phone.Maps.Controls;
using System.Device.Location; 
using Windows.Devices.Geolocation; 
using System.Windows.Media;
using System.Windows.Shapes;
using ShowMyLocationOnMap;


namespace MyTicket
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            ShowMyLocationOnTheMap();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private async void ShowMyLocationOnTheMap()
        {
            Geolocator myGeolocator = new Geolocator();
            Geoposition myGeoposition = await myGeolocator.GetGeopositionAsync();
            Geocoordinate myGeocoordinate = myGeoposition.Coordinate;
            GeoCoordinate myGeoCoordinate = CoordinateConverter.ConvertGeocoordinate(myGeocoordinate);

            this.BettingMap.Center = myGeoCoordinate;
            this.BettingMap.ZoomLevel = 15;

            Ellipse myCircle = new Ellipse();
            myCircle.Fill = new SolidColorBrush(Colors.Blue);
            myCircle.Height = 20;
            myCircle.Width = 20;
            myCircle.Opacity = 50;

            MapOverlay myLocationOverlay = new MapOverlay();
            myLocationOverlay.Content = myCircle;
            myLocationOverlay.PositionOrigin = new Point(0.5, 0.5);
            myLocationOverlay.GeoCoordinate = myGeoCoordinate;

            MapLayer myLocationLayer = new MapLayer();
            myLocationLayer.Add(myLocationOverlay);

            BettingMap.Layers.Add(myLocationLayer);
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
                App.ViewModel.LoadData();
            this.DataContext = App.ViewModel;
        }

        private void Dodadi_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                ViewModels.Ticket natprevar = new ViewModels.Ticket();
                natprevar.Par = par.Text.ToString();
                natprevar.Tip = tip.Text.ToString();
                natprevar.Koeficient = Convert.ToDouble(koeficient.Text);
                App.ViewModel.Tickets.Add(natprevar);

                double koef = 1;
                foreach (var item in App.ViewModel.Tickets)
                {
                    koef *= item.Koeficient;
                }
                vkkoef.Text = koef.ToString();
            }
            catch
            {
                MessageBox.Show("Внесете го парот, типот и коефициентот");
            }            
        }

        private void RemoveItemPar(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string text = ((TextBlock)sender).Text;
            ViewModels.Ticket kliknat = new ViewModels.Ticket();
            foreach (var par in App.ViewModel.Tickets)
            {
                if (par.Par == text)
                {
                    kliknat = par;
                    break;
                }
            }
            App.ViewModel.Tickets.Remove(kliknat);
            double koef = 1;
            foreach (var item in App.ViewModel.Tickets)
            {
                koef *= item.Koeficient;
            }
            vkkoef.Text = koef.ToString();
        }

        private void RemoveItemTip(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string text = ((TextBlock)sender).Text;
            ViewModels.Ticket kliknat = new ViewModels.Ticket();
            foreach (var tip in App.ViewModel.Tickets)
            {
                if (tip.Tip == text)
                {
                    kliknat = tip;
                    break;
                }
            }
            App.ViewModel.Tickets.Remove(kliknat);
        }

        private void RemoveItemKoeff(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ViewModels.Ticket kliknat = new ViewModels.Ticket();
            foreach (var koeff in App.ViewModel.Tickets)
            {
                if (koeff.Koeficient == Convert.ToDouble(((TextBlock)sender).Text))
                {
                    kliknat = koeff;
                    break;
                }
            }
            App.ViewModel.Tickets.Remove(kliknat);
        }

        private void kladilnici_Click_1(object sender, RoutedEventArgs e)
        {
            Polygon MyPolygon = new Polygon();
            MyPolygon.Points.Add(new Point(2, 0));
            MyPolygon.Points.Add(new Point(12, 0));
            MyPolygon.Points.Add(new Point(2, 20));
            MyPolygon.Stroke = new SolidColorBrush(Colors.Red);
            MyPolygon.Fill = new SolidColorBrush(Colors.Red);
            MapOverlay MyOverlay = new MapOverlay();
            MyOverlay.Content = MyPolygon;
            MyOverlay.PositionOrigin = new Point(0.5, 0.5);
            MyOverlay.GeoCoordinate = new GeoCoordinate(41.9993444,21.4255607);
            MapLayer myLocationLayer = new MapLayer();
            myLocationLayer.Add(MyOverlay);
            BettingMap.Layers.Add(myLocationLayer);

            Polygon My2Polygon = new Polygon();
            My2Polygon.Points.Add(new Point(2, 0));
            My2Polygon.Points.Add(new Point(22, 0));
            My2Polygon.Points.Add(new Point(2, 40));
            My2Polygon.Stroke = new SolidColorBrush(Colors.Red);
            My2Polygon.Fill = new SolidColorBrush(Colors.Red);
            MapOverlay My2Overlay = new MapOverlay();
            My2Overlay.Content = My2Polygon;
            My2Overlay.PositionOrigin = new Point(0.5, 0.5);
            My2Overlay.GeoCoordinate = new GeoCoordinate(41.9803655, 21.4408063);
            MapLayer my2LocationLayer = new MapLayer();
            my2LocationLayer.Add(My2Overlay);
            BettingMap.Layers.Add(my2LocationLayer);

            Polygon My3Polygon = new Polygon();
            My3Polygon.Points.Add(new Point(2, 0));
            My3Polygon.Points.Add(new Point(22, 0));
            My3Polygon.Points.Add(new Point(2, 40));
            My3Polygon.Stroke = new SolidColorBrush(Colors.Red);
            My3Polygon.Fill = new SolidColorBrush(Colors.Red);
            MapOverlay My3Overlay = new MapOverlay();
            My3Overlay.Content = My3Polygon;
            My3Overlay.PositionOrigin = new Point(0.5, 0.5);
            My3Overlay.GeoCoordinate = new GeoCoordinate(41.9396852, 21.5156292);
            MapLayer my3LocationLayer = new MapLayer();
            my3LocationLayer.Add(My3Overlay);
            BettingMap.Layers.Add(my3LocationLayer);

            Polygon My4Polygon = new Polygon();
            My4Polygon.Points.Add(new Point(2, 0));
            My4Polygon.Points.Add(new Point(22, 0));
            My4Polygon.Points.Add(new Point(2, 40));
            My4Polygon.Stroke = new SolidColorBrush(Colors.Red);
            My4Polygon.Fill = new SolidColorBrush(Colors.Red);
            MapOverlay My4Overlay = new MapOverlay();
            My4Overlay.Content = My4Polygon;
            My4Overlay.PositionOrigin = new Point(0.5, 0.5);
            My4Overlay.GeoCoordinate = new GeoCoordinate(41.999487, 21.41759991);
            MapLayer my4LocationLayer = new MapLayer();
            my4LocationLayer.Add(My4Overlay);
            BettingMap.Layers.Add(my4LocationLayer);
            
           
        }

        

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}