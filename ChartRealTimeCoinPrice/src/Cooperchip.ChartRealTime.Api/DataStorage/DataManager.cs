using Cooperchip.ChartRealTime.Api.Models;
using System;
using System.Collections.Generic;

namespace Cooperchip.ChartRealTime.Api.DataStorage
{
    public static class DataManager
    {
        public static List<ChartModel> GetData()
        {
            var r = new Random();
            return new List<ChartModel>()
            {
               new ChartModel { Data = new List<int> { r.Next(1, 40) }, Label = "Data1" },
               new ChartModel { Data = new List<int> { r.Next(1, 40) }, Label = "Data2" },
               new ChartModel { Data = new List<int> { r.Next(1, 40) }, Label = "Data3" },
               new ChartModel { Data = new List<int> { r.Next(1, 40) }, Label = "Data4" },
               new ChartModel { Data = new List<int> { r.Next(1, 40) }, Label = "Data5" },
               new ChartModel { Data = new List<int> { r.Next(1, 40) }, Label = "Data6" }
            };
        }
    }
}
