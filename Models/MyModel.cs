using System;
using System.ComponentModel.DataAnnotations;

namespace FlashCard.Models
{
    public class Kanji
    {
        [Key]
        public int CardId { get; set;}

        [Required]
        [Display(Name = "Translated Word")]
        public string DisplayWord { get; set; }
        [Required]
        [Display(Name = "Kanji Code")]
        public string DisplayKanji { get; set; }
        [Required]
        [Display(Name = "Japanese Pronunciation")]
        public string PronounceKanji { get; set; }
        [Required]
        [Display(Name = "Kana")]

        public string Kana { get; set; }
    }
}