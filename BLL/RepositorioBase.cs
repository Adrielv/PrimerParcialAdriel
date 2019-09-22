using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RepositorioBase<T> : IDisposable, IRepositorio<T> where T : class
    {
        internal Contexto contexto;
        public RepositorioBase()
        {
            contexto = new Contexto();
        }

        public virtual void Dispose()
        {
            contexto.Dispose();
        }
        public virtual bool Guardar(T entity)
        {
            bool paso = false;

            try
            {
                if (contexto.Set<T>().Add(entity) != null)

                    paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            return paso;

        }
        public virtual bool Modificar(T entity)
        {
            bool paso = false;

            try
            {
                contexto.Entry(entity).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            return paso;

        }

        public virtual T Buscar(int id)
        {
            T entity;

            try
            {
                entity = contexto.Set<T>().Find(id);

            }
            catch (Exception)
            {
                throw;
            }
            return entity;
        }
        public virtual bool Eliminar(int id)
        {
            T entity;
            bool paso = false;
            try
            {
                entity = contexto.Set<T>().Find(id);
                contexto.Set<T>().Remove(entity);
                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public virtual List<T> GetList(Expression<Func<T, bool>> expression)
        {
            List<T> list = new List<T>();

            try
            {
                list = contexto.Set<T>().Where(expression).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return list;

        }
    }
}
