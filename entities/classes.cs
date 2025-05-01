namespace Task_Horas.Entities
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int AnoMatricula { get; set; }
        public int HorasCurso { get; set; }
        public int HorasObrigatorias { get; set; }
        public string Curso { get; set; }

        public Aluno(string nome, int anoMatricula, int horasCurso, string curso)
        {
            Nome = nome;
            AnoMatricula = anoMatricula;
            HorasCurso = horasCurso;
            Curso = curso;

            HorasObrigatorias = curso == "ETEC AMS" ? 200 : 0;
        }
    }
}
