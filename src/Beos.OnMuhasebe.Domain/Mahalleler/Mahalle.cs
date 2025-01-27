﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Beos.OnMuhasebe.Mahalleler;
public class Mahalle : FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public Guid IlceId { get; set; }
    public Guid OzelKod1Id { get; set; }
    public Guid OzelKod2Id { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }


    public Ilce Ilce { get; set; }
    [NotMapped]
    public OzelKod OzelKod1 { get; set; }
    [NotMapped]
    public OzelKod OzelKod2 { get; set; }

    public ICollection<Firma> Firmalar { get; set; }

}
