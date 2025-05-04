

namespace etecHoras.Entities
{ 

public class Aluno
{
    public string Nome { get; set; }
    public int AnoMatricula { get; set; }
    public int HorasCurso { get; set; }
    public string Inst {  get; set; }

    public Aluno(string nome, int anoMatricula, int horasCurso, string inst)
    {
        Nome = nome;
        AnoMatricula = anoMatricula;
        HorasCurso = horasCurso;
        Inst = inst;

    }

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome} | Ano: {AnoMatricula} | Horas do curso: {HorasCurso} | Instituição: {Inst}");
    }

    public virtual bool TemHorasObrigatorias()
    {
        return false;
    }
}
}
