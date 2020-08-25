using System.Threading.Tasks;
using SmartSchool_WebApi.Models;

namespace SmartSchool_WebApi.Data
{
    public class Repository : IRepository
    {
        public void Add<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public Task<Aluno[]> GetAllAlunosAsync(bool includeProfessor)
        {
            throw new System.NotImplementedException();
        }

        public Task<Professor[]> GetAllProfessoresAsync(bool includeAluno)
        {
            throw new System.NotImplementedException();
        }

        public Task<Aluno> GetAlunoAsyncById(int alunoId, bool includeProfessor)
        {
            throw new System.NotImplementedException();
        }

        public Task<Aluno[]> GetAlunosAsyncByDisciplinaId(int disciplinaId, bool includeDisciplina)
        {
            throw new System.NotImplementedException();
        }

        public Task<Professor> GetProfessorAsyncById(int professorId, bool includeAluno)
        {
            throw new System.NotImplementedException();
        }

        public Task<Professor[]> GetProfessoresAsyncByAlunoId(int alunoId, bool includeDisciplina)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }
    }
}