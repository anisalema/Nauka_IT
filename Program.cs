
using System; //przestrzeń nazw
using System.Collections.Specialized;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Twoja_Mama;
using Twoja_Mama.Enums;
using ClassLibrary;

namespace Nauka

//KOMENTARZE

//komentarze piszemy w ten sposób (dwie // na początku
/*
 lub między takimi / * wtedy można na kilka wierszy
 */
{// jak wpiszemy trzy / to mamy summary i to można by zaznaczyć jakieś podsumowanie
    /// <summary>
    /// 
    /// </summary>
    /// 

    // Można również robić regiony: Można wtedy rozwijać je i zwijać by nie zajmowały miejsca
    #region Pierwsze Lekcje

    //coś tutaj sobie wpisujesz jakiś kodzik

    #endregion



    class Program
    { 
        static void Main(string[] arges)
        {
            //Projekt konsolowy
            //Tak się pisze tekst, który wyświetla w linijce:
            Console.WriteLine("To mój pierwszy projekt konsolowy");

            //Tak się pisze jak chce się teksty obok siebie:
            Console.Write("To jest: ");
            Console.Write("Notatka.");

            //pytanie o dane użytkownika i przypisanie do zmiennej:
            Console.WriteLine("Kto ty jesteś?");
            string nazwa = Console.ReadLine();

            Console.WriteLine("Cześć " +  nazwa);

            //Typy zmiennych:
            
            char lChar = 'L';

            bool Ready = true;

            DateTime now = DateTime.Now;
            
            //można stworzyć własną date jako dane od użytkownika:
            Console.WriteLine("Podaj swój dzień urodzenia:");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swój miesiąc urodzenia:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swój rok urodzenia:");
            int year = int.Parse(Console.ReadLine());
            DateTime DataBirth = new DateTime(year , month, day);
            // a żeby policzyć ilość dni która minęła można użyć:
            TimeSpan TimeSpan = DateTime.Now - DataBirth;
            Console.WriteLine("Ilość dni którą przeżyłeś: ");
            Console.WriteLine(TimeSpan.TotalDays);
            // LUB
            Console.WriteLine("Wprowadź datę urodzenia (dd.mm.yy)");
            string dateofBirthString = Console.ReadLine();
            DateTime dataUrodzin = DateTime.Parse(dateofBirthString);

            byte Byte = 0; //Od 0 do 255
            sbyte sByte = -100; //Od -128 do 127
            short Short = -32325; //Od -32 768 do 32 767
            ushort uShort = 0; //Od 0 do 65,535
            int Int = -2000000000; //Od -2 147 483 648 do 2 147 483 647
            uint uInt = 0; //Od 0 do 4 294 967 295
            long Long = -9000000000; //Od -9 223 372 036 854 775 808 do 
                                     //9 223 372 036 854 775 807
            ulong uLong = 0; //Od 0 do 18 446 744 073 709 551 615

            float Float = -3.40f; //Od -3.402823e38 do 3,402823e38
            double Double = 1; //Dużo
            decimal Decimal = 1m; //Najwięcej

            string Pusto;
            string String = "Tekstowa";
            string Null = null;
            string Empty = string.Empty;

            //Jak zrobić by kompilator traktował " " jako część tekstu
            //a) trzeba dodać \ przed
            string text = "Teraz ty powinnienieś powiedzieć: \"Cześć\"";
            //b) lub @ przed całością tekstu
            string folder = @"C\Programy\Steam\";

            //łączy zmienną z czymś innym
            string concatented = string.Concat(text, "\" Jak się masz?\"");
            string concatented2 = text + ("\" Dawno się nie widzieliśmy\"");

            string incorporated = $"{text} do mnie ";

            //Tworzenie jednego string z dokładaniem później tekstu:
            StringBuilder tutaj = new StringBuilder("Tutaj ");
            tutaj.Append("powstanie ");
            tutaj.Append("bibila ");
            tutaj.Append("informatyczna.");

            string wynik = tutaj.ToString();
            Console.WriteLine(wynik);

            //Matematyka:
            //zachowana kolejność wykonywania działań

            int result;
            int x = 4;
            int y = 3;

            result = (x + y);
            Console.WriteLine("Dodawanie: " + result);

            result = (x - y);
            Console.WriteLine("Odejmowanie: " + result);

            result = (x * y);
            Console.WriteLine("Mnożenie: " + result);

            result = (x / y);
            Console.WriteLine("Dzielenie: " + result);

            result = (x % y);
            Console.WriteLine("Reszta z dzielenia: " + result);


            //Operatory zwiększające i odejmujące o "1":

            Console.WriteLine("Doda wartość odrazu: (Pre-increasement: ");
            Console.WriteLine(++x);

            Console.WriteLine("Doda wartość później: (Post-increasement: ");
            Console.WriteLine(x++);
            Console.WriteLine(x);

            //Zwracanie wartość prawda-fałsz:

            bool boolResult; //stworzenie zmiennej boolowskiej
            int a = 2;
            int b = 3;

            boolResult = (a == b); //równe sobie - takie same
            Console.WriteLine("Równe? " + boolResult);

            boolResult = (a > b); //większe niż
            boolResult = (a < b); //mniejsze niż
            boolResult = (a >= b); //większe lub równe
            boolResult = (a <= b); //mniejsze lub równe
            boolResult = (a != b); //nie takie same jak

            //Typy logiczne (booliony):

            bool p = true;
            bool k = false;

            boolResult = p && k; //And 
            Console.WriteLine("Operator AND: " + boolResult);

            boolResult = p || k; //Lub (OR)
            Console.WriteLine("Operator OR: " + boolResult);

            boolResult = !p; //NOT 
            Console.WriteLine("Operator NOT: " + boolResult);

            //Ternary conditional operator - skrócona wersja if else

            x = 5;
            y = 10;
            int WiększaLiczba = x > y ? x : y;
            //warunek logiczny to x > y
            //wartość jeśli warunek zwróci wartość true to x po ?
            //wartość jeśli warunek zwróci wartość false to y ostatnie

            Console.WriteLine("Wartość będąca odpowiedzią jest: " + WiększaLiczba);

            // KONSTRUKCJA IF ELSE

            //Program pytający o wiek
            Console.WriteLine("W którym roku się urodziłeś/aś?");
            string InputUsera = Console.ReadLine();

            int RokUrodzenia = int.Parse(InputUsera);

            bool Ponad18 = DateTime.Now.Date.Year - RokUrodzenia >= 18;
            if (Ponad18)
            {
                Console.WriteLine("Hello, masz dostęp");
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
            {
                Console.WriteLine("Masz szczęście, że jest wtorek");
                Console.WriteLine("Masz Dostęp");
            }
            else
            {
                Console.WriteLine("Brak dostępu");
            }


            // KONSTRUKCJA SWITCH - alternatywa dla if else

            //Jak kliknie się na żarówkę po prawo od switch to się zmieni na if else
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Jest poniedziałek.");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Pierwszy dzień weekendu.");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Jest weekend.");
                    break;
                default:
                    Console.WriteLine("Dzień roboczy.");
                    break;
            }

            // KONWERSJE TYPÓW I RZUTOWANIE

            //Parse to zmiana z typu string na inne
            Console.WriteLine("Podaj swoją ulubioną liczbę: ");
            String Cokolwiek = Console.ReadLine();
            int RokSmoka = int.Parse(Cokolwiek);
            float RokByka = float.Parse(Cokolwiek);
            //analogicznie dla innych typów liczbowych
            // "nazwa typu" "nazwa zmiennej" = "nazwa typu".Parse("Nazwa stringu, z którego zmieniamy");

            //a co jeśli użytkownik wpisze coś co nie jest rodzajem jakim chcemy
            int.TryParse(Cokolwiek, out RokSmoka);
            // to co po out to ma być wartość jaką chcemy uzyskać
            // na przykład:
            int ZmiennaQ;
            if (int.TryParse(InputUsera, out ZmiennaQ)) 
            {
                int ZmiennaW = DateTime.Now.Year - ZmiennaQ;
                Console.WriteLine("Masz " + ZmiennaW + " lata.");
            }
            else
            {
                Console.WriteLine("Incorrect value");
            }

            /* 
             konwersja z jednego typu liczbowego na inny
             możliwa bez problemu gdy przypisujemy wartość, która zmieści się w innej (z mniejszej na większą)
            jeśli jednak z większej na mniejszą to formuła wygląda tak:
            */
            double doubleWar = 3.14;
            int intWar = (int)doubleWar;

            //konwersja z liczbowego na string:
            string stringWar = intWar.ToString();

            // TABLICE

            //TABLICE JEDNOWYMIAROWE
            string[] auta = {"Porsche", "Ferrari", "Toyota", "Tesla", "Mercedes", "Skoda"};
            //nawiasy [] oznaczają tablicę
            //wszystkie dane w tablicy mają swój numer indeks zaczynając od 0, tzn. Porche = 0, Ferrari = 1 a Skoda = 5
            //przywołanie elementu:
            Console.WriteLine(auta[3]);

            Array.Sort(auta); //całe sortowanie w jednej linijce
            Array.Resize(ref auta, auta.Length + 5); //zmiana rozmiaru tablicy

            //długość tablicy sprawdzamy przy użyciu:
            int arrayLength = auta.Length; //powie ilość wartości w tablicy ale licząc już od 1

            //gdybyśmy chcieli przywołać auta.lenght jako ilość to trzeba odjąć 1

            //zmiana danej wartości z tablicy:
            auta[0] = "Mazda"; //zmieni Porsche na Mazda

            //tablice mają stałą długość

            //TABLICE WIELOWYMIAROWE

            //Tablice prostokątne - wszystkie rzędy ta sama np:
            //Tablice dwuwymiarowe prostokątne:
            int[,] TablicaDwuwymiarowa; //Deklaracja tablicy
            TablicaDwuwymiarowa = new int[3, 7]; //inicjalizacja
            //TablicaDwuwymiarowa [numer indeksu 1, numer indeksu 2]; //odwołanie 
            //Inicjalizacja:
            int[,] TablicaDwuwymiarowa2 = { { 7, 3, 6 }, { 3, 5, 4 }, { 10, 45, 32 } };

            //Tablice nieregularne - tablice tablic, każdy rząd może mieć inną długość
            int[][] TablicaNieregularna; //Deklaracja
            //reszta notatki na OneNote


            //LISTY
            /*
            należy do typów ogólnych (generic types)
            w porównaniu z tablicą ma zaletę, że liczba elementów może być zmieniania już po utowrzeniu listy
            Można dodawać elementy na koniec, początek lub w środek listy
            Można usuwać dowolny element listy
            */

            List<Type> list = new List<Type>();
            //przykład:
            List<string> listaPiesków = new List<string>();

            /*
            nazwa.Add(element); - dodawanie elementu
            nazwa.AddRange(new String[] {"aa", "bb"});
            nazwa.Insert(poz, "aa"); - wstaiwanie lementu na wskazaną pozycję UWAGA: nie zastępujemy a wstawiamy
            nazwa.InsertRange(poz, newString[] {"aa", "bb"}); - wstawianie listy elementów na daną pozycję
            nazwa.RemoveAt(poz) - usunięcie wskazanego elementu (wskazujemy indeks)
            nazwa.Remove("bb"); - usunięcie elementu o wskazanej wartości
            nazwa.Clear(); - wyczyszczenie listy
            nazwa.Sort(); - sortowanie listy
            - żeby rosnąco to automatycznie a malejąco to trzeba najpierw rosnąco a później reverse
            nazwa.Reverse(); - odwrócenie listy
            nazwa.Count(); - podaje liczbę elementów
            nazwa.ToArray(TablicaDocelowa); - eksportuje listę do tablicy
            */


            //Pętla WHILE - będzie wykonywana aż bool zwraca true

            int i = 0; //tworzymy zmienną, która będzie wyznacznikiem warunku
            while (i <= 2) //tutaj oznacza to że loopa powtórzy się tyle razy ile wyznacznik warunku jest mniejszy lub równy 2 (czyli 3 razy)
            {
                Console.WriteLine(auta[i]); //można wywołać elementy z tablicy -> wartość indeksu równa wartości wyznacznika
                if (auta[i] == "Ferrari") //gdybyśmy chcieli zakończyć na danej wartości 
                {
                    Console.WriteLine("Formuła 1");
                    break; //kończy pętle
                }


                i++; // na koniec trzeba pamiętać by zwiększyć wyznacznik o 1 żeby loopa nie była nieskończona
            }

            //Przykład:

            Console.WriteLine("Wpisz liczbę:");
            int liczba = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int? MaxValue = null;


            while (liczba != 0)
            {

                if (MaxValue == null || liczba > MaxValue)
                {
                    MaxValue = liczba;
                }

                sum1 += liczba;
                liczba = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Suma: " + sum1);
            Console.WriteLine("MaxValue: " + MaxValue);

            //Pętla DO_WHILE
            // w tej pętli najpierw wykonuje się kod bloku a później sprawdza warunek czy trzeba go wykonać ponownie

            Console.WriteLine("Napisz kys a cię wyjebie");
            string tekstUsera;
            do
            {
                tekstUsera = Console.ReadLine();
                Console.WriteLine(tekstUsera);
            } while (tekstUsera != "kys");

            //Pętla FOR
            
            for (int j = 0; j < auta.Length; j++)
            {
                Console.WriteLine(auta[j]);
            }
            /*
             for (instrukcja 1, instrukcja 2 ,instrukcja 3;
            instrukcja 1 = tylko raz przed pierwszym wykonaniem bloku  kodu
            instrukcja 2 = boolowskie -> czy pętla ma być wykonana
            instuekcja 3 = co ma być wykonane za każdym razem po wykonaniu bloku kodu
            */

            // pętla FOREACH

            string[] buty = { "Nike", "Adidas", "Birkenstock", "Puma", "Scotts" };

            foreach (string but in buty) //tworzy się jakby zmienną będącą uniwersalną nazwą wartości z tablicy
            {
                Console.WriteLine(but);
                if (but == "Puma")
                {
                    Console.WriteLine("Dziecko co ty nosisz");
                    break;
                }
            }

            // ENUM - wartości do przypisanej nazwy np DayOfWeek

            //prawym myszy na nasz program -> add -> new item -> szablony -> klasa a tam zmieniamy typ na enum w następujący sposób:
            /* 
             enum Gender : byte
            {
            Male = 1,
            Female = 2
            }
            */

            Console.WriteLine("Jaka jest twoja płeć? 1 - Mężczyzna, 2 - Kobieta");
            string jakaGen = Console.ReadLine();

            Gender userGen = (Gender)Enum.Parse(typeof(Gender), jakaGen);
            //typ zmiennej - nazwa zmiennej = (enum który nam chodzi) - konwersja typu ze string na enum(z czego na co)

            
            //Nullable - umożliwia trzymanie braku wartości zmiennej

            Nullable<int> favliczba = null;
            //bądź
            int? favliczba2 = null;

            //jak sprawdzić czy zmienna ma przypisaną wartość?
            Console.WriteLine(favliczba.HasValue ? favliczba.Value.ToString() : ""); ;


            //TRY-CATCH-FINALLY

            try
            {
                //kod, który może spowodować wyjątek
                buty[5] = "Crocs";
            }
            catch (IndexOutOfRangeException e) //Tylko jak z listy próbujemy przechwycić coś co nie istnieje
            {
                Console.WriteLine("Nie ma takiego indeksu");
            }
            catch (Exception e) //każdy wyjątek 
            {
                Console.WriteLine("Błąd");
            }
            finally //wyświetlony zawsze nawet jak nie ma wyjątku
            {
                Console.WriteLine("Papatki");
            }

            //NAMESPACE
            //warto tworzyć foldery kiedy za duży program
            

            //REGEX -> można ćwiczyć na stronie regexr.com
            /*
            Kotwice - sprawdza czy dana wartość tekstowa kończy/zaczyna się na konkretny znak:
            ^Dzień - będzie szukał stringów zaczynających się od Dzień
            dobry$ - będzie szukał stringów kończących się na dobry
            ^Dzień dobry$ - szuka dokładną frazę od końca do początku
            test - dopasowuje dowolny string zawierający test


            Kwantyfikatory - 

            Klasy

            Flagi

            Nawiasy Kwadratowe 

            Operator LUB

            */

            //KLASY - określa formę wartości jaką mogą mieć dane w naszym programie
            //jak dodać -> ppm -> add -> class

            //typ Person to klasa definiująca wartości dla każdej instancji typu Person
            //Obiekt to konkrentna instancja typu przypisana za pomocą słowa kluczowego new
            // -->  Person Kate = new Person(); //zmienna typu Person a Kate to obiekty typu Person
            //Ten kod działałby gdyby konstruktor nie miał żadnych parametrów, gdyż kompilator stworzył by własny konstruktor domyślnie
            Person Kate = new Person("Kate", "Mazur");
            //Wywołanie metody zwanej konstruktorem.
            //KONSTRUKTOR - metoda używana do tworzenia nowegoobiektu dla danego typu przy użyciu słowa kluczowego "new". O implementacji w części klasy Person

            Kate.FirstName = "Kate"; //jeśli pisze, że nie wolno bo protection lvl to trzeba w klasie ustalić public
            //ta linijka wyżej zbędna, gdyż konstruktor sam przypisze już wartości

            //METODA - blok kodu użyty po wywołaniu; może zwrócić jedną wartość lub w ogóle jej nie zwrócić
            //do metody (inaczej funkcji) można przekazać argumenty znane jako parametry
            //w pliku Person cała notatka o metodach

            Kate.SetDateOfBirth(new DateTime(2002, 4, 2));

            //Console.WriteLine($"{Kate.FirstName} {Kate.GetDateOfBirth()}");
            //Zamiast tego to to dzięki metodzie:
            Kate.SayHi();
            Kate.ContactNumber = "123456789";
            Console.WriteLine(Kate.ContactNumber);

            Person Damian = new Person(new DateTime(2000, 2, 27), "Damian", "Bieniek");
            Damian.SayHi();

    // WŁAŚCIWOŚCI STATYCZNE
        /*
        modyfikator static - umożliwia zadektarowanie, że element klasy należy do samego typu a nie obiektu
        modyfikator static w C# sprawia, że dany element (np. pole, metoda) jest związany z klasą jako całością, a nie z poszczególnymi obiektami tej klasy. Dzięki temu:
        - Pole statyczne jest wspólne dla wszystkich obiektów danej klasy. Zmiana tego pola w jednym obiekcie wpłynie na jego wartość we wszystkich obiektach.
        - Metoda statyczna może być wywoływana bez tworzenia obiektu danej klasy. Można z niej skorzystać bezpośrednio przez nazwę klasy.
        - Klasa statyczna nie pozwala na tworzenie jej obiektów. Zawiera tylko elementy, które są dostępne bezpośrednio przez nazwę klasy.

        -> metoda statyczna z Console, np:
        Console.WriteLine();
        Console.ReadLine();
        -> właściwość statyczna z DateTime, np:
        DateTime.Now;
        ->metoda statyczna z int, np:
        int.Parse(); //Parse to statyczne elementy danych typów

        Przykłady zastosowania:
        - Przechowywanie wspólnych danych dla wszystkich obiektów
        Załóżmy, że masz klasę BankAccount, która reprezentuje konto bankowe. Każde konto ma unikalny numer, ale wszystkie konta w banku mają ten sam kurs wymiany walut. 
        Możesz użyć static do przechowywania kursu walut, ponieważ jest on taki sam dla wszystkich kont.
        - Zliczanie liczby obiektów
        Możesz użyć statycznego pola do zliczania liczby utworzonych obiektów danej klasy.
        --> Podsumowanie
        Modyfikator static jest używany, gdy chcesz, aby pewne dane, metody lub inne elementy były wspólne dla wszystkich obiektów danej klasy, lub aby były dostępne 
        bez tworzenia obiektu. Dzięki temu możesz tworzyć elementy, które są związane z samą klasą, a nie z konkretnymi instancjami (obiektami) tej klasy.

        Jak się odwołać: (użyć)
        */
        Console.WriteLine($"Ilość objektów typów Person jest równa: {Person.Count}"); //liczy ilość obiektów typu Person
        //jednak żeby to się stało trzeba pamiętać by w konstruktorze dodać Count++; bo inaczej nie będzie zliczać poprawnie wartości

    /*DZIEDZICZENIE
        Umożliwia utworzenie typu bazowego, który będzie miał wspólne wartości pomiędzy klasami, a następnie dla klas, które będą dziedziczyć z tej klasy bazowej te
        właściwości będą dostępne.
        Jak to zrobić. Najpierw trzeba dodać klasę bazową. Czyli PPM -> add -> new item -> class
        Wkleić kod, który ma być wspólny dla reszty klas.
        Po nazwie klasy w pliku klasy dajemy : i nazwe klasy.
        Niżej opisane jak uzyskać dostęp do danych i nadać im treść

         // !!! można dziedziczyć tylko po jednej klasie bazowej !!!
    */  
            ExcelFile excelFile = new ExcelFile();

            excelFile.CreatedOn = DateTime.Now;
            excelFile.FileName = "excel-file";

            excelFile.GenerateReport();

            WordFile wordFile = new WordFile();

            wordFile.CreatedOn = DateTime.Now;
            wordFile.FileName = "word-file";

            wordFile.Print();

    /* MODYFIKATORY DOSTĘPU
        Modyfikatory dostępu w C# są kluczowym elementem programowania obiektowego, który pozwala kontrolować, jakie części kodu mogą uzyskiwać dostęp do danych lub metod w klasie. 
        Innymi słowy, modyfikatory dostępu określają, kto może zobaczyć i modyfikować elementy w Twojej klasie.
        Oto główne modyfikatory dostępu w C#:
        -> public
            Dostępność: Wszędzie.
            Zastosowanie: Kiedy chcesz, aby dany element (np. metoda, pole, właściwość) był dostępny z dowolnego miejsca w programie, niezależnie od tego, gdzie jest zdefiniowany.
        -> private
            Dostępność: Tylko wewnątrz tej samej klasy.
            Zastosowanie: Kiedy chcesz ukryć dane lub metody przed innymi klasami. Jest to najbardziej restrykcyjny modyfikator dostępu.
        -> protected
            Dostępność: Tylko wewnątrz tej samej klasy i klas dziedziczących.
            Zastosowanie: Kiedy chcesz, aby element był dostępny dla klas pochodnych (dziedziczących), ale nie dla innych klas.
        -> internal
            Dostępność: Wszędzie w tym samym projekcie (assembly).
            Zastosowanie: Kiedy chcesz, aby element był dostępny tylko w obrębie tego samego projektu (np. jednej biblioteki). Jest to przydatne do ukrywania szczegółów implementacyjnych 
            w ramach jednego projektu.
                Powstał nowy projekt ClassLibrary, w którym jest więcej o tym jak to się robi i jak to działa.
                TRZEBA DODAĆ na górze pod Using System itd. using [nazwa projektu, z którego bierzemy]
        -> protected internal
            Dostępność: Wewnątrz tego samego projektu (assembly) oraz w klasach dziedziczących, nawet jeśli znajdują się w innym projekcie.
            Zastosowanie: Kiedy chcesz połączyć cechy protected i internal, czyli umożliwić dostęp do elementu klasom dziedziczącym oraz wszystkim klasom w obrębie tego samego projektu.
        -> private protected
            Dostępność: Wewnątrz tej samej klasy oraz klas dziedziczących, ale tylko w obrębie tego samego projektu.
            Zastosowanie: Kiedy chcesz, aby element był dostępny tylko dla klas dziedziczących, ale jedynie w obrębie tego samego projektu.
        Podsumowanie
            public: Dostępne wszędzie.
            private: Dostępne tylko w tej samej klasie.
            protected: Dostępne w tej samej klasie i klasach dziedziczących.
            internal: Dostępne w obrębie tego samego projektu.
            protected internal: Dostępne w klasach dziedziczących i w obrębie tego samego projektu.
            private protected: Dostępne w klasach dziedziczących, ale tylko w obrębie tego samego projektu.
        Modyfikatory dostępu pomagają w organizacji kodu i ochronie danych przed nieautoryzowanym dostępem (hermetyzacja), co jest ważne dla utrzymania bezpieczeństwa i spójności aplikacji.

    */

            Class1 test = new Class1(); //to do internal jest

            //Klasa abstrakcyjna
            //abstract class to klasa która jest dostępna tylko w ramach dziedziczenia
            //to że, klasa jest abstrakcyjna sprawia, że nie można stworzyć instancji obiektu klasy file
            //a metody abstrakcyjne zmuszają do ich implementacji w klasach dziedziczących
            // !!! można dziedziczyć tylko po jednej klasie bazowej !!!


            //INTERFACE GRAFICZNY
            //W języku XAML

            /* INTERFACE
            Interfejs - definiuje kontrakt. Każda klasa, w której implementuje ten kontrakt musi zapewnić implementacje elementów zdefiniowanych w tym interfejsie
            Można myśleć o interface jako całkowicie abstrakcyjnej klasie, która zawiera tylko abstrakcyjne elementy członkowskie, które następnie muszą zostać zaimplementowane
            w konkretnych klasach.
            Nie można stworzyć obiketu interface.
            Trzeba zaimplementować wszystkie elementy interface.
            Można zaimplementować wiele interfejsów w jednej klasie (ale tylko jedną klasę bazową [więc tym się różni])
            Interfejs implementujemy a klasy dziedziczymy (różnica)
            Nie można mieć konstruktora zdefiniowanego w interfejsie, a w klasach można odwołać się do konstruktora z klasy bazowej
            W interface wszystkie elementy są domyślnie publiczne i abstrakcyjne 

            Plik IFile to interface i jak go się tworzy

            Implementacja interfaców pozwala nam wywołać metody polimorficzne
            */

            /* POLIMORFIZM
            
            */



        }
    }
}

