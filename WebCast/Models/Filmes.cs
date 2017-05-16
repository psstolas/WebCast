using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace WebCast.Models
{
    public class Filme
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        [DisplayName("Data de Lançamento")]
        [DataType(DataType.DateTime)]
        public DateTime DataLançamento { get; set; }
        public string Realizador { get; set; }
        public string Categoria { get; set; }

        public virtual ICollection<Actor> Actores { get; set; }
    }
    public class Actor
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        [DisplayName("Data de Nascimento")]
        [DataType(DataType.DateTime)]
        public DateTime DataNascimento { get; set; }
        public string Nacionalidade { get; set; }
        public Filme Filme { get; set; }



    }
}