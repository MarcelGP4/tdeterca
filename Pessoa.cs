public class Pessoa
{
    public static int Contator = 0;
    public string? Nome { get; set; }

   public Pessoa (string nome)
    {
        Nome= nome;
        Contator++;
    } 
}

