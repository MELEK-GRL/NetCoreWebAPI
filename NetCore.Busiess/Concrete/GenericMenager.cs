using System.Linq.Expressions;
using NetCore.Busiess.Abstract;
using NetCore.DataAcsess.Abstract;

namespace NetCore.Busiess.Concrete;

public class GenericMenager<T>(IRepository<T> _repository) : IGenericService<T> where T : class
{
    
    public List<T> TGetList()
    {
        return _repository.GetList();
    }

    public T TGetByFilter(Expression<Func<T, bool>> predicate)
    {
      return  _repository.GetByFilter(predicate);
    }

    public T TGetById(int id)
    {
        return _repository.GetById(id);
    }

    public void TCreate(T entity)
    {
         _repository.Create(entity);
    }

    public void TUpdate(T entity)
    {
       _repository.Update(entity);
    }

    public void TDelete(int id)
    {
        _repository.Delete(id);
    }

    public int TCount()
    {
        return _repository.Count();
    }

    public int TFiltredCount(Expression<Func<T, bool>> predicate)
    {
        return _repository.FiltredCount(predicate);
    }

    public List<T> TGetFilteredList(Expression<Func<T, bool>> predicate)
    {
        return _repository.GetFilteredList(predicate);
    }
}

