using System.Collections.Generic;
namespace senai.ifood.domain.Entities
{
    public class UsuarioDomain : BaseDomain
    {        
        public string Email { get; set; }
        public string Senha { get; set; } 

        public ICollection<UsuarioPermissaoDomain> UsuarioPermissoes { get; set; } 
        public ICollection<RestauranteDomain> Restaurantes {get;set; }     

        
    }
}