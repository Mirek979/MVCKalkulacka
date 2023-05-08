using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MVCKalkulacka.Models
{
    public class Kalkulacka
    {
        [Display(Name = "1.číslo" )]
        [Range(1,100, ErrorMessage ="Zadejte prosím číslo od 1 do 100.")]
        public int PrvniCislo { get; set; }
        [Display(Name = "2.číslo")]
        [Range(1, 100, ErrorMessage = "Zadejte prosím číslo od 1 do 100.")]
        public int DruheCislo { get; set; } 
        public double Vysledek { get; private set; }
        [Display(Name = "Operace" )]
        public string Operace { get; set; }

        public List <SelectListItem> MozneOperace { get; private set; }

        public Kalkulacka()
        {
            Operace = "+";
            MozneOperace = new List<SelectListItem>
            {
                new SelectListItem {Text = "Sečti", Value = "+", Selected = true },
                new SelectListItem {Text = "Odečti", Value = "-",},
                new SelectListItem {Text = "Vynásiob", Value = "*", },
                new SelectListItem {Text = "Vyděl", Value = "/", },
            };
        }
        public void VypocitejVysledek()
        {
            Vysledek = Operace switch
            {
                "+" => PrvniCislo + DruheCislo,
                "-" => PrvniCislo - DruheCislo,
                "*" => PrvniCislo * DruheCislo,
                "/" => PrvniCislo / DruheCislo,
                _=> 0

            };
        }

    }
}
