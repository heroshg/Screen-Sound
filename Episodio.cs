class Episodio
{
    private List<string> convidados = new List<string>();

    public Episodio(string titulo, int duracao, int ordem)
    {
        Titulo = titulo;
        Duracao = duracao;
        Ordem = ordem;
    }

    public int Duracao { get; }
    public int Ordem { get; }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";
    public string Titulo { get; set; }

    public void AdicionarConvidados (string convidado)
    {
        convidados.Add (convidado);
    }
}