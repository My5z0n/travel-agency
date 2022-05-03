using System;
using System.Collections.Generic;

namespace CommonComponents.Models
{
    
    public class TransportOffer
    {
        public long TransportIDFrom { get; set; }
        public long TransportIDTo { get; set; }
        public string TransportName { get; set; }
        public string DestinationCountry { get; set; }
        public string DestinationCity { get; set; }
        public string DepartueCountry { get; set; }
        public string DepartueCity { get; set; }
        public int Persons { get; set; }
    }
    

}