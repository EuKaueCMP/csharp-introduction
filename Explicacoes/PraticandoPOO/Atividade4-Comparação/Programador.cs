namespace Atividade4_Comparação
{
    public class Programador : Funcionario, ITrabalhador
    {
        public override void Trabalhar() => Console.WriteLine($"{Nome} esta programando...");        

        public void ExecultarTarefa() => Console.WriteLine($"{Nome} concluiu tarefa");
    }
}