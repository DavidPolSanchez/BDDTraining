using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDTraining.Infrastructure.Repository
{
    public class GenericRepository <T> where T : EntityModel
    {
        protected List<T> Entities { get; set; }
        public GenericRepository()
        {
            Entities = new List<T>();
        }

        public T Insert(T entity)
        {
            entity.id = getnewId();
            Entities.Add(entity);
            return entity;
        }

        public int getnewId()
        {
            int lastid = 0;

            foreach(var entity in Entities)
            {
                lastid = lastid > entity.id 
                    ? lastid : entity.id;
            }
            return lastid;
        }
    }

}
