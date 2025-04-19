using System;
using System.Collections.Generic;
using product_management.dto;

namespace product_management.service
{
    public class Store<T> where T : Entity
    {
        protected List<T> list = new List<T>();

        public List<T> List()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }

            return list;
        }

        public T Create(T entity)
        {
            entity.Id = list.Count;
            list.Add(entity);
            return entity;
        }

        public void Update(int id, T entity)
        {
            if (list.Count > id)
            {
                
            }
            list[id] = entity;
        }

        public T Get(int id)
        {
            return list[id];
        }

        public void Delete(int id)
        {
            if (list.Count > id)
            {
                list.RemoveAt(id);
            }
        }

        public List<T> FindByName(string str)
        {
            var result = new List<T>();
            
            foreach (var item in list)
            {
                if (item.Name.Contains(str))
                {
                    result.Add(item);
                    Console.WriteLine($"Found: {item}");
                }
            }

            return result;
        }
    }
}