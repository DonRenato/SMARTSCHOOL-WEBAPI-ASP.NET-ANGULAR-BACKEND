namespace SmartSchool_WebApi.Models
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina()
        {
            
        }
        public AlunoDisciplina(int alunoId, int disciplinaId)
        {
            this.alunoId = alunoId;
            this.disciplinaId = disciplinaId;
            

        }
        public int alunoId { get; set; }
        public int disciplinaId { get; set; }
        public Aluno aluno { get; set; }
        public Disciplina disciplina { get; set; }
    }
}