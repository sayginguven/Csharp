using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProject
{
    public class Coordination {
        public double Lon { get; set; } = -1;
        public double Lat { get; set; } = -1;
    }

    public class CloudsInfo
    {
        public int All { get; set; } = -1;
    }

    public class WeatherInfo {
        public int Id { get; set; } = -1;
        public string Main { get; set; } = "-1";
        public string Description { get; set; } = "-1";
        public string Icon { get; set; } = "-1";
    }

    public class MainInfo
    {
        public double Temp { get; set; } = -1;
        public double Pressure { get; set; } = -1;
        public int  Humidity { get; set; } = -1;
        public double Temp_min { get; set; } = -1;
        public double Temp_max { get; set; } = -1;
        public double Sea_level{ get; set; } = -1;
        public double Grnd_level{ get; set; } = -1;
        public double Temp_kf{ get; set; } = -1;

    }
    public class SysInfo
    {
        public int Type { get; set; } = -1;
        public int Id { get; set; } = -1;
        public double Message { get; set; } = -1;
        public string Country { get; set; } = "-1";
        public long Sunrise { get; set; } = -1;
        public long Sunset { get; set; } = -1;
        public string Pod { get; set; } = "-1";
    }


    public class WindInfo
    {
        public double Speed { get; set; } = -1;
        public double Deg { get; set; } = -1;
    }

    public class SummaryWeather {

        public long Dt { get; set; } = -1;
        public MainInfo Main { get; set; } 
        public List<WeatherInfo> Weather { get; set; }
        public CloudsInfo Clouds { get; set; } 
        public WindInfo Wind { get; set; } 
        public SysInfo Sys { get; set; } 
        public string Dt_txt { get; set; } = "-1";

    }

    public class City {

        public int Id{ get; set; } = -1;
        public string Name{ get; set; } = "-1";
        public Coordination Coord { get; set; }
        public string Country{ get; set; } = "-1";
        public int Population{ get; set; } = -1;


    }

    public class OpenWeather
    {

        //public Coordination Coord { get; set; }
        public List<WeatherInfo> Weather { get; set; }
        public string Base {get; set;} = "-1";
        public MainInfo Main { get; set; }
        public int Visibility { get; set; } = -1;
        public WindInfo Wind { get; set; }
        public CloudsInfo Clouds { get; set; }
        public long Dt { get; set; } = -1;
        public double Timezone { get; set; } = -1;
        public SysInfo Sys { get; set; }
        public int Id { get; set; } = -1;
        public string Name { get; set; } = "-1";
        public int Cod { get; set; } = -1;
        public double Message { get; set; } = -1;
        public City City { get; set; }
        public int Cnt { get; set; } = -1;
        public List<SummaryWeather> List { get; set; }
        public string Dt_txt{ get; set; } = "-1";


        public string PrintSunset() {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(this.Sys.Sunset).ToLocalTime();
            string canadianTime = dtDateTime.ToString("dddd | MMMM dd,yyyy h:mm tt");
            return canadianTime;
        }
        public string PrintSunrise()
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(this.Sys.Sunrise).ToLocalTime();
            string canadianTime = dtDateTime.ToString("dddd | MMMM dd,yyyy h:mm tt");
            return canadianTime;
        }

        public string PrintTime()
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(this.Dt).ToLocalTime();
            string canadianTime = dtDateTime.ToString("dddd | MMMM dd,yyyy h:mm tt");
            return canadianTime;
        }
        public string PrintTime(double time)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(time).ToLocalTime();
            string canadianTime = dtDateTime.ToString("ddd | MMMM dd, yyyy hh:mm tt");
            return canadianTime;
        }


        public void PrintDetails() {

            //StringBuilder sb = new StringBuilder($"Coordination info :  Lattitute {this.Coord.Lat}, Longtitute  {this.Coord.Lon} \u000a");
            StringBuilder sb = new StringBuilder();
            foreach (var item in Weather)
            {
                sb.Append($"Id {item.Id}, Main {item.Main}, description {item.Description}, icon {item.Icon} \u000a");
            }
            sb.Append($"Base is {this.Base} \u000a");
            sb.Append($"Temperature {this.Main.Temp - 273.15 }\u00B0C \u000a");
            sb.Append($"Pressure {this.Main.Pressure} \u000a");
            sb.Append($"Humidity {this.Main.Humidity} \u000a");
            sb.Append($"Minimum Temperature {this.Main.Temp_min - 273.15}\u00B0C \u000a");
            sb.Append($"Maximum Temperature {this.Main.Temp_max - 273.15}\u00B0C \u000a");
            sb.Append($"Visibility {this.Visibility} \u000a");
            sb.Append($"Wind speed {this.Wind.Speed}, degree {this.Wind.Deg} \u000a");
            //sb.Append($"Rain {this.rain}")
            sb.Append($"Clouds {this.Clouds.All} \u000a");
            sb.Append($"Sys type {this.Sys.Type} \u000a");
            sb.Append($"Sys id {this.Sys.Id} \u000a");
            sb.Append($"Sys message {this.Sys.Message} \u000a");
            sb.Append($"Sys country {this.Sys.Country} \u000a");
            sb.Append($"Sys sunrise {this.PrintSunrise()} \u000a");
            sb.Append($"Sys sunset {this.PrintSunset()} \u000a");
            sb.Append($"Date: {this.PrintTime()} \u000a");
            sb.Append($"Id : {this.Id} \u000a");
            sb.Append($"City: {this.Name} \u000a");
            sb.Append($"Cod : {this.Cod} \u000a");
            Console.WriteLine(sb.ToString());
        }


        public void PrintListInfo() {

            StringBuilder sb = new StringBuilder();
            sb.Append($"city : {this.City.Name}, {this.City.Country} \u000a");
            foreach (var item in List)
            {
                sb.Append($" {PrintTime(item.Dt)} : min {Math.Round((item.Main.Temp_min - 273.15),0)}\u00B0C, max {Math.Round((item.Main.Temp_max - 273.15), 0)}\u00B0C - {item.Weather[0].Description}\u000a");
            }

            Console.WriteLine(sb.ToString());
        }


    }
}
