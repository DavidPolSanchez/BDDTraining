using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDTraining.Infrastructure.Repository
{
    public class GenericRepository <T> where T : EntityModel
    {
        protected 
        public GenericRepository()
        {
            Entitites = new List<T>();
        }

        protected List<T> Entitites { }


        public T insert (T entity)
        {
            entity.Id = getnewId();
            Entitites.Add(entity);
        }


        public int getnewId()
        {
            int lastid = 0;
            foreach(var  entity in Entitites)
        }
    }

}
