using System;
using System.Collections.Generic;
using System.Text;
using Carpool;
//using Carpool.Services;

namespace Carpool.Models
{
    public class Destination : Address 
    {
        public int DistancefromStartPoint { get; set; }
              
    }
}
