public class Pessoa
{

    public int Idade { get; set; }

    public string Nome { get; set; }

    public string Documento { get; set; }

    public Pessoa Clone()
    {
        return new Pessoa()
        {
            Nome = this.Nome,
            Idade = this.Idade,
            Documento = this.Documento
        };
    }

}