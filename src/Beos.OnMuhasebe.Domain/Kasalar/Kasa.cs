using System.ComponentModel.DataAnnotations.Schema;

namespace Beos.OnMuhasebe.Kasalar;
public class Kasa : FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public Guid OzelKod1Id { get; set; }
    public Guid OzelKod2Id { get; set; }
    public Guid SubeId { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }

    [NotMapped]
    public OzelKod OzelKod1 { get; set; }
    [NotMapped]
    public OzelKod OzelKod2 { get; set; }
    public Sube Sube { get; set; }

    public ICollection<Makbuz> Makbuzlar { get; set; }
    public ICollection<MakbuzHareket> MakbuzHareketler { get; set; }
}
