namespace SmartSchool_WebApi.Models
{
    public class Aluno
    {
        public Aluno()
        {
            
        }
        public Aluno(int id, string nome, string disciplina)
        {
            this.id = id;
            this.nome = nome;
            this.disciplina = disciplina;

        }
        public int id { get; set; }
        public string nome { get; set; }
        public string disciplina { get; set; }
    }
}