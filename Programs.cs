//MILESTONE 4
//Una volta completata la classe ProgrammaEventi, usatela nel vostro programma principale Program.cs per creare un nuovo programma di Eventi
//che l’utente vuole organizzare, chiedendogli qual è il titolo del suo programma eventi.
//Chiedete poi al vostro utente quanti eventi vuole aggiungere, e fategli inserire ad uno ad uno tutti gli eventi necessari
//chiedendo man mano tutte le informazioni richieste all’utente.

//Attenzione: qui si gestite eventuali eccezioni lanciate dagli eventi creati, in questo caso il programma informa l’utente dell’errore e non aggiunge l’evento al programma eventi (o meglio alla lista di Eventi del programmaEventi), ma comunque chiederà in continuazione all’utente di inserire eventi fintanto che non raggiunge il numero di eventi specificato inizialmente dall’utente.

//Una volta compilati tutti gli eventi:
//1.Stampate il numero di eventi presenti nel vostro programma eventi
//2. Stampate la lista di eventi inseriti nel vostro programma usando il metodo già fatto
//3. Chiedere all’utente una data e stampate tutti gli eventi in quella data. Usate il metodo che vi restituisce una lista di eventi in una data dichiarata e create un metodo statico che si occupa di stampare una lista di eventi che gli arriva. Passate dunque la lista di eventi in data al metodo statico, per poterla stampare.
//4. Eliminate tutti gli eventi dal vostro programma.


Console.Write("Inserisci il nome del tuo programma Eventi: ");
string nomeProgrammaEventi = Console.ReadLine();

ProgrammaEventi programmaEventiUtente = new ProgrammaEventi(nomeProgrammaEventi);

Console.Write("Inserisci il numero di eventi da inserire: ");

int numeroEventi = Convert.ToInt32(Console.ReadLine());
Console.Write(" ");

for (int i = 0; i < numeroEventi; i++)
{

    try
    {
        CreaNuovoEvento();

    }
    catch (ArgumentNullException e)
    {
        Console.WriteLine(e.Message);
        CreaNuovoEvento();
    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e.Message);
        CreaNuovoEvento();
    }

}

Console.WriteLine("Il numero di eventi nel tuo programma: " + programmaEventiUtente.NumeroEventi() + "\n");
Console.WriteLine(" ");
Console.WriteLine("Ecco il tuo programma Eventi: \n");
Console.WriteLine(programmaEventiUtente.ToString());

Console.WriteLine(" ");
Console.Write("Inserisci una data per sapere che eventi ci saranno (gg/mm/yyyy): ");

DateTime data = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine(programmaEventiUtente.EventiData(data) + "\n");

Console.WriteLine("----- BONUS ----");
Console.WriteLine("Aggiungiamo anche una conferenza!");


try
{
    CreaNuovaConferenza();

}
catch (ArgumentNullException e)
{
    Console.WriteLine(e.Message);
    CreaNuovaConferenza();
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
    CreaNuovaConferenza();
}



Console.Write("Vuoi svuotare la lista degli eventi (si/no)? ");

string svuotaLista = Console.ReadLine();

switch (svuotaLista)
{
    case "si":
        programmaEventiUtente.SvuotaEventi();

        Console.WriteLine("Ecco il tuo programma Eventi vuoto: \n");
        Console.WriteLine(programmaEventiUtente.ToString());
        break;

    case "no":
        Console.WriteLine("Ok, va bene");
        Console.WriteLine("Ecco il recap della tua lista eventi");
        Console.WriteLine("Ecco il tuo programma Eventi: \n");
        Console.WriteLine(programmaEventiUtente.ToString());

        break;

    default:
       break;
}



//FUNZIONE PER CREARE NUOVO EVENTO

void CreaNuovoEvento()
{
    Console.WriteLine(" ");
    Console.Write("Inserisci il nome dell' evento: ");

    string nome = Console.ReadLine();

    Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");

    DateTime data = Convert.ToDateTime(Console.ReadLine());

    Console.Write("Inserisci il numero di posti totali: ");

    int posti = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(" ");

    Evento nuovoEvento = new Evento(nome, data, posti);
    programmaEventiUtente.AggiungiEvento(nuovoEvento);

}


void CreaNuovaConferenza()
{
    Console.WriteLine(" ");

    Console.Write("Inserisci il nome della conferenza: ");
    string nome = Console.ReadLine();

    Console.Write("Inserisci la data della conferenza (gg/mm/yyyy): ");
    DateTime data = Convert.ToDateTime(Console.ReadLine());

    Console.Write("Inserisci il numero di posti per la conferenza ");
    int posti = Convert.ToInt32(Console.ReadLine());

    Console.Write("Inserisci il Relatore della conferenza: ");
    string relatore = Console.ReadLine();

    Console.Write("Inserisci il prezzo del biglietto della conferenza ");
    double prezzo = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine(" ");

    Conferenza nuovaConferenza = new Conferenza(nome, data, posti, relatore ,prezzo);
    programmaEventiUtente.AggiungiConferenza(nuovaConferenza);

}






//Console.Write("Quanti posti desideri prenotare? ");

//int postiPrenotati = Convert.ToInt32(Console.ReadLine());

//eventoTest.PrenotaPosti(postiPrenotati);
//Console.WriteLine(eventoTest.StampaPosti());

////EVENTI DI TEST DA TOGLIERE
//Evento eventoTest2 = new Evento(nome +"2", data.AddMonths(1), posti);
//Evento eventoTest3 = new Evento(nome + "3", data.AddDays(20), posti);

//programmaEventiTest.AggiungiEvento(eventoTest2);
//programmaEventiTest.AggiungiEvento(eventoTest3);


//Console.WriteLine(programmaEventiTest.ToString());

//Console.WriteLine(" ************* ");

//programmaEventiTest.SvuotaEventi();

//Console.WriteLine(" ************* ");

//Console.WriteLine(programmaEventiTest.ToString());



//Console.Write("Vuoi disdire dei posti(si/no)? ");

//string disdetta = Console.ReadLine();

//switch (disdetta)
//{
//    case "si":

//        Console.Write("Indica i posti da disdire: ");

//        int postiDisdetta = Convert.ToInt32(Console.ReadLine());
//        eventoTest.DisdiciPosti(postiDisdetta);
//        Console.WriteLine(eventoTest.StampaPosti());

//        break;

//    case "no":
//        Console.WriteLine("Ok, va bene");

//        break;

//    default:
//        break;MILESTONE 4
//}


