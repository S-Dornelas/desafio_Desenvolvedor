﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace WebApp_Desafio_FrontEnd.ViewModels
{
    [DataContract]
    public class DepartamentoViewModel
    {
        [Display(Name = "ID")]
        [DataMember(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Descricao")]
        [DataMember(Name = "Descricao")]
        [StringLength(20, MinimumLength = 8)]
        public string Descricao { get; set; }

    }
}
