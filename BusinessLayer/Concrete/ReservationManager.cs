using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class ReservationManager : IReservationService
{
    private IReservationDal _reservationDal;

    public ReservationManager(IReservationDal reservationDal)
    {
        _reservationDal=reservationDal;
    }

    public List<Reservation> GetListApprovalreservation(int id)
    {
        return _reservationDal.GetListByFilter(x => x.AppUserId == id&&x.Status=="Onay Bekliyor");
    }

    public void TAdd(Reservation t)
    {
        _reservationDal.Insert(t);
    }

    public void TDelete(Reservation t)
    {
        throw new NotImplementedException();
    }

    public Reservation TGetByID(int id)
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