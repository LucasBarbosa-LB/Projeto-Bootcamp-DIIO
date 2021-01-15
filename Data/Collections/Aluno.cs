using System;

namespace Api.Data.Collections
{
    public class Infectado
    {
        public Infectado(DateTime dataNascimento, string sexo, int idade, string turma)
        {
            this.DataNascimento = dataNascimento;
            this.Sexo = sexo;
            this.Turma = turma;
            this.Idade = idade;

        }

        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Turma { get; set; }
        public int Idade { get; set; }
        
    }
}