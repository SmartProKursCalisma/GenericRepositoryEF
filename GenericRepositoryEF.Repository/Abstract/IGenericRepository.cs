using GenericRepositoryEF.Entities.Entities;

namespace GenericRepositoryEF.Repository.Abstract
{
    public interface IGenericRepository<T> where T: class,IBaseEntity,new()
    {
        //CRUD
        //Interfaceler sadece metotların  imzalarını tutar ve kendisini implement eden sınıflara bu metotları implement etmesini zorunlu kılar.
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
