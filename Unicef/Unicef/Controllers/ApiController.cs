using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Unicef.Models;

namespace Unicef.Controllers
{

    public class ApiController : Controller
    {
        Query query;

        public ApiController()
        {
            this.query = new Query();

            Form form = new Form();
            Quiz quiz = new Quiz();

            Question question1 = new Question { Description = "Kérjük, hogy 1-től 5-ig (ahol az 1-es a legrosszabb és az 5-ös a legjobb) értékeld", Form = form, Answers = new List<Answer> { new Answer() { Description = "az UNICEF Ébresztő - órát", Value = 5 }, new Answer { Description = "az UNICEF előadópárt", Value = 3 }, new Answer { Description = "mennyire érezted hasznosnak ezt a 90 percet", Value = 4 } } };

            Question question2 = new Question { Description = "Beszéltél már valakivel vagy valahol a gyerekjogokról? Ha igen, kivel-hol?", Form = form, Answers = new List<Answer> { new Answer { Description = "iskolában", Value = 1 }, new Answer { Description = "otthon szülővel", Value = 0 }, new Answer { Description = "családban", Value = 0 }, new Answer { Description = "baráttal", Value = 0 }, new Answer { Description = "UNICEF-től hallottam róla", Value = 0 }, new Answer { Description = "interneten olvastam róla", Value = 0 }, new Answer { Description = "TV-ben hallottam", Value = 0 }, new Answer { Description = "egyéb", Value = 0 }, new Answer { Description = "TV-ben hallottam", Value = 0 } } };

            Question question3 = new Question { Description = "Mi volt a leghasznosabb abból, amit az Ébresztő-órán hallottál?", Form = form, Answers = new List<Answer> { new Answer { Description = "gyermekjogok", Value = 1 }, new Answer { Description = "szegény gyerekek helyzete a világban", Value = 1 }, new Answer { Description = "UNICEF munkája", Value = 1 }, new Answer { Description = "internetes zaklatás", Value = 1 }, new Answer { Description = "segítségnyújtás", Value = 1 }, new Answer { Description = "játék", Value = 1 }, new Answer { Description = "film", Value = 1 }, new Answer { Description = "minden", Value = 1 }, new Answer { Description = "semmi", Value = 1 } } };

            Question question4 = new Question { Description = "Az Ébresztő-óra melyik része, melyik játék tetszett a legjobban?", Form = form, Answers = new List<Answer> { new Answer { Description = "gyermekjogok", Value = 1 }, new Answer { Description = "szegény gyerekek helyzete a világban", Value = 1 }, new Answer { Description = "UNICEF munkája", Value = 1 }, new Answer { Description = "internetes zaklatás", Value = 1 }, new Answer { Description = "segítségnyújtás", Value = 1 }, new Answer { Description = "játék", Value = 1 }, new Answer { Description = "film", Value = 1 }, new Answer { Description = "minden", Value = 1 }, new Answer { Description = "semmi", Value = 1 } } };

            Question question5 = new Question { Description = "Miről lett volna jó még többet beszélgetni?", Form = form, Answers = new List<Answer> { new Answer { Description = "gyermekjogok", Value = 1 }, new Answer { Description = "szegény gyerekek helyzete a világban", Value = 1 }, new Answer { Description = "UNICEF munkája", Value = 1 }, new Answer { Description = "internetes zaklatás", Value = 1 }, new Answer { Description = "segítségnyújtás", Value = 1 }, new Answer { Description = "játék", Value = 1 }, new Answer { Description = "film", Value = 1 }, new Answer { Description = "minden", Value = 1 }, new Answer { Description = "semmi", Value = 1 } } };

            Question question6 = new Question { Description = "Mi az, amiről túl sokat beszéltünk, vagy ami kevésbé tetszett? ", Form = form, Answers = new List<Answer> { new Answer { Description = "gyermekjogok", Value = 1 }, new Answer { Description = "szegény gyerekek helyzete a világban", Value = 1 }, new Answer { Description = "UNICEF munkája", Value = 1 }, new Answer { Description = "internetes zaklatás", Value = 1 }, new Answer { Description = "segítségnyújtás", Value = 1 }, new Answer { Description = "játék", Value = 1 }, new Answer { Description = "film", Value = 1 }, new Answer { Description = "minden", Value = 1 }, new Answer { Description = "semmi", Value = 1 } } };

            Question question7 = new Question { Description = "A gyermekek jogainak gyűjteményét az ENSZ Gyermekjogi egyezménye tartalmazza.  De mit jelentenek a gyermekjogok?", Quiz = quiz, Answers = new List<Answer> { new Answer { Description = "Néhány szabályt arról, hogy milyen fantasztikusak a gyerekek!", Value = 1 }, new Answer { Description = "Néhány szabályt arról, hogy a gyerekeknek mindenhez joguk van.", Value = 1 }, new Answer { Description = "Néhány szabályt arról, hogyan kellene a gyerekekkel bánni.", Value = 1 } } };

            Question question8 = new Question { Description = "Miért kell, hogy a gyerekeknek külön jogaik legyenek?", Quiz = quiz, Answers = new List<Answer> { new Answer { Description = "Mert a gyerekek túl mohók.", Value = 1 }, new Answer { Description = "Nincsenek is külön jogai a gyerekeknek.", Value = 1 }, new Answer { Description = "Mert a gyerekeket külön védelem és gondoskodás illeti meg.", Value = 1 } } };

            Question question9 = new Question { Description = "Az ENSZ speciális, a gyermekek jogaival és jóllétével foglalkozó szervezete az UNICEF. Mit tesz az UNICEF a gyerekek jogaiért?", Quiz = quiz, Answers = new List<Answer> { new Answer { Description = "Megbünteti azokat, akik gyerekeket bántanak.", Value = 1 }, new Answer { Description = "Biztosítja, hogy az országokban érvényesüljenek a gyerekjogok.", Value = 1 }, new Answer { Description = "Biztosítja, hogy az ENSZ Gyermekjogi egyezménye szépen és tisztán tartva ki legyen állítva egy genfi múzeumban.", Value = 1 } } };

            Question question10 = new Question { Description = "Miért fontos, hogy tudd, milyen jogaid vannak?", Quiz = quiz, Answers = new List<Answer> { new Answer { Description = "Azért, hogy jó osztályzatot kapjak a suliban.", Value = 1 }, new Answer { Description = "Azért, hogy tudjam, hogyan kellene velem bánni.", Value = 1 }, new Answer { Description = "Azért, hogy dicsekedhessek a barátaim előtt.", Value = 1 } } };

            Question question11 = new Question { Description = "Pippa szülei elváltak, és ő a mamájával él. Apukáját nem láthatja, csak havonta egyszer, de ő szeretne többször találkozni vele. Van joga Pippának kérni ezt?", Quiz = quiz, Answers = new List<Answer> { new Answer { Description = "Nem. Pippa még gyerek. Nem szólhat bele a felnőttek dolgába.", Value = 1 }, new Answer { Description = "Igen, minden gyereknek figyelembe kell venni a véleményét az őt érintő döntésekben.", Value = 1 }, new Answer { Description = "Persze, Pippa dönti el, hogy mikor és hogyan akar az apukájával találkozni.", Value = 1 } } };

            Question question12 = new Question { Description = "Max 10 éves, és nem nagyon szokta megcsinálni a házi feladatát. Azt gondolja, hogy buta ahhoz, hogy egyedül megválaszolja a kérdéseket. Tud valaki segíteni neki?", Quiz = quiz, Answers = new List<Answer> { new Answer { Description = "Nem. Maxnak keményebben kell dolgoznia. Ez csak rajta múlik.", Value = 1 }, new Answer { Description = "Maxnak joga van a tanuláshoz, és hogy a tanárai, szülei és más felnőttek segítsék őt abban, hogy jól teljesítsen az iskolában.", Value = 1 }, new Answer { Description = "Maxot jól el kellene verni.", Value = 1 } } };

            Question question13 = new Question { Description = "Franciskát és testvérét a szülei mindig megverik otthon, ha valami rosszat csinál. Megtehetik ezt?", Quiz = quiz, Answers = new List<Answer> { new Answer { Description = "Nem, a gyerekeket egyáltalán nem szabad megverni.", Value = 1 }, new Answer { Description = "Igen, egy szülő bármit megtehet.", Value = 1 }, new Answer { Description = "Csak kicsit verhetik meg, nagyon – például úgy, hogy nyoma maradjon, nem.", Value = 1 } } };

            form.Questions = new List<Question> { question1, question2, question3, question4, question5, question6 };

            quiz.Questions = new List<Question> { question7, question8, question9, question10, question11, question12, question13 };
            query.Form = form;
            query.Quiz = quiz;
        }

