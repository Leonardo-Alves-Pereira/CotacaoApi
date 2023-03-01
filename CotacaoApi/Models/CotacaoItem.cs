namespace CotacaoApi.Models;

public class CotacaoItem
{
    public int Id { get; set; }
    public string? Descricao { get; set; }
    public int NumeroItem { get; set; }
    public float Preco { get; set; }
    public float Quantidade { get; set; }
    public string? Marca { get; set; }
    public string? Unidade { get; set; }
}
