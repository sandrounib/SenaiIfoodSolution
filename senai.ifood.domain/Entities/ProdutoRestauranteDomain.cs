using System;
using System.ComponentModel.DataAnnotations;
using Syste.ComponentModel.DataAnnotations.Schema;
namespace senai.ifood.domain.Entities
{
    public class ProdutoRestauranteDomain : BaseDomain
    {        
        [Required]
        [StringLenght(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(300)]
        public string Descricao { get; set; }

        [Required]
        public Boolean Ativo { get; set; }

        [Required]
        [DateType(DataType.Currency)]
        public decimal Valor { get; set; }
            

        [ForeignKey("RestauranteId")]
        public RestauranteDomain Restaurante { get; set; }
        public int RestauranteId { get; set; }   

        
    }
}