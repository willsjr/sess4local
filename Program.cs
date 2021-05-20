using System;

namespace session_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int earth_seconds = 31557600;
            int space_seconds = 631154000;

            float earth_age = space_seconds/earth_seconds;


            string [] planet = new string [4];
            planet [0] = "Venus";
            planet [1] = "Mars";
            planet [2] = "Jupiter";
            planet [3] = "Neptune";

          
            float [] planet_time = new float [4];
            planet_time [0] = 0.61519724f;
            planet_time [1] = 1.8808158f;
            planet_time [2] = 11.8626615f;
            planet_time [3] = 164.79132f;


            for (int i = 0; i < planet.Length; i++)
            {
                float planet_age = earth_age/planet_time[i];        
                Console.WriteLine("Earth age: " +earth_age+ " Earth-years old- " +planet[i]+": "+planet_age+" Earth-years old");
                               
            }
        }
    }
}
