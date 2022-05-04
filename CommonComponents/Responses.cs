using System;
using System.Collections.Generic;
using CommonComponents.Models;

namespace CommonComponents
{
    public class GetTripsResponse
    {
        public List<Trip> Trips { get; set; }
    }
    
    public class GetTripOfferResponse
    {
        public TripOffer TripOffer { get; set; }
   
    }


    public class GetHotelsResponse
    {
        public List<Hotel> Hotels { get; set; }
    }
    
    public class GetTransportResponse
    {
        public List<Transport> Transports { get; set; }
    }
    
    public class GetHotelOfferResponse
    {
        public HotelOffer HotelOffer { get; set; }
    }

    public class GetTransportOffersResponse
    {
        public List<TransportOffer> TransportOffer { get; set; }
    }
    
    public class ReserveTripResponse
    {
        public int Price { get; set; }
        public bool Success { get; set; }
        public Guid ReservationId { get; set; }
    }
    public class ReserveTransportResponse
    {
        public bool Created { get; set; }
        public Guid DepartueReservationid { get; set;}
        public Guid ReturnReservationid { get; set;}

    }
    

    public class ReserveHotelSuccessResponse
    {
        public Guid ReservationId { get; set; }
        public int Price { get; set; }

    }
    
    public class ReserveHotelFailureResponse
    {
        public Guid ReservationId { get; set; }

    }
    public class ReserveTransportSuccessResponse
    {
        public Guid ReservationId { get; set; }
        public int Price { get; set; }

    }

    public class ReserveTransportFailureResponse
    {
        public Guid ReservationId { get; set; }

    }

    public class PaymentExpired
    {
        public Guid ReservationId { get; set; }
    }

    public class PaymentForTripAccepted
    {
        public Guid ReservationId { get; set; }

    }

    public class PaymentForTripRejected
    {
        public Guid ReservationId { get; set; }

    }

}