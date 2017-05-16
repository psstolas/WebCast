using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebCast.Models
{
    public class OscaresInicializer: DropCreateDatabaseIfModelChanges<Oscares>
    {
        protected override void Seed(Oscares context)
        {
            base.Seed(context);

            Filme f = new Filme();
            f.Nome = "Stars Wars";
            f.Categoria = "Ficção Cientifica";
            f.DataLançamento = Convert.ToDateTime("10/12/2005");
            f.Realizador = "JJ Abrams";

            context.Filmes.Add(f);
            context.SaveChanges();

            Actor act = new Actor();
            act.Nome = "Daisy Ridley";
            act.Nacionalidade = "USA";
            act.DataNascimento = Convert.ToDateTime("01/10/1990");
            act.Filme = f;

            context.Actores.Add(act);
            context.SaveChanges();

        }
    }
}