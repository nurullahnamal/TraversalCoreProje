namespace BusinessLayer.Abstract.AbstactUow;

public interface IGenericUowService<T>
{
    void TInsert(T t);
    void TUpdate(T t);
    void TMultiUpdate(List<T> t);
    T TGetByID(int id);
}