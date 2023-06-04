using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        List<Reservation> GetListReservationsByFetchConfirmedReservations(int id);
        List<Reservation> GetListReservationsByPastReservations(int id);
        List<Reservation> GetListReservationsByWaitApproval(int id);
    }
}
