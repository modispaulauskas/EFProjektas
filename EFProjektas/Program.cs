using System;

namespace EFProjektas
{
    class Program
    {
        const string uzduotis =
@"
 ###############################
 ## Naudojant EF6 arba EFCore ##
 ###############################
* I. Duomenų bazės struktūros, data quering ir mutation užduotys * 
Iš pateiktų modelių ir data seedų sukurti duomenų bazę. Esamų modelių ir data seedų modifikuoti negalima. Galima tik sukurti papildomus.
1. Kuriant lenteles atsižvelgti į DB kūrimo principus. Saugomų skaičių tikslumą bei laukelių talpą. 
   Jei šie atributai neaprašyti modeliuose - aprašyti per fluent API.
2. Pateikti data seedai turi būti surašyti į DB jos sukūrimo metu.
3. Sukurtį metodą kuris sudeliotu ryšius tarp profesjos ir mokslo bei išsaugotu DB. Varotojo sąsaja nebūtina.
4. Atsitiktiniu būdu asmenims priskirti 1 profesiją ir išsaugoti DB.
5. Atsitiktiniu būdu asmenims priskirti 1-3 hobių ir išsaugoti DB.
6. Atsitiktiniu būdu asmenims priskirti 2-4 kursus ir išsaugoti DB. Su salyga, kad asmuo negali sudijuoti ilgiau kaip 5 metus.
7. Sukurti lentelę kurioje bus saugomi su asmenimis susiję gyvenimo įvykiai (pvz. pažintys, vestuvės, egzaminai, pasiekimai ar betkas kita) 
   siūloma, bet neprivaloma struktūra: tipas, aprašymas, asmuo, dalyviai, vieta

* II. Duomenų jungimo užduotys * 
Analizuojant išsaugotus DB duomenis:
1. Pateikti kiek kiekvienas asmuo sumokėjo iš viso už mokslus bei bendrabutį. Pateikti kiek kiekvienas asmuo mokėjo už mokslus per mėnesį.
2. Pateikti asmenis dirbančius pagal tai ką mokėsi.
3. Pateikti kiekvieno bendrabučio pajamas per mėnesį.

* III. Business logic realizacijos užduotys * 
1. Pateikti asmenims kurie negyvena bendrabutyje pasiūlymą apsigyventi. Pasiūlyme turi būti norodyta kaina.
   Siūlyti tik tuos bendrabučius kuriuose gyvena tą patį dalyką studijavę studentai. Jei tokių nėra - nesiūlyti.
2. Sukurti ir išsaugoti DB asmens biografiją:
   Pateikiant [amžių], [profesiją], [hobius], [kūno sudėjimą], [ką ir kiek laiko mokėsi], [bendrakursius], [kur gyveno], 
   [kiek mokėjo per mėn už mokslus], [kur gyveno] bei [ar dirba pagal įgytą išsilavinimą].
3. Sukurti mechanizmą kuris naudotojui leistu koreguoti įvestą biografiją ištaisant nerišlią gramatiką. 
   3.1. Tačiau sukurti mechanizmą kuris neleistu koreguoti esminių duomenų (pvz vardo, kiek mokėjo už mokslus ir t.t.).
   3.2. Visiem pakeitimams turi būti realizuotas loginimo mechanizmas, leidžiantis pamatyti kas ir kada buvo keista.
";
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(uzduotis);
            Console.ForegroundColor = ConsoleColor.White;

            //SPRENDIMAS


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-End of program. Press any key-");
            Console.ReadKey();
        }
    }
}
