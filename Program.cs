using etecHoras.Entities.SeuProjeto.Entities;
using etecHoras.Entities;

class Program
{
    static void Main(string[] args)
    {
        List<Aluno> alunos = new List<Aluno>();

        // Adicionando alunos
        alunos.Add(new Aluno("Lucas", 2022, 800, "Etec")); // ETEC Técnico
        alunos.Add(new AlunoAMS("Fernanda", 2023, 1000, "AMS")); // ETEC AMS
        alunos.Add(new Aluno("Bruno", 2024, 900, "Etec")); // ETEC Técnico
        alunos.Add(new AlunoAMS("Ricardo", 2025, 1000, "AMS")); // ETEC AMS

        Console.WriteLine("=== TODOS OS ALUNOS ===\n");
        foreach (var aluno in alunos)
        {
            aluno.ExibirInformacoes();
            Console.WriteLine("-----------------------\n");
        }

        Console.WriteLine("=== ALUNOS COM 200H OBRIGATÓRIAS (ETEC AMS) ===\n");
        foreach (var aluno in alunos)
        {
            if (aluno.TemHorasObrigatorias())
            {
                aluno.ExibirInformacoes();
                Console.WriteLine("-----------------------\n");
            }
        }
    }
}
