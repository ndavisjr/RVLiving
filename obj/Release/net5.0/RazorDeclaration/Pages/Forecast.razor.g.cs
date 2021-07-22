// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RVLiving.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using RVLiving;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using RVLiving.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ndavisjr\Desktop\RVLiving\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/forecast")]
    public partial class Forecast : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 140 "C:\Users\ndavisjr\Desktop\RVLiving\Pages\Forecast.razor"
 
    public string Location
    {
        get => _location;
        set
        {
            _location = value;
            this.StateHasChanged();
        }
    }

    private string _location;
    private string url, city, state;
    private string apikey = "445c6319af922ff980fcf2a1cbb6b22e";
    private FutureConditions futureConditions;
    private LocalConditions localConditions;
    private double lat, lon = 0;
    async Task KeyHandler(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
            await GetWxInfo();
    }

    private async Task GetWxInfo()
    {
        await GetLocalConditions();

        lat = localConditions.Coord.Lat;
        lon = localConditions.Coord.Lon;
        await GetFutureConditions();
        this.StateHasChanged();
    }

    private async Task GetLocalConditions()
    {
        // Do we have a zip code or city, state
        var isNumeric = int.TryParse(Location, out int zip);

        if (isNumeric)
        {
            url = $"https://api.openweathermap.org/data/2.5/weather?zip={zip},us&appid={apikey}&units=imperial";
        }
        else
        {
            url = "string";
            string[] locationDetails = Location.Split(',');
            city = locationDetails[0];
            state = "US-" + locationDetails[1].Trim();

            url = $"https://api.openweathermap.org/data/2.5/weather?q={city},{state}&appid={apikey}&units=imperial";
        }

        var client = ClientFactory.CreateClient();
        localConditions = await client.GetJsonAsync<LocalConditions>(url);
    }

    private async Task GetFutureConditions()
    {
        var exclude = "current,minutely,hourly,alerts";

        url =
        $"https://api.openweathermap.org/data/2.5/onecall?lat={lat}&lon={lon}&exclude={exclude}&appid={apikey}&units=imperial";

        var client = ClientFactory.CreateClient();
        futureConditions = await client.GetJsonAsync<FutureConditions>(url);
    }


    public class LocalConditions
    {
        public Coordinates Coord { get; set; }
        public CurrentWeather[] weather { get; set; }
        public MainCond Main { get; set; }
        public WindCond Wind { get; set; }
        public double Dt { get; set; }
        public string Name { get; set; }
    }

    public class Coordinates
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
    }

    public class CurrentWeather
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
    }

    public class MainCond
    {
        public double Temp { get; set; }
        public double Feels_Like { get; set; }
        public double Temp_Min { get; set; }
        public double Temp_Max { get; set; }
        public double Pressure { get; set; }
        public double Humidity { get; set; }
    }

    public class WindCond
    {
        public double Speed { get; set; }
        public int Deg { get; set; }
        public double Gust { get; set; }
    }

    public class FutureConditions
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
        public DailyCond[] Daily { get; set; }

    }

    public class DailyCond
    {
        public double Dt { get; set; }
        public DailyTemp Temp { get; set; }
        public double Pop { get; set; }
        public double Pressure { get; set; }
        public double Humidity { get; set; }
        public double Dew_Point { get; set; }
        public double Wind_Speed { get; set; }
        public double Wind_Deg { get; set; }
        public DailyWeather[] Weather { get; set; }
    }

    public class DailyTemp
    {
        public double Min { get; set; }
        public double Max { get; set; }
    }

    public class DailyWeather
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
    }

    private string degToCompass(double degrees)
    {
        degrees *= 10;

        string[] caridnals = { "N", "NNE", "NE", "ENE", "E", "ESE", "SE", "SSE", "S", "SSW", "SW", "WSW", "W", "WNW", "NW",
"NNW", "N" };
        return caridnals[(int)Math.Round(((double)degrees % 3600) / 225)];
    }

    public DateTime UnixTimeStampToDateTime(double unixTimeStamp)
    {
        // Unix timestamp is seconds past epoch
        System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
        dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
        return dtDateTime;
    }

    private int ConvertPopChance(double pop)
    {
        return (int)((double)pop * 100);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
    }
}
#pragma warning restore 1591