        [HttpGet("showquiz")]
        public IActionResult ShowQuiz()
        {
            return Ok(query);
        }

        [HttpPost("postquiz")]
        public IActionResult PostQuiz([FromForm] int ebreszto)
        {
            Form form2 = new Form();
            Quiz quiz2 = new Quiz();

            Question question1 = new Question { Description = "Kérjük, hogy 1-től 5-ig (ahol az 1-es a legrosszabb és az 5-ös a legjobb) értékeld", Form = form2, Answers = new List<Answer> { new Answer() { Description = "az UNICEF Ébresztő - órát", Value = ebreszto }, new Answer { Description = "az UNICEF előadópárt", Value = 3 }, new Answer { Description = "mennyire érezted hasznosnak ezt a 90 percet", Value = 4 } } };

            Question question2 = new Question { Description = "Beszéltél már valakivel vagy valahol a gyerekjogokról? Ha igen, kivel-hol?", Form = form2, Answers = new List<Answer> { new Answer { Description = "iskolában", Value = 1 }, new Answer { Description = "otthon szülővel", Value = 0 }, new Answer { Description = "családban", Value = 0 }, new Answer { Description = "baráttal", Value = 0 }, new Answer { Description = "UNICEF-től hallottam róla", Value = 0 }, new Answer { Description = "interneten olvastam róla", Value = 0 }, new Answer { Description = "TV-ben hallottam", Value = 0 }, new Answer { Description = "egyéb", Value = 0 }, new Answer { Description = "TV-ben hallottam", Value = 0 } } };

            Question question3 = new Question { Description = "Mi volt a leghasznosabb abból, amit az Ébresztő-órán hallottál?", Form = form2, Answers = new List<Answer> { new Answer { Description = "gyermekjogok", Value = 1 }, new Answer { Description = "szegény gyerekek helyzete a világban", Value = 1 }, new Answer { Description = "UNICEF munkája", Value = 1 }, new Answer { Description = "internetes zaklatás", Value = 1 }, new Answer { Description = "segítségnyújtás", Value = 1 }, new Answer { Description = "játék", Value = 1 }, new Answer { Description = "film", Value = 1 }, new Answer { Description = "minden", Value = 1 }, new Answer { Description = "semmi", Value = 1 } } };

            Question question4 = new Question { Description = "Az Ébresztő-óra melyik része, melyik játék tetszett a legjobban?", Form = form2, Answers = new List<Answer> { new Answer { Description = "gyermekjogok", Value = 1 }, new Answer { Description = "szegény gyerekek helyzete a világban", Value = 1 }, new Answer { Description = "UNICEF munkája", Value = 1 }, new Answer { Description = "internetes zaklatás", Value = 1 }, new Answer { Description = "segítségnyújtás", Value = 1 }, new Answer { Description = "játék", Value = 1 }, new Answer { Description = "film", Value = 1 }, new Answer { Description = "minden", Value = 1 }, new Answer { Description = "semmi", Value = 1 } } };

            Question question5 = new Question { Description = "Miről lett volna jó még többet beszélgetni?", Form = form2, Answers = new List<Answer> { new Answer { Description = "gyermekjogok", Value = 1 }, new Answer { Description = "szegény gyerekek helyzete a világban", Value = 1 }, new Answer { Description = "UNICEF munkája", Value = 1 }, new Answer { Description = "internetes zaklatás", Value = 1 }, new Answer { Description = "segítségnyújtás", Value = 1 }, new Answer { Description = "játék", Value = 1 }, new Answer { Description = "film", Value = 1 }, new Answer { Description = "minden", Value = 1 }, new Answer { Description = "semmi", Value = 1 } } };

            Question question6 = new Question { Description = "Mi az, amiről túl sokat beszéltünk, vagy ami kevésbé tetszett? ", Form = form2, Answers = new List<Answer> { new Answer { Description = "gyermekjogok", Value = 1 }, new Answer { Description = "szegény gyerekek helyzete a világban", Value = 1 }, new Answer { Description = "UNICEF munkája", Value = 1 }, new Answer { Description = "internetes zaklatás", Value = 1 }, new Answer { Description = "segítségnyújtás", Value = 1 }, new Answer { Description = "játék", Value = 1 }, new Answer { Description = "film", Value = 1 }, new Answer { Description = "minden", Value = 1 }, new Answer { Description = "semmi", Value = 1 } } };

            Question question7 = new Question { Description = "A gyermekek jogainak gyűjteményét az ENSZ Gyermekjogi egyezménye tartalmazza.  De mit jelentenek a gyermekjogok?", Quiz = quiz2, Answers = new List<Answer> { new Answer { Description = "Néhány szabályt arról, hogy milyen fantasztikusak a gyerekek!", Value = 1 }, new Answer { Description = "Néhány szabályt arról, hogy a gyerekeknek mindenhez joguk van.", Value = 1 }, new Answer { Description = "Néhány szabályt arról, hogyan kellene a gyerekekkel bánni.", Value = 1 } } };

            Question question8 = new Question { Description = "Miért kell, hogy a gyerekeknek külön jogaik legyenek?", Quiz = quiz2, Answers = new List<Answer> { new Answer { Description = "Mert a gyerekek túl mohók.", Value = 1 }, new Answer { Description = "Nincsenek is külön jogai a gyerekeknek.", Value = 1 }, new Answer { Description = "Mert a gyerekeket külön védelem és gondoskodás illeti meg.", Value = 1 } } };

            Question question9 = new Question { Description = "Az ENSZ speciális, a gyermekek jogaival és jóllétével foglalkozó szervezete az UNICEF. Mit tesz az UNICEF a gyerekek jogaiért?", Quiz = quiz2, Answers = new List<Answer> { new Answer { Description = "Megbünteti azokat, akik gyerekeket bántanak.", Value = 1 }, new Answer { Description = "Biztosítja, hogy az országokban érvényesüljenek a gyerekjogok.", Value = 1 }, new Answer { Description = "Biztosítja, hogy az ENSZ Gyermekjogi egyezménye szépen és tisztán tartva ki legyen állítva egy genfi múzeumban.", Value = 1 } } };

            Question question10 = new Question { Description = "Miért fontos, hogy tudd, milyen jogaid vannak?", Quiz = quiz2, Answers = new List<Answer> { new Answer { Description = "Azért, hogy jó osztályzatot kapjak a suliban.", Value = 1 }, new Answer { Description = "Azért, hogy tudjam, hogyan kellene velem bánni.", Value = 1 }, new Answer { Description = "Azért, hogy dicsekedhessek a barátaim előtt.", Value = 1 } } };

            Question question11 = new Question { Description = "Pippa szülei elváltak, és ő a mamájával él. Apukáját nem láthatja, csak havonta egyszer, de ő szeretne többször találkozni vele. Van joga Pippának kérni ezt?", Quiz = quiz2, Answers = new List<Answer> { new Answer { Description = "Nem. Pippa még gyerek. Nem szólhat bele a felnőttek dolgába.", Value = 1 }, new Answer { Description = "Igen, minden gyereknek figyelembe kell venni a véleményét az őt érintő döntésekben.", Value = 1 }, new Answer { Description = "Persze, Pippa dönti el, hogy mikor és hogyan akar az apukájával találkozni.", Value = 1 } } };

            Question question12 = new Question { Description = "Max 10 éves, és nem nagyon szokta megcsinálni a házi feladatát. Azt gondolja, hogy buta ahhoz, hogy egyedül megválaszolja a kérdéseket. Tud valaki segíteni neki?", Quiz = quiz2, Answers = new List<Answer> { new Answer { Description = "Nem. Maxnak keményebben kell dolgoznia. Ez csak rajta múlik.", Value = 1 }, new Answer { Description = "Maxnak joga van a tanuláshoz, és hogy a tanárai, szülei és más felnőttek segítsék őt abban, hogy jól teljesítsen az iskolában.", Value = 1 }, new Answer { Description = "Maxot jól el kellene verni.", Value = 1 } } };

            Question question13 = new Question { Description = "Franciskát és testvérét a szülei mindig megverik otthon, ha valami rosszat csinál. Megtehetik ezt?", Quiz = quiz2, Answers = new List<Answer> { new Answer { Description = "Nem, a gyerekeket egyáltalán nem szabad megverni.", Value = 1 }, new Answer { Description = "Igen, egy szülő bármit megtehet.", Value = 1 }, new Answer { Description = "Csak kicsit verhetik meg, nagyon – például úgy, hogy nyoma maradjon, nem.", Value = 1 } } };

            form2.Questions = new List<Question> { question1, question2, question3, question4, question5, question6 };

            quiz2.Questions = new List<Question> { question7, question8, question9, question10, question11, question12, question13 };
            query.Form = form2;
            query.Quiz = quiz2;

            return Ok(query);
        }
    }
}