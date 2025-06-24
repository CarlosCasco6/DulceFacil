﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFácil.Dominio.Modelos.Abstracciones
{
    public interface IRepositorio<T> where T : class
    {
        Task AddAsync(T TEntity); //insertar
        Task UpdateAsync(T Entity);//actualizar
        Task DeleteAsync(int id);//eliminar por ID
        Task<IEnumerable<T>> GetAllAsync();//listar todo
        Task<T> GetByIdAsync(int id);//buscar por ID
    }
}
