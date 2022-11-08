using System;
using System.Collections.Generic;
using System.Text;

namespace Fecha
{
    class MyDate
    {
        int day;
        int month;
        int year;

        //Constructores
        public MyDate()
        {
            DateTime today = DateTime.Today;
            day = today.Day;
            month = today.Month;
            year = today.Year;
        }
        public MyDate(int day)
        {
            DateTime today = DateTime.Today;
            this.day = day;
            month = today.Month;
            year = today.Year;
        }
        public MyDate(int day, int month)
        {
            DateTime today = DateTime.Today;
            this.day = day;
            this.month = month;
            year = today.Year;
        }
        public MyDate(int day, int month, int year)
        {
           this.day = day;
           this.month = month;
           this.year = year;
        }
        //Get y Set
        // toString
        public string toString()
        {
            return day + "/" + month + "/" + year;
        }
        // Comprobar fecha correcta
        public bool IsNotWrong()
        {
            if (month <= 0 && month > 12)
            {
                return false;
            }
            if (day < 0 && day > 31)
            {
                return false;
            }
            switch(month)
            {
                // Meses de 30 días
                case 4: if (day == 31) return false; break;
                case 6: if (day == 31) return false; break;
                case 9: if (day == 31) return false; break;
                case 11: if (day == 31) return false; break;

                    //// Meses de 31 días
                    //case 1:                  
                    //case 3:                
                    //case 5:                
                    //case 7: 
                    //case 8:                
                    //case 10:                
                    //case 12:
                    //    if (day == 31) return true;
                    //    break;
                case 2:
                    if (IsLeap())
                    {
                        // Es bisiesto
                        if (day > 29)
                        {
                            return false;
                        }
                        else
                        {
                            // No es bisiesto
                            if (day > 28)
                            {
                                return false;
                            }
                        }
                    }
                    break;
            }
            return true;
        }
        public bool IsLeap()
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }
        // sumar un dia
        public void NextDay()
        {
            day = day + 1;
            if (month == 11 || month == 4 || month == 6 || month == 9)
            {
                if (day >= 31)
                {
                    day = day - 30;
                    month = month + 1;
                }
            }
            if (month == 2)
            {
                if (day > 29)
                {
                    day = day - 29;
                    month = month + 1;
                }
            }
            else
            {

            }
            if (month > 12)
            {
                month = month - 12;
                year = year + 1;
            }
        }
    }
}
