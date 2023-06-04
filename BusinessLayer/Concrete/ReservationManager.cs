using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public Reservation GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListReservationsByFetchConfirmedReservations(int id)
        {
            return _reservationDal.GetListReservationsByFetchConfirmedReservations(id);
        }

        public List<Reservation> GetListReservationsByPastReservations(int id)
        {
            return _reservationDal.GetListReservationsByPastReservations(id);
        }

        public List<Reservation> GetListReservationsByWaitApproval(int id)
        {
          return  _reservationDal.GetListReservationsByWaitApproval(id);
        }

        public void TAdd(Reservation t)
        {
           _reservationDal.Insert(t);
        }

        public void TDelete(Reservation t)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reservation t)
        {
            throw new NotImplementedException();
        }
    }
}
