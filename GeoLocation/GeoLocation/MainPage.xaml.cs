using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
//using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace GeoLocation
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();

            // Task.Delay(2000);
            //UpdateMap();
        }

        List<Place> placesList = new List<Place>();

        //private async void UpdateMap()
        //{
        //    try
        //    {
        //        var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly;
        //        Stream stream = assembly.GetManifestResourceStream("GeoLocation.Places.json");
        //        string text = string.Empty;



        //        //using (var reader = new StreamReader(stream))
        //        //{
        //        //    text = reader.ReadToEnd();
        //        //}

        //        //var resultObject = JsonConvert.DeserializeObject<Places>(text);

        //        //foreach (var place in resultObject.results)
        //        //{
        //        //    placesList.Add(new Place
        //        //    {
        //        //        PlaceName = place.name,
        //        //        Address = place.vicinity,
        //        //        Location = place.geometry.location,
        //        //        Position = new Position(place.geometry.location.lat, place.geometry.location.lng),
        //        //        Icon = place.icon,
        //        //        //Distance = $"{GetDistance(lat1, lon1, place.geometry.location.lat, place.geometry.location.lng, DistanceUnit.Kiliometers).ToString("N2")}km",
        //        //        //OpenNow = GetOpenHours(place?.opening_hours?.open_now)
        //        //    });
        //        //}

        //        // Lägg till mitt eget ställe

        //        placesList.Add(new Place
        //        {
        //            PlaceName = "Lund",
        //            Address = "Möklinta Lund:100",
        //            //Location = place.geometry.location,
        //            Position = new Position(60.123558, 16.664340),
        //            //Icon = place.icon,
        //            //Distance = $"{GetDistance(lat1, lon1, place.geometry.location.lat, place.geometry.location.lng, DistanceUnit.Kiliometers).ToString("N2")}km",
        //            //OpenNow = GetOpenHours(place?.opening_hours?.open_now)
        //        });

        //        //Lägg till pin där vi befinner oss

        //        var loc = await Xamarin.Essentials.Geolocation.GetLocationAsync();

        //        try
        //        {
        //            // var loc = await Geolocation.GetLastKnownLocationAsync();
        //            if (loc == null)
        //            {

        //                loc = await Geolocation.GetLocationAsync(new GeolocationRequest
        //                {
        //                    DesiredAccuracy = GeolocationAccuracy.Medium,
        //                    Timeout = TimeSpan.FromSeconds(30)
        //                });
        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            Debug.WriteLine($"Shit, nått gick ordentligt fel !! {ex.Message}");
        //        }


        //        placesList.Add(new Place
        //        {
        //            PlaceName = "Här befinner du dig !",
        //            //Address = "",
        //            //Location = place.geometry.location,
        //            Position = new Position(loc.Latitude, loc.Longitude),
        //            //Icon = place.icon,
        //            //Distance = $"{GetDistance(lat1, lon1, place.geometry.location.lat, place.geometry.location.lng, DistanceUnit.Kiliometers).ToString("N2")}km",
        //            //OpenNow = GetOpenHours(place?.opening_hours?.open_now)
        //        });

        //        MyMap.ItemsSource = placesList;
        //        //PlacesListView.ItemsSource = placesList;
        //        //MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(47.6370891183, -122.123736172), Distance.FromKilometers(100)));
        //        MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(loc.Latitude, loc.Longitude), Distance.FromKilometers(100)));



        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex);
        //    }


        //}

        private async void ButtonOpenCoords_Clicked(object sender, EventArgs e)
        {
            if (!double.TryParse(EntryLatitude.Text, out double lat))
                return;

            if (!double.TryParse(EntryLongitude.Text, out double lng))
                return;

            await Map.OpenAsync(lat, lng, new MapLaunchOptions
            {
                Name = EntryName.Text,
                NavigationMode = NavigationMode.None

            });


        }


        //   private async void Button_Clicked(object sender, EventArgs e)
        //    {
        //        try
        //        {

        //            var location = await Geolocation.GetLastKnownLocationAsync();
        //            if (location == null)
        //            {

        //                location = await Geolocation.GetLocationAsync(new GeolocationRequest
        //                {
        //                    DesiredAccuracy = GeolocationAccuracy.Medium,
        //                    Timeout = TimeSpan.FromSeconds(30)
        //                });
        //            }

        //            if (location == null)
        //            {
        //                LabelLocation.Text = "Du hadde ingen GPS !";
        //            }
        //            else
        //            {
        //                LabelLocation.Text = $"\tLatitud: {location.Latitude} \n\tLongitud: {location.Longitude}";
        //            }


        //        }
        //        catch (Exception ex)
        //        {

        //            Debug.WriteLine($"Shit, nått gick ordentligt fel !! {ex.Message}");
        //        }


        //    }
    }
}
