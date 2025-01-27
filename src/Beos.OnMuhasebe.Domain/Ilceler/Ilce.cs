using System.ComponentModel.DataAnnotations.Schema;

namespace Beos.OnMuhasebe.Ilceler;
public class Ilce : FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public Guid IlId { get; set; }
    public Guid OzelKod1Id { get; set; }
    public Guid OzelKod2Id { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }

    public Il Il { get; set; }
    [NotMapped]
    public OzelKod OzelKod1 { get; set; }
    [NotMapped]
    public OzelKod OzelKod2 { get; set; }

    public ICollection<Mahalle> Mahalleler { get; set; }
    public ICollection<Firma> Firmalar { get; set; }
}
