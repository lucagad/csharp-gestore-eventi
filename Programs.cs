
//MILESTONE 2
//1.Nel vostro programma principale Program.cs, chiedete all’utente di inserire un nuovo evento con tutti i parametri richiesti dal costruttore.
//2. Dopo che l’evento è stato istanziato, chiedete all’utente se e quante prenotazioni vuole fare e provare ad effettuarle.
//3. Stampare a video il numero di posti prenotati e quelli disponibili.
//4. Ora chiedere all’utente fintanto che lo desidera, se e quanti posti vuole disdire. Ogni volta che disdice dei posti, stampare i posti residui e quelli prenotati.
//Attenzione: In questa prima fase non è necessario gestire le eventuali eccezioni da Program.cs che potrebbero insorgere,
//eventualmente il programma si blocca se qualcosa va storto che voi avevate già previsto. Piuttosto pensate bene alla logica del vostro programma principale e della vostra classe Evento
//pensando bene alle responsabilità dei metodi e alla visibilità di attributi e metodi.

//Evento test = new Evento();
//Evento test2 = new Evento();

//try
//{
//    test = new Evento("test", DateTime.Parse("11/01/2022"), 5);
//}
//catch (ArgumentNullException)
//{
//Console.WriteLine("Il titolo non può esser vuoto");
//}

//Console.WriteLine("TEST");
//Console.WriteLine(test.ToString());

//try
//{
//    test.DisdiciPosti(5);
//}
//catch (ArgumentException e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    test2 = new Evento("Test", DateTime.Parse("11/01/2022"), 5);
//}
//catch (ArgumentNullException e)
//{
//    Console.WriteLine(e.Message);
//}
//catch (ArgumentException e)
//{
//    Console.WriteLine(e.Message);
//}

//Console.WriteLine(" ");
//Console.WriteLine("TEST2");
//Console.WriteLine(test2.ToString());



Console.Write("Inserisci il nome dell'evento: ");

string nome = Console.ReadLine();

Console.Write("Inserisci la data dell'evento: ");

DateTime data = Convert.ToDateTime(Console.ReadLine());

Console.Write("Inserisci il numero di posti totali: ");

int posti = Convert.ToInt32(Console.ReadLine());


Evento test = new Evento( nome, data, posti);

Console.Write("Quanti posti desideri prenotare? ");

int postiPrenotati = Convert.ToInt32(Console.ReadLine());

test.PrenotaPosti(postiPrenotati);
Console.WriteLine(test.StampaPosti());

Console.Write("Vuoi disdire dei posti(si/no)? ");

string disdetta = Console.ReadLine();

switch (disdetta)
{
    case "si":

        Console.Write("Indica i posti da disdire: ");

        int postiDisdetta = Convert.ToInt32(Console.ReadLine());
        test.DisdiciPosti(postiDisdetta);
        Console.WriteLine(test.StampaPosti());

        break;

    case "no":
        Console.WriteLine("Ok, va bene");

        break;

    default:
        break;
}
