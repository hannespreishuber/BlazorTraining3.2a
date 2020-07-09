using BlazorTraining3._2.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTraining3._2.Pages
{
    public partial class Hannes
    {
        [Inject] WeatherForecastService ForecastService{ get; set; }
  
        protected override void OnInitialized()
        {
           
        }
    }
}
