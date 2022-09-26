
//MILESTONE 3
//Creare una classe ProgrammaEventi con i seguenti attributi: 

// - string Titolo

// - List<Evento> eventi

//Nel costruttore valorizzare il titolo, passato come parametro, e inizializzate la lista di eventi come una nuova Lista vuota di eventi.

//Aggiungete poi i seguenti metodi:

// - 1) un metodo che aggiunge alla lista del programma eventi un Evento, passato come parametro al metodo. (DA TESTARE)

// - 2) un metodo che restituisce una lista di eventi con tutti gli eventi presenti in una certa data.

// - 3) un metodo statico che si occupa, presa una lista di eventi, di stamparla in Console, o ancora meglio vi restituisca la rappresentazione in stringa della vostra lista di eventi. (DA TESTARE)

// - 4) un metodo che restituisce quanti eventi sono presenti nel programma eventi attualmente.(DA TESTARE)

// - 5) un metodo che svuota la lista di eventi. (DA TESTARE)

// - 6) un metodo che restituisce una stringa che mostra il titolo del programma e tutti gli eventi aggiunti alla lista. Come nell’esempio qui sotto: Nome programma evento:
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

    // METODO 1
    public void AggiungiEvento( Evento evento)
    {
        eventi.Add(evento);
    }

    // METODO 3
    public string StampaListaEventi()
    {
        string stringa = "-------------------\n";

        foreach (Evento evento in eventi)
        {
            stringa += " ";
            stringa += evento.ToString() + "\n";
            stringa += " ";
        }

        stringa += "-------------------";

        return stringa;
    }

    // METODO 4
    public int NumeroEventi()
    {
        return eventi.Count();
    }

    // METODO 5
    public void SvuotaEventi()
    {
        eventi.Clear();
    }

    // METODO 6
    public override string ToString()
    {
        string stringa = "------ " + this.Titolo +" ------\n";
        foreach (Evento evento in eventi)
        {
            stringa += evento.RigaLista() + "\n";
        }
        
        stringa += "-------------------";

        return stringa;
    }

}
