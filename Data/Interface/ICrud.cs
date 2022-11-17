using Domain.Negocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interface
{
    public interface ICrud<T>
    {
        public void Insert(T obj);
        public bool Update(T obj);
        public void Delete(T id);
        public List<T> Get();
    }
}
