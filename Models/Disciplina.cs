using System.Collections.Generic;

namespace SmartSchool_WebApi.Models
{
    public class Disciplina
    {
        public Disciplina()
        {

        }
        public Disciplina(int id, string nome, int professorId)
        {
            this.id = id;
            this.nome = nome;
            this.professorId = professorId;
        }
        public int id { get; set; }
        public string nome { get; set; }
        public int professorId { get; set; }
        public Professor professor { get; set; }
        public IEnumerable<AlunoDisciplina> alunosDisciplinas { get; set; }
    }
}