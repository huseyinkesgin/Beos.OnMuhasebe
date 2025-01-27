namespace Beos.OnMuhasebe.Iller;
public class Il : FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public Guid OzelKod1Id { get; set; }
    public Guid OzelKod2Id { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }

    public OzelKod OzelKod1 { get; set; }
    public OzelKod OzelKod2 { get; set; }

    public ICollection<Ilce> Ilceler { get; set; }

    public ICollection<Firma> Firmalar { get; set; }
}
