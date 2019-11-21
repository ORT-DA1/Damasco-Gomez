using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic
{
    public class CompareValues
    {
        public CompareValues()
        {

        }
        public bool CompareHours(string initHour, string finHour, string compareHour)
        {
            string[] parserFin = finHour.Split(':');
            string[] parserIni = initHour.Split(':');
            string[] parseCompare = compareHour.Split(':');
            bool betweenHours = Int32.Parse(parserIni[0]) < Int32.Parse(parseCompare[0]) && Int32.Parse(parserFin[0]) > Int32.Parse(parseCompare[0]);
            bool sameHourInit = Int32.Parse(parserIni[0]) == Int32.Parse(parseCompare[0]) && Int32.Parse(parserIni[1]) <= Int32.Parse(parseCompare[1]);
            bool sameHourFinit = Int32.Parse(parserFin[0]) == Int32.Parse(parseCompare[0]) && Int32.Parse(parserFin[1]) > Int32.Parse(parseCompare[1]);
            return betweenHours || sameHourInit || sameHourFinit;
        }

        public bool CompareDate(string initDay, string finDay, string compareDay)
        {
            string[] parseInitDay = initDay.Split('-');
            string[] parseFinDay = finDay.Split('-');
            string[] parseCompareDay = compareDay.Split('-');
            bool betweenDay = Int32.Parse(parseInitDay[1]) < Int32.Parse(parseCompareDay[1]) && Int32.Parse(parseFinDay[1]) > Int32.Parse(parseCompareDay[1]);
            bool sameInitDay = Int32.Parse(parseInitDay[1]) == Int32.Parse(parseCompareDay[1]) && Int32.Parse(parseInitDay[0]) <= Int32.Parse(parseCompareDay[0]);
            bool sameFinDay = Int32.Parse(parseFinDay[1]) == Int32.Parse(parseCompareDay[1]) && Int32.Parse(parseFinDay[0]) >= Int32.Parse(parseCompareDay[0]);
            return betweenDay || sameInitDay || sameFinDay;

        }
    }
}
