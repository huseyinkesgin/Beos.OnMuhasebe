using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beos.OnMuhasebe.Firmalar;
public class Firma : AuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public string FaturaUnvan { get; set; }
    public string VergiDairesi { get; set; }
    public string VergiNo { get; set; }
    public string? Telefon { get; set; }
    public string? Eposta { get; set; }
    public Guid IlId { get; set; }
    public Guid IlceId { get; set; }
    public Guid MahalleId { get; set; }
    public string? Adres { get; set; }
    public string? MersisNo { get; set; }
    public string? KepAdresi { get; set; }
    public string? WebSite { get; set; }
    public Guid OzelKod1Id { get; set; }
    public Guid OzelKod2Id { get; set; }
    public string? Aciklama { get; set; }
    public bool Durum { get; set; }

    public Il Il { get; set; }
    public Ilce Ilce { get; set; }
    public Mahalle Mahalle { get; set; }

    public OzelKod OzelKod1 { get; set; }
    public OzelKod OzelKod2 { get; set; }

}
