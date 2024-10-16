namespace Matheush;

public class Folha
{
    public int folhaId { get; set; }
    public decimal valor { get; set; }
    public int quantidade { get; set; }
    public int mes { get; set; }
    public int ano { get; set; }
    public decimal  SalarioBruto { get; set; }
    public decimal  impostoIrrf { get; set; }
    public decimal  impostoInss { get; set; }
    public decimal  impostoFgts { get; set; }
    public decimal SalarioLiquido { get; set; }
    public Funcionario? funcionario { get; set; }
}
