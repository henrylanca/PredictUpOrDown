using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredictUpOrDown.classes
{
    public class StockItem
    {
        public int Year { get; set; }

        public int Date { get; set; }

        public int WeekDay { get; set;}

        //OpenRatio = (Open -close)/Close
        //HighRatio = (High-close)/close
        //LowRatio = (Low - Close)/close
        //ChgRatio = (Close - Prev close)/Prev close
        //VolRatio = Vol / Avg(Vol, 20)

        public double CurDayOpenRatio { get; set; } 

        public double CurDayHighRatio { get; set; }

        public double CurDayLowRatio { get; set; }

        public double CurDayChgRatio { get; set; }

        public double CurDayVolRatio { get; set; }

        public double PrevDayOpenRatio { get; set; }

        public double PrevDayHighRatio { get; set; }

        public double PrevDayLowRatio { get; set; }


        public double Prev2DayOpenRatio { get; set; }

        public double Prev2DayHighRatio { get; set; }

        public double Prev2DayLowRatio { get; set; }

        public double Prev2DayChgRatio { get; set; }
    }
}
