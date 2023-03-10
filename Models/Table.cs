//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Crud_madde_halleri.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Table
    {
        public int MaddeID { get; set; }

        
        [Required]  //boş bırakma anlamına gelir.
        [StringLength(10, MinimumLength = 3,ErrorMessage ="adı 3...10 karakter arasında olmalı")]  //karakter uzunlugunu sınırlar.
        public string MaddeAd { get; set; }


        public Nullable<short> Sıcaklık { get; set; }
        public Nullable<short> ErimeNoktası { get; set; }

        [Range(-273,int.MaxValue,ErrorMessage ="-273 den küçük olmamalı")]  //derece aralığını yazdık
        public Nullable<short> KaynamaNoktası { get; set; }

        
        public string HalDurumu { get; set; }
    }
}
