using System;
using System.Collections.Generic;

namespace Cooperchip.ChartRealTime.Api.Models
{
    public class Eixos
    {
        public Eixos()
        {
            x = new DateTime();
            y = new List<double>();
        }
        public DateTime x { get; set; }
        public List<double> y { get; set; }
    }

    public class ChartModel
    {
        public List<Eixos> Data { get; set; }
    }

}
