
//MILESTONE 1
//Per prima cosa è necessario creare una classe Evento che abbia i seguenti attributi:
// - titolo
// - data
// - capienza massima dell’evento
// - numero di posti prenotati

//Aggiungere metodi getter e setter in modo che:
// - titolo sia in lettura e in scrittura
// - data sia in lettura e scrittura
// - numero di posti per la capienza massima sia solo in lettura
// - numero di posti prenotati sia solo in lettura
//ai setters inserire gli opportuni controlli in modo che la data non sia già passata, che il titolo non sia vuoto e che la capienza massima di posti sia un numero positivo.
//In caso contrario sollevare opportune eccezioni.

//Dichiarare un costruttore che prenda come parametri il titolo, la data e i posti a disposizione e inizializza gli opportuni attributi facendo uso dei metodi e controlli già fatti.
//Per l’attributo posti prenotati invece si occupa di inizializzarlo lui a 0.


public class Evento
{
    private string titolo;
    private DateTime data;

    private int capienzaMassima;
    public int PostiPrenotati { get; }


    public string Titolo
    {
        get
        {
            return titolo;
        }

        set
        {
            if (value == "")
            {
                throw new ArgumentNullException("Il titolo non può esser vuoto");
            }
            else titolo = value;
        }
    }

    public DateTime Data
    {
        get
        {
            return data;
        }

        set
        {
            if (value < DateTime.Today)
            {
                throw new ArgumentException("La data non può esser già passata.");
            }
            else data = value;
        }
    }

    public int CapienzaMassima
    {
        get
        {
            return capienzaMassima;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("La capienza massimo deve esser un valore positivo");
            }
            else capienzaMassima = value;
        }
    }


    public Evento (string titolo, DateTime data, int capienza){
        Titolo = titolo;
        Data = data;
        CapienzaMassima = capienza;
        PostiPrenotati = 0;
    }
    
}