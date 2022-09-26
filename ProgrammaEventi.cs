
//MILESTONE 3
//Creare una classe ProgrammaEventi con i seguenti attributi
// - string Titolo
// - List<Evento> eventi

//Nel costruttore valorizzare il titolo, passato come parametro, e inizializzate la lista di eventi come una nuova Lista vuota di eventi.

//Aggiungete poi i seguenti metodi:
// - un metodo che aggiunge alla lista del programma eventi un Evento, passato come parametro al metodo. (DA TESTARE)
// - un metodo che restituisce una lista di eventi con tutti gli eventi presenti in una certa data.
// - un metodo statico che si occupa, presa una lista di eventi, di stamparla in Console, o ancora meglio vi restituisca la rappresentazione in stringa della vostra lista di eventi.
// - un metodo che restituisce quanti eventi sono presenti nel programma eventi attualmente.(DA TESTARE)
// - un metodo che svuota la lista di eventi. (DA TESTARE)
// - un metodo che restituisce una stringa che mostra il titolo del programma e tutti gli eventi aggiunti alla lista. Come nell’esempio qui sotto: Nome programma evento:
//data1 - titolo1 data2 - titolo2 data3 - titolo3... (DA TESTARE)


public class ProgrammaEventi
{
    string Titolo;
    List<Evento> eventi;

    public ProgrammaEventi(string titolo)
    {
        this.Titolo = titolo;
        List<Evento> eventi = new List<Evento>();
    }

    public void AggiungiEvento( Evento evento)
    {
        eventi.Add(evento);
    }

    public int NumeroEventi()
    {
        return eventi.Count();
    }

    public void SvuotaEventi()
    {
        eventi.Clear();
    }

    public override string ToString()
    {
        string stringa = "------ Nome programma evento ------\n";
        foreach (Evento evento in eventi)
        {
            stringa += evento.RigaLista() + "\n";
        }
        
        stringa += "-------------------";

        return stringa;
    }

}
