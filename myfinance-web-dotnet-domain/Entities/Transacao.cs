
using myfinance_web_dotnet_domain.Entities.Base;

namespace myfinance_web_dotnet_domain.Entities;

public class Transacao : EntityBase
{
    public string Historico { get; set; }
    public DateTime DataTransacao { get; set; }
    public decimal valor { get; set; }
    public int PlanoContaId { get; set; }
    public PlanoConta planoConta { get; set; }
}
