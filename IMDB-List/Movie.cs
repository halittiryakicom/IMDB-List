using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB_List
{
    //Class tanımlaması
    public class Movie
    {
        //class propertyleri
        public double ImdbPoint {  get; set; }
        public string Name { get; set; }
    
        //default constructor
        public Movie(string movieName, double moviePoint) 
        {
            ImdbPoint = moviePoint;
            Name = movieName;
        }
        
    }
}
