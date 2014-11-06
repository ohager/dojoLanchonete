using System;

namespace dojoLanchonete
{
	public class Ingrediente
	{

		double preco;

		public double Preco {
			get {
				return preco;
			}
		}

		public Ingrediente (double preco)
		{
			this.preco = preco;
		}

		public static Ingrediente HamburguerCarne = new Ingrediente(1.3);
		public static Ingrediente HamburguerFrango = new Ingrediente(1.2);
		public static Ingrediente Bacon  = new Ingrediente(1.0);
		public static Ingrediente Queijo  = new Ingrediente(0.8);
		public static Ingrediente Ovo  = new Ingrediente(0.5);
		public static Ingrediente Alface  = new Ingrediente(0.1);
	}
}


