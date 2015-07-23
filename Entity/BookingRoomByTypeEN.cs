using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity {
    public class BookingRoomByTypeEN : BookingRoomByType {
        public string CustomerName { get; set; }
        public void SetValue(BookingRoomByType aBookingRoomByType){
            this.ID = aBookingRoomByType.ID;
            this.IDCustomer = aBookingRoomByType.IDCustomer;
            this.FromDate = aBookingRoomByType.FromDate;
            this.ToDate = aBookingRoomByType.ToDate;
            this.Suite = aBookingRoomByType.Suite;
            this.Standard = aBookingRoomByType.Standard;
            this.Superior = aBookingRoomByType.Superior;
            this.BookingStatus = aBookingRoomByType.BookingStatus;
        }
    }
}
