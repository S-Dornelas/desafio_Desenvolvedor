﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp_Desafio_BackEnd.Models
{
    [Serializable]
    public class Chamado
    {
        public static readonly Chamado Empty;

        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "O Assunto é obrigatório")]
        public string Assunto { get; set; }

        [Required(ErrorMessage = "O Solicitante é obrigatório")]
        public string Solicitante { get; set; }

        public int IdDepartamento { get; set; }
        public string Departamento { get; set; }

        public DateTime DataAbertura { get; set; }
    }
}
