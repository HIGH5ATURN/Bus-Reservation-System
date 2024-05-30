using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Reservation_System
{
    public static class Utility
    {
        public static string ReceptionistID;
        public static DateOnly ConvertToDate(String date)
        {
            string year="";
            string month="";
            string day="";

            for (int i = 0; i < date.Length; i++)
            {
                if(i<=1)
                {
                    year += date[i];
                }

                if(i>2 && i<=5)
                {
                    month += date[i];
                }

                if(i>6 && i<=8)
                {
                    day += date[i];
                }
            }

            int mon=1;

            if(month.ToLower()=="jan")
            {
                mon = 1;
            }
            else if(month.ToLower() =="feb")
            {
                mon = 2;
            }
            else if(month.ToLower() =="mar")
            {
                mon = 3;
            }
            else if(month.ToLower() =="apr")
            {
                mon = 4;
            }
            else if(month.ToLower() =="may")
            {
                mon = 5;
            }
            else if(month.ToLower() =="jun")
            {
                mon = 6;
            }
            else if(month.ToLower() =="jul")
            {
                mon = 7;
            }
            else if(month.ToLower() =="aug")
            {
                mon = 8;
            }
            else if(month.ToLower() =="sep")
            {
                mon = 9;
            }
            else if(month.ToLower() =="oct")
            {
                mon = 10;

            }
            else if(month.ToLower() =="nov")
            {
                mon = 11;
            }
            else if(month.ToLower() =="dec")
            {
                mon = 12;
            }

            return new DateOnly(Convert.ToInt32(year),mon,Convert.ToInt32(day));

        }
    }
}
