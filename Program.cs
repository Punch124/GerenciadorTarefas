using System.Collections;
using System.Diagnostics;

namespace GerenciadorTarefas;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Bem vindo ao seu gerenciador de tarefas!");
        Console.WriteLine("Estas são as tarefas:");
        List<Gerenciador> tarefas = new();
        while(true){
            Console.WriteLine("Deseja adicionar alguma tarefa? 1= Sim; 2= Remover tarefa; 3=listar tarefas, 4- sair");
            int decisao = Convert.ToInt32(Console.ReadLine());
            switch (decisao)
            {
               case 1:
                        Console.WriteLine("Escreva o nome da tarefa:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Escreva a data desta tarefa:");
                        string data = Console.ReadLine();
                        Console.WriteLine("Escreva a prioridade desta tarefa:");
                        string prioridade = Console.ReadLine();
                        tarefas.Add(new Gerenciador(name,data,prioridade));
                        Console.WriteLine("tarefa adicionada.");
               break;

               case 2:
                        Console.WriteLine("Digite o nome da tarefa que você deseja remover");
                        string nome = Console.ReadLine();
                        Gerenciador tarefaRemover = tarefas.Find(t=> t.NomeTarefas == nome);
                        if (tarefaRemover == null) 
                        {
                            tarefas.Remove(tarefaRemover);
                            Console.WriteLine("Tarefa removida com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("Tarefa não encontrada.");
                        }

               break;
               case 3:
                        Console.WriteLine("Lista de tarefas:");
                         foreach (var tarefa in tarefas)
                        {
                        Console.WriteLine(tarefa);
                        }
               break;

               case 4:
                        Console.WriteLine("saindo...");
               return;
            }
            Console.WriteLine("pressione enter para continuar");
            Console.ReadLine();
            Console.Clear();
    }   }
}   
