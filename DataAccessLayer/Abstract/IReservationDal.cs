using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReservationDal : IGenericDal<Reservation>
    {
        List<Reservation> GetListReservationsByWaitApproval(int id);
        List<Reservation> GetListReservationsByFetchConfirmedReservations(int id);
        List<Reservation> GetListReservationsByPastReservations(int id);
    }
}
