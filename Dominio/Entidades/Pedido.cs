﻿using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Pedido
    {
        [Required(ErrorMessage = "Informe seu nome")]
        public string NomeCliente { get; set; }


        [Display(Name = "Cep:")]
        public string Cep { get; set; }


        [Required(ErrorMessage = "Informe seu endereço")]
        [Display(Name = "Endereço:")]
        public string Endereco { get; set; }


        [Display(Name = "Complemento:")]
        public string Complemento { get; set; }


        [Required(ErrorMessage = "Informe sua cidade")]
        [Display(Name = "Cidade:")]
        public string Cidade { get; set; }


        [Required(ErrorMessage = "Informe seu bairro")]
        [Display(Name = "Bairro:")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Informe seu estado")]
        [Display(Name = "Estado:")]
        public string Estado { get; set; }


        [Display(Name = "E-mail:")]
        [Required(ErrorMessage = "Informe seu email")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        public bool EmbrulhaPresente { get; set; }
    }
}
