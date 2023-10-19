namespace ListInsideList;

public class Endereco
{
    public string Logradouro { get; set; }
    public string Numero { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }

    public override string ToString()
    {
        return $"Morada: {Logradouro}, {Numero} - {Bairro}, {Cidade} - {Estado}";
    }
}