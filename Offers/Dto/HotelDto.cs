﻿namespace Models.Offers.Dto
{
    // TODO check if not redundant
    public class HotelDto
    {
        public int HotelItemId { get; set; }
        public string HotelName { get; set; }
        public string Location { get; set; }
        public bool WifiAvailable { get; set; }
        public bool BreakfastAvailable { get; set; }
        public int BigRoomsAvailable { get; set; }
        public int SmallRoomsAvailable { get; set; }
        public double PricePerPersonPerNight { get; set; }
        public double BreakfastPrice { get; set; }

        public HotelDto(int hotelItemId, string hotelName, string location)
        {
            HotelItemId = hotelItemId;
            HotelName = hotelName;
            Location = location;
        }

        public HotelDto(Models.Hotels.HotelItem hotelItem)
        {
            HotelItemId = hotelItem.HotelItemId;
            HotelName= hotelItem.HotelName;
            Location = hotelItem.HotelCountry;
            WifiAvailable = hotelItem.HotelHasWifi;
            BreakfastAvailable = hotelItem.HotelBreakfastPrice >= 0;
            BreakfastPrice = hotelItem.HotelBreakfastPrice;
            PricePerPersonPerNight = hotelItem.HotelPriceForNightForPerson;
            BigRoomsAvailable = hotelItem.ApartmentsAmount;
            SmallRoomsAvailable = hotelItem.CasualRoomsAmount;
        }
    }
}
