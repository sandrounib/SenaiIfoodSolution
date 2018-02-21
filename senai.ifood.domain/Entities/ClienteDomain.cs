using System;
namespace senai.ifood.domain.Entities
{
    public class ClienteDomain
    {        
        public string  Nome { get; set; }  
        public DateTime DataNascimento { get; set; }   
        public string Sexo { get; set; }
        public UsuarioDomain Usuario { get; set; }
        public int UsuarioId { get; set; }
        
    }
}