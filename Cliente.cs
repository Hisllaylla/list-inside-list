namespace ListInsideList;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Documento { get; set; }
    public string Profissao { get; set; }
    public string EstadoCivil { get; set; }
    public List<Filho>? ListaFilho { get; set; }
    public List<Endereco>? ListaEndereco { get; set; }

    public override string ToString()
    {
        return $"ID: {Id} | Nome do Cliente: {Nome} | Documento: {Documento} | Estado Civil: {EstadoCivil} | Profissão: {Profissao}";
    }
}