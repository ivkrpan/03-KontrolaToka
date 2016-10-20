using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp
{
    public static class IspisDana
    {
        public static string ImeDana(DayOfWeek danUTjednu)
        {
        
                // TODO: Napisati grane case za svaki dan u tjednu tako da vraćaju "ponedjeljak" za DayOfWeek.Monday, "utorak" za DayOfWeek.Tuesday itd.

                // TODO: Za nepodržane vrijednosti treba baciti iznimku tipa ArgumentOutOfRangeException:
               switch(danUTjednu)
               {
                   case DayOfWeek.Monday:
                       return "ponedjeljak";
                   case DayOfWeek.Tuesday:
                       return "utorak";
                   case DayOfWeek.Wednesday:
                       return "srijeda";
                   case DayOfWeek.Thursday:
                       return "četvrtak";
                   case DayOfWeek.Friday:
                       return "petak";
                   case DayOfWeek.Saturday:
                       return "subota";
                   case DayOfWeek.Sunday:
                       return "nedjelja";

                   default:
                       throw new ArgumentOutOfRangeException("danUTjednu");

      
            }
        }

        public static string RadniNeradni(DayOfWeek danUTjednu)
        {
   
            switch (danUTjednu)
            {
                // TODO: Napisati grane case tako da za svaki radni dan u tjednu vraća "radni dan", a za subotu i nedjelju vraća "vikend"
         
                   case DayOfWeek.Monday:
                //       return "ponedjeljak";
                   case DayOfWeek.Thursday:
                //       return "utorak";
                   case DayOfWeek.Wednesday:
                //       return "srijeda";
                   case DayOfWeek.Tuesday:
                //       return "četvrtak";
                   case DayOfWeek.Friday:
                //       return "petak";
                       return "radni dan";
                   case DayOfWeek.Saturday:
                //       return "subota";
                   case DayOfWeek.Sunday:
                       return "vikend";

                // TODO: Za nepodržane vrijednosti treba baciti iznimku tipa ArgumentOutOfRangeException:
                default:
                       throw new ArgumentOutOfRangeException("danUTjednu");
            }
        }
    }
}
