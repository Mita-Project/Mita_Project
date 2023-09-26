﻿using Project.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Manager_Services.Abstracts
{
    public interface IManager<T> where T : class, IEntity
    {
        // List Commands
        List<T> GetAll();
        List<T> GetActives();
        List<T> GetPassives();
        List<T> GetModifieds();

        // Modify Commands
        void Add(T item);
        void AddRange(List<T> list);
        void Delete(T item);
        void DeleteRange(List<T> list);
        void Update(T item);
        void UpdateRange(List<T> list);
        string Destroy(T item);
        string DestroyRange(List<T> list);
        string DestroyRange_Passive(List<T> list);


        // Linq Commands
        List<T> Where(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T, bool>> exp);
        object Select(Expression<Func<T, bool>> exp);
        IQueryable<X> Select<X>(Expression<Func<T, X>> exp);

        // Find Command
        T Find(int id);

        // Last Datas
        List<T> GetLastDatas(int count);

        // First Datas
        List<T> GetFirstDatas(int count);
    }
}
