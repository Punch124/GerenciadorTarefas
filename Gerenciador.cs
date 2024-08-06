namespace GerenciadorTarefas;

public class Gerenciador
{
    public string NomeTarefas {get; set;}
    public string Data {get; set;}
    public string Prioridade {get; set;}

    public Gerenciador(String tarefa, String data, String prioridade) 
    {
        NomeTarefas = tarefa;
        Data = data;
        Prioridade = prioridade;
    }
    public override string ToString()
    {
        return $"Nome: {NomeTarefas}, Data: {Data}, Prioridade: {Prioridade}";
    }
}
