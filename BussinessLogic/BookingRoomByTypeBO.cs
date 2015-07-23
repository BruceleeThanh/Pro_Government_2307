using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using DataAccess;
using Entity;


namespace BussinessLogic {
    public partial class BookingRoomByTypeBO {
        DatabaseDA aDatabaseDA = new DatabaseDA();

        // Select All
        public List<BookingRoomByType> Select_All () {
            try {
                return aDatabaseDA.BookingRoomByType.OrderBy(b => b.ID).ToList<BookingRoomByType>();
            }
            catch (Exception ex) {
                throw new Exception("BookingRoomByTypeBO.Select_All" + ex.ToString());
            }
        }

        // Select By ID
        public BookingRoomByType Select_ByID (int ID) {
            try {
                return aDatabaseDA.BookingRoomByType.Where(b => b.ID == ID).FirstOrDefault();
            }
            catch (Exception ex) {
                throw new Exception("BookingRoomByTypeBO.Select_ByID" + ex.ToString());
            }
        }

        // Select By IDCustomer
        public List<BookingRoomByType> Select_ByIDCustomer (int IDCustomer) {
            try {
                return aDatabaseDA.BookingRoomByType.Where(b => b.IDCustomer == IDCustomer).ToList<BookingRoomByType>();
            }
            catch (Exception ex) {
                throw new Exception("BookingRoomByTypeBO.Select_ByIDCustomer" + ex.ToString());
            }
        }

        // Select By BookingStatus
        public List<BookingRoomByType> Select_ByStatus (bool BookingStatus) {
            try {
                return aDatabaseDA.BookingRoomByType.Where(b => b.BookingStatus == BookingStatus).ToList<BookingRoomByType>();
            }
            catch (Exception ex) {
                throw new Exception("BookingRoomByTypeBO.Select_ByStatus" + ex.ToString());
            }
        }

        // Select amount of available room follow room type
        public sp_Room_CountAvailableRooms_ByType_ByTime_ByLang_Result Select_CountAvailableRoomType (DateTime Start, DateTime End, int IDLang) {
            try {
                return aDatabaseDA.sp_Room_CountAvailableRooms_ByType_ByTime_ByLang(Start, End, IDLang).FirstOrDefault();
            }
            catch (Exception ex) {
                throw new Exception("BookingRoomByTypeBO.Select_AmountAvailableRoomType" + ex.ToString());
            }
        }

        // Update
        public bool Update (BookingRoomByType aBookingRoomByType) {
            try {
                aDatabaseDA.BookingRoomByType.AddOrUpdate(aBookingRoomByType);
                aDatabaseDA.SaveChanges();
                return true;
                
            }
            catch (Exception ex) {
                return false;
                throw new Exception("BookingRoomByTypeBO.Update" + ex.ToString());
            }
        }

        // Delete
        public bool Delete (int ID) {
            try {
                BookingRoomByType aBookingRoomByType = new BookingRoomByType();
                aBookingRoomByType = this.Select_ByID(ID);
                aDatabaseDA.BookingRoomByType.Remove(aBookingRoomByType);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw new Exception("BookingRoomByTypeBO.Delete" + ex.ToString());
            }
        }

        public bool NewBookingRoomByType (BookingRoomByTypeEN aBookingRoomByTypeEN) {
            try{
                BookingRoomByType aNewBooking = new BookingRoomByType();
                int IDCustomer = 0;

                #region Them moi khach hang khi khach hang chua co
                if (aBookingRoomByTypeEN.IDCustomer > 0) {
                    IDCustomer = aBookingRoomByTypeEN.IDCustomer;
                }
                else {
                    CustomersBO aCustomersBO = new CustomersBO();
                    Customers aCustomers = new Customers();
                    if (aBookingRoomByTypeEN.CustomerName.Length > 50) {
                        aCustomers.Name = aBookingRoomByTypeEN.CustomerName.Substring(0, 50);
                    }
                    else {
                        aCustomers.Name = aBookingRoomByTypeEN.CustomerName;
                    }
                    IDCustomer = aCustomersBO.Insert(aCustomers);
                }
                #endregion

                aNewBooking.IDCustomer = IDCustomer;
                aNewBooking.FromDate = aBookingRoomByTypeEN.FromDate;
                aNewBooking.ToDate = aBookingRoomByTypeEN.ToDate;
                aNewBooking.Suite = aBookingRoomByTypeEN.Suite;
                aNewBooking.Superior = aBookingRoomByTypeEN.Superior;
                aNewBooking.Standard = aBookingRoomByTypeEN.Standard;
                aNewBooking.BookingStatus = aBookingRoomByTypeEN.BookingStatus;

                aDatabaseDA.BookingRoomByType.Add(aNewBooking);
                aDatabaseDA.SaveChanges();
                return true;
            }
            catch(Exception ex){
                return false;
                throw new Exception("BookingRoomByTypeBO.NewBookingRoomByType"+ex.ToString());
            }
        }
    }
}
