using System.Linq.Expressions;

namespace NetCore.DataAcsess.Abstract;

public interface IRepositroy<T> where T : class
{
    List<T> GetList();
    T GetByFilter(Expression<Func<T, bool>> predicate);
    T GetById(int id);
    void Create(T entity);
    void Update(T entity);
    void Delete(int id );
    int Count();
    int FiltredCount(Expression<Func<T, bool>> predicate);
    List<T> GetFilteredList(Expression<Func<T, bool>> predicate);//predicate:şartlı
}

