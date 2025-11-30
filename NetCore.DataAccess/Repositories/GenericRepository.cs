using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using NetCore.DataAccess.NetCoreContext;
using NetCore.DataAcsess.Abstract;

namespace NetCore.DataAcsess.Repositories;

public class GenericRepository<T>(NetCoreContext _context) : IRepository<T> where T : class
//PRIMARY CONSTRUCTOR:=>
//_context’i her metoda TEKRAR TEKRAR yazmak zorunda kalmıyoruz, çünkü primary constructor onu class’ın tamamına otomatik tanıtıyor.

{
    
    public DbSet<T> Table
    {
        get => _context.Set<T>();
    }
    //**************
    public List<T> GetList()
    {
        return Table.ToList();
    }

    public T GetByFilter(Expression<Func<T, bool>> predicate)
    {
        return Table.Where(predicate).FirstOrDefault(); //filitrelenmiş şekilde tek bir değer döncez
    }

    public T GetById(int id)
    {
        return Table.Find(id);
    }

    public void Create(T entity)
    {
        Table.Add(entity);
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        Table.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var entityDelet = Table.Find(id);
        Table.Remove(entityDelet);
        _context.SaveChanges();
    }

    public int Count()
    {
        return Table.Count();
    }

    public int FiltredCount(Expression<Func<T, bool>> predicate)
    {
        return Table.Where(predicate).Count();//şarta göre sayısını getir
    }

    public List<T> GetFilteredList(Expression<Func<T, bool>> predicate)
    {
        return Table.Where(predicate).ToList();
    }
}
    
