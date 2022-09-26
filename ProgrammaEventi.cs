
//MILESTONE 3
//Creare una classe ProgrammaEventi con i seguenti attributi: 

// - string Titolo

// - List<Evento> eventi

//Nel costruttore valorizzare il titolo, passato come parametro, e inizializzate la lista di eventi come una nuova Lista vuota di eventi.

//Aggiungete poi i seguenti metodi:

// - 1) un metodo che aggiunge alla lista del programma eventi un Evento, passato come parametro al metodo. (OK)

// - 2) un metodo che restituisce una lista di eventi con tutti gli eventi presenti in una certa data.(OK)

// - 3) un metodo statico che si occupa, presa una lista di eventi, di stamparla in Console, o ancora meglio vi restituisca la rappresentazione in stringa della vostra lista di eventi. (OK)

// - 4) un metodo che restituisce quanti eventi sono presenti nel programma eventi attualmente.(OK)

// - 5) un metodo che svuota la lista di eventi. (OK)

// - 6) un metodo che restituisce una stringa che mostra il titolo del programma e tutti gli eventi aggiunti alla lista. Come nell’esempio qui sotto: Nome programma evento:
//data1 - titolo1 data2 - titolo2 data3 - titolo3... (OK)


public class ProgrammaEventi
{
    string Titolo;
    List<Evento> eventi;

    public ProgrammaEventi(string titolo)
    {
        this.Titolo = titolo;
        eventi = new List<Evento>();
    }

    // METODO 1
    public void AggiungiEvento(Evento evento)
    {
        this.eventi.Add(evento);
    }

    // METODO 2
    public string EventiData( DateTime dataRicerca)
    {
        string stringa = "-------------------\n";
        foreach (Evento evento in eventi)
        {
            if(evento.Data.Date == dataRicerca.Date)
            {
                stringa += evento.RigaLista() + "\n";
            }  
        }

        stringa += "-------------------";

        return stringa;
    }

    // METODO 3
    public string StampaListaEventi()
    {
        string stringa= "";

        foreach (Evento evento in eventi)
        {
            stringa += " " + "\n";
            stringa += evento.RigaLista() + "\n";
        }

        return stringa;
    }

    // METODO 4
    public int NumeroEventi()
    {
        return this.eventi.Count();
    }

    // METODO 5
    public void SvuotaEventi()
    {
        this.eventi.Clear();
    }

    // METODO 6
    public override string ToString()
    {
        string stringa = "------ " + this.Titolo +" ------\n";
        foreach (Evento evento in eventi)
        {
            stringa += evento.RigaLista() + "\n";
        }
        
        stringa += "----------------------------------";

        return stringa;
    }

}
