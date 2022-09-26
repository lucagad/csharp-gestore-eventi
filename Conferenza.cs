public class Conferenza : Evento
{
    public string Relatore { get; set; }
    public double Prezzo { get; set; }

   
    public Conferenza(string relatore, double prezzo)
    {
        Relatore = relatore;
        Prezzo = prezzo;

    }

}

