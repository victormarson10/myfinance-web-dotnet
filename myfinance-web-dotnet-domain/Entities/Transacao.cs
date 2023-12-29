namespace myfinance_web_dotnet_domain.Entities;

public class Transacao
{
    public int? Id { get; set; }
    public string Historico { get; set; }
    public string DateTime { get; set; }
    public decimal valor { get; set; }
    public int PlanoContaId { get; set; }
    public PlanoConta planoConta { get; set; } 
    
}
