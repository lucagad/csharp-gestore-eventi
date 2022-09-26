﻿
//MILESTONE 1
#region
//Per prima cosa è necessario creare una classe Evento che abbia i seguenti attributi:
// - titolo (OK)
// - data (OK)
// - capienza massima dell’evento (OK)
// - numero di posti prenotati (OK)

//Aggiungere metodi getter e setter in modo che:
// - titolo sia in lettura e in scrittura (OK)
// - data sia in lettura e scrittura (OK)
// - numero di posti per la capienza massima sia solo in lettura (OK)
// - numero di posti prenotati sia solo in lettura (OK)
//ai setters inserire gli opportuni controlli in modo che la data non sia già passata, che il titolo non sia vuoto e che la capienza massima di posti sia un numero positivo. (OK)
//In caso contrario sollevare opportune eccezioni.

//Dichiarare un costruttore che prenda come parametri il titolo, la data e i posti a disposizione e inizializza gli opportuni attributi facendo uso dei metodi e controlli già fatti.
//Per l’attributo posti prenotati invece si occupa di inizializzarlo lui a 0. (OK)
#endregion

//Vanno inoltre implementati dei metodi public che svolgono le seguenti funzioni:
//1. PrenotaPosti: aggiunge i posti passati come parametro ai posti prenotati. Se l’evento è già passato o non ha posti o non ha più posti disponibili deve sollevare un’eccezione.
//2. DisdiciPosti: riduce del i posti prenotati del numero di posti indicati come parametro. Se l’evento è già passato o non ci sono i posti da disdire sufficienti, deve sollevare un’eccezione.
//3. l’override del metodo ToString() in modo che venga restituita una stringa contenente: data formattata – titolo
//   Per formattare la data correttamente usate nomeVariabile.ToString("dd/MM/yyyy"); applicata alla vostra variabile DateTime.

//Le eccezioni possono essere generiche (Exception) o usate quelle già messe a disposizione da C#, ma aggiungete un eventuale messaggio chiaro per comunicare che cosa è successo.
//Vi ricordo che man mano che andrete avanti con le altre milestones, potrete aggiungere più avanti altri eventuali metodi (public e private) che vi aiutino a svolgere le funzioni richieste se ritenete necessari!


public class Evento
{
    private string titolo;
    private DateTime data;
    private int capienzaMassima;

    protected int postiPrenotati;

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

    protected int CapienzaMassima
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

    protected int PostiPrenotati
    {
        get
        {
            return postiPrenotati;
        }

        set
        {
            postiPrenotati = value;
        }
    }

    public Evento (string titolo, DateTime data, int capienza){
        Titolo = titolo;
        Data = data;
        CapienzaMassima = capienza;
        PostiPrenotati = 0;
    }

    //public Evento()
    //{
    //}

    public void PrenotaPosti(int posti)
    {
        if (PostiPrenotati <= (CapienzaMassima - posti))
        {
            this.PostiPrenotati = PostiPrenotati + posti;
        }
        else throw new ArgumentException("Non è possibile prenotare i posti, capienza massima raggiunta");
    }

    public void DisdiciPosti(int posti)
    {
        if (PostiPrenotati >= posti && data > DateTime.Today)
        {
            this.PostiPrenotati = PostiPrenotati - posti;
        }
        else throw new ArgumentException("Non è possibile disdire i posti");
    }

    public string StampaPosti()
    {
        string stringa = " \n";
        stringa += "Numero di Posti Prenotati: " + this.postiPrenotati + "\n";
        stringa += "Numero di Posti Disponibili: " + (this.CapienzaMassima - this.postiPrenotati) + "\n";
        stringa += " ";

        return stringa;
    }

    public override string ToString()
    {
        string stringa = "------ Evento ------\n";
        stringa += this.data.ToString("dd/MM/yyyy") + " - " + this.titolo + "\n";
        stringa += "-------------------";

        return stringa;
    }

}