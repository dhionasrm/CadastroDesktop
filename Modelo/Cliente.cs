namespace CadastroDesktop.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        public int ID { get; set; }

        [StringLength(150)]
        public string Nome { get; set; }

        [StringLength(15)]
        public string CpfCnpj { get; set; }

        [StringLength(15)]
        public string Cep { get; set; }

        public decimal? Limite { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(10)]
        public string Senha { get; set; }

        public DateTime? DataCadastro { get; set; }

        public bool? Ativo { get; set; }

        public bool? Importado { get; set; }

        [StringLength(50)]
        public string Telefone { get; set; }
    }
}
