
//MILESTONE 3
//Creare una classe ProgrammaEventi con i seguenti attributi
// - string Titolo
// - List<Evento> eventi

//Nel costruttore valorizzare il titolo, passato come parametro, e inizializzate la lista di eventi come una nuova Lista vuota di eventi.
//Aggiungete poi i seguenti metodi:
// - un metodo che aggiunge alla lista del programma eventi un Evento, passato come parametro al metodo.
// - un metodo che restituisce una lista di eventi con tutti gli eventi presenti in una certa data.
// - un metodo statico che si occupa, presa una lista di eventi, di stamparla in Console, o ancora meglio vi restituisca la rappresentazione in stringa della vostra lista di eventi.
// - un metodo che restituisce quanti eventi sono presenti nel programma eventi attualmente.
// - un metodo che svuota la lista di eventi.
// - un metodo che restituisce una stringa che mostra il titolo del programma e tutti gli eventi aggiunti alla lista. Come nell’esempio qui sotto: Nome programma evento:
//data1 - titolo1 data2 - titolo2 data3 - titolo3...


using System;

ProgrammaEventi programmaEventiTest = new ProgrammaEventi("TestEventi");

Console.Write("Inserisci il nome dell'evento: ");

string nome = Console.ReadLine();

Console.Write("Inserisci la data dell'evento: ");

DateTime data = Convert.ToDateTime(Console.ReadLine());

Console.Write("Inserisci il numero di posti totali: ");

int posti = Convert.ToInt32(Console.ReadLine());


Evento eventoTest = new Evento( nome, data, posti);

Console.Write("Quanti posti desideri prenotare? ");

int postiPrenotati = Convert.ToInt32(Console.ReadLine());

eventoTest.PrenotaPosti(postiPrenotati);
Console.WriteLine(eventoTest.StampaPosti());

programmaEventiTest.AggiungiEvento(eventoTest);

Console.WriteLine("NUMERO DI EVENTI PRESENTI: " + programmaEventiTest.NumeroEventi());

Console.WriteLine("LISTA EVENTI: " + programmaEventiTest.StampaListaEventi());

programmaEventiTest.SvuotaEventi();

Console.WriteLine("NUMERO DI EVENTI PRESENTI: " + programmaEventiTest.NumeroEventi());


Console.WriteLine(programmaEventiTest.ToString());


Console.Write("Vuoi disdire dei posti(si/no)? ");

string disdetta = Console.ReadLine();

switch (disdetta)
{
    case "si":

        Console.Write("Indica i posti da disdire: ");

        int postiDisdetta = Convert.ToInt32(Console.ReadLine());
        eventoTest.DisdiciPosti(postiDisdetta);
        Console.WriteLine(eventoTest.StampaPosti());

        break;

    case "no":
        Console.WriteLine("Ok, va bene");

        break;

    default:
        break;
}
