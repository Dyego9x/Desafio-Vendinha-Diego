using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Times.Models{
    public class Time
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string CPF {get; set;}
        public string Descricao {get; set;}
        
        public float Valor {get; set;}
        
        
    }
}