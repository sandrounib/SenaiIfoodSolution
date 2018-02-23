using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using senai.ifood.domain.Contacts;
using senai.ifood.repository.Context;

namespace senai.ifood.repository.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly IFoodContext _dbContext;

        public BaseRepository(IFoodContext ifoodcontext)
        {
            _dbContext = ifoodcontext;
        }


        public int Atualizar(T dados)
        {
            try
            {
                _dbContext.Set<T>().Update(dados);
                return _dbContext.SaveChanges();
            }
            catch (System.Exception ex)
            {
               throw new Exception(ex.Message);
            }
            
        }

        public T BuscarPorId(int id)
        {
            try
            {
                var chavePrimaria = _dbContext.Model.FindEntityType(typeof(T)).FindPrimaryKey().Properties[0];
                return _dbContext.Set<T>().FirstOrDefault(e => EF.Property<int>(e, chavePrimaria.Name) == id);
            }
            catch (System.Exception)
            {
                
                throw;
            }
            throw new System.NotImplementedException();
        }

        public int Deletar(T dados)
        {
            try
            {
                _dbContext.Set<T>().Remove(dados);
                return _dbContext.SaveChanges();
                
            }
            catch (System.Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
            
            throw new System.NotImplementedException();
        }

        public int Inserir(T dados)
        {
            try
            {
                _dbContext.Set<T>().Add(dados);
                return _dbContext.SaveChanges();
            }
            catch (System.Exception ex)
            {
                
                throw new Exception(ex.Message);
            }

            throw new System.NotImplementedException();
        }

        public IEnumerable<T> Listar()
        {
            try
            {
                return _dbContext.Set<T>().ToList();
            }
            catch (System.Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
            throw new System.NotImplementedException();
        }
    }
}