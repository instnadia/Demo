using System.Collections.Generic;

namespace Lect.Models
{
    public class MovieQuotes
    {
        public List<Quote> allQuotes {get;set;}

        public MovieQuotes(){
            allQuotes = new List<Quote>();
        }
    }
}