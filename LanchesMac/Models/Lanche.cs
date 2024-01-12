﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "O nome do lanche deve ser informado.")]
        [Display(Name = "Nome do Lanche")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser informada.")]
        [Display(Name = "Descrição do Lanche")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres.")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no máximo {1} caracteres.")]
        public string DescricaoCurta { get; set;}
        
        [NotMapped]
        public DateTime DataDeCriacao { get; set; }
        [Required(ErrorMessage = "Informe a descrição detalhada do lanche.")]
        [StringLength(200, ErrorMessage = "O tamanho máximo é 200 caracteres")]
        [Display(Name = "Descição detalhada")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe o preço do lanche.")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99.")]
        public decimal Preco {  get; set; }

        [StringLength(200, ErrorMessage = "O {0} deve ter o tamanho máximo de {1} caracteres")]
        [Display(Name = "Caminho da Imagem normal")]
        public string ImagemUrl { get; set; }

        [StringLength(200, ErrorMessage = "O {0} deve ter o tamanho máximo de {1} caracteres")]
        [Display(Name = "Caminho da Imagem miniatura")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public  bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque {  get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
