

namespace etecHoras.Entities
{
    using System;

    namespace SeuProjeto.Entities
    {
        public class AlunoAMS : Aluno
        {
            public int HorasObrigatorias { get; private set; } = 200;

            public AlunoAMS(string nome, int anoMatricula, int horasCurso, string inst)
                : base(nome, anoMatricula, horasCurso, inst)
            {
            }

            public override void ExibirInformacoes()
            {
                base.ExibirInformacoes();
                Console.WriteLine($"Horas obrigatórias: {HorasObrigatorias}");
            }

            public override bool TemHorasObrigatorias()
            {
                return true;
            }
        }
    }
}