namespace SmartSchool_WebApi.Models
{
    public class Professor
    {
        public Professor()
        {
            
        }
        public Professor(int id, string nome, int sobrenome, string teleofone)
        {
            this.id = id;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.teleofone = teleofone;

        }
        public int id { get; set; }
        public string nome { get; set; }
        public int sobrenome { get; set; }
        public string teleofone { get; set; }
    }
}