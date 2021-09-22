using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace asp.net_mvc_proje2.Models
{
    public class FormModel
    {
        [Required (ErrorMessage = "Ad Soyad Giriniz")]
        public string AdiSoyadi { get; set; }
        [Required (ErrorMessage = "Boş Bırakılamaz!")]
        [EmailAddress(ErrorMessage = "Email Geçersiz!")]
        public string Eposta { get; set; }
        [Required (ErrorMessage = "Boş Bırakmayınız!")]
        [MaxLength(500,ErrorMessage = "500 karakteri geçmeyin")]
        public string Mesaj { get; set; }
        [Required (ErrorMessage = "Boş Bırakmayınız!")]
        [Range (1000000, 9999999, ErrorMessage = "Telefon Numarası 11 karakterden oluşmalıdır!")]
        public int Telefon { get; set; }

        //eğer kayıt edilecekse ve mail gönderene geri dönüş olacaksa
        //public DateTime Tarih { get; set; }
    }
}