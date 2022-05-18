﻿namespace Models.Hotels
{
    public class ReserveRoomsEvent : EventModel
    {
        public int HotelId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }

        public int AppartmentsAmount { get; set; }
        public int CasualRoomAmount { get; set; }
        public Guid UserId { get; set; }
        public Guid ReservationNumber { get; set; }
        public Boolean Breakfast { get; set; }
        public Boolean Wifi { get; set; }

        public ReserveRoomsEvent(
            int hotelId, DateTime beginDate, DateTime endDate,
            int appartmentsAmount, int casualRoomAmount,
            Guid userId, Guid reservationNumber,
            Boolean breakfast, Boolean wifi) : base()
        {
            HotelId = hotelId;
            BeginDate = beginDate;
            EndDate = endDate;
            AppartmentsAmount = appartmentsAmount;
            CasualRoomAmount = casualRoomAmount;
            UserId = userId;
            ReservationNumber = reservationNumber;
            Breakfast = breakfast;
            Wifi = wifi;
        }

        public ReserveRoomsEvent() : base()
        {
            HotelId = 1;
            BeginDate = new DateTime(2022, 1, 1).ToUniversalTime();
            EndDate = new DateTime(2022, 1, 1).ToUniversalTime();
            AppartmentsAmount = 0;
            CasualRoomAmount = 0;
            UserId = Guid.NewGuid();
            ReservationNumber = Guid.NewGuid();
            Breakfast = false;
            Wifi = false;
        }
    }
}
