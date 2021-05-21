using System;

namespace session_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int earth_seconds = 31557600;
            int space_seconds = 631154000;

            double earth_age = space_seconds/earth_seconds;


            string [] planet = new string [4];
            planet [0] = "Venus";
            planet [1] = "Mars";
            planet [2] = "Jupiter";
            planet [3] = "Neptune";

          
            double [] planet_time = new double [4];
            planet_time [0] = 0.61519724;
            planet_time [1] = 1.8808158;
            planet_time [2] = 11.8626615;
            planet_time [3] = 164.79132;


            for (int i = 0; i < planet_time.Length; i++)
            {
                double planet_age = Math.Round(earth_age/planet_time[i],2);   
                // planet_age = Math.Round(planet_age,2);     
                Console.WriteLine("Earth age: " +earth_age+ " Earth-years old- " +planet[i]+": "+planet_age+" Earth-years old");
                               
            }
        }
    }
}
