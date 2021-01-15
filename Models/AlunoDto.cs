using System;

namespace Api.Models
{
    public class InfectadoDto
    {
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Turma { get; set; }
        public int Idade { get; set; }
    }
}