using System;
using System.Collections.Generic;

namespace dojoLanchonete
{
	public class XEgg : Lanche {

		public XEgg() : base(ingredienterXEgg()) {
		}

		private static List<Ingrediente> ingredienterXEgg() {
			List<Ingrediente> ingredientes = new List<Ingrediente>();
			ingredientes.Add(Ingrediente.HamburguerCarne);
			ingredientes.Add(Ingrediente.Queijo);
			ingredientes.Add(Ingrediente.Ovo);
			ingredientes.Add(Ingrediente.Alface);

			return ingredientes;
		}
	}
}

