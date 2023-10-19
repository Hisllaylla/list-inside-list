namespace ListInsideList;

public class Filho
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Documento { get; set; }

    public override string ToString() // ToString é um método mais intuitivo para retornar os valores da classe
    {
        return $"ID: {Id} | Nome do Filho: {Nome} | Documento: {Documento}";
    }
}