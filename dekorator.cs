abstract class Pudelko 
{
	public int Rozmiar {get; set;}
	
	public abstract void EfektKoncowy();
}

class Prezent : Pudelko 
{
	private string adresat;
	
	public Prezent (string imie, int dlBoku)
	{
		this.adresat = imie; 
		this.Rozmiar = dlBoku;
	}
	
	public override void EfektKoncowy()
	{
		Console.WriteLine("Adresat : " + this.adresat + "Rozmiar : " + this.Rozmiar);
	}
}

abstract class Dekorator : Pudelko
{
	protected Pudelko pudelko;
	
	public Dekorator (Pudelko pudelko)
	{
		this.pudelko = pudelko;
	}
	
	public override void EfektKoncowy()
	{
		pudelko.EfektKoncowy();
	}
}

class Dekoracje : Dekorator
{
	protected List<string> dekoracjeLista = new List<string>();
	
	public Dekoracje (Pudelko pudelko) : base (pudelko)
	{		
	}
	
	public void DodajPapier(string Kolor)
	{
		if (Kolor == string.Empty) //string.IsNullOrEmpty(Kolor)
		{
			Kolor = "Niebieski";
		}
		dekoracjeLista.Add("Papier "+Kolor); 	
				
	}
	
	public void DodajWstazke(string Kolor)
	{
		if (Kolor == string.Empty) //string.IsNullOrEmpty(Kolor)
		{
			Kolor = "Biała";
		}
		dekoracjeLista.Add("Wstążka "+Kolor); 	
				
	}
	
	public override void EfektKoncowy()
	{
		base.EfektKoncowy();
		Console.WriteLine(string.Join(", ", dekoracjeLista.ToArray()));
	}
	
}