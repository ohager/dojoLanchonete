using System;
using System.Collections.Generic;

namespace dojoLanchonete
{
	public class XBacon : Lanche{

		public XBacon() : base(ingredientesXBacon()) {
		}

		private static List<Ingrediente> ingredientesXBacon() {
			List<Ingrediente> ingredientes = new List<Ingrediente>();
			ingredientes.Add(Ingrediente.HamburguerCarne);
			ingredientes.Add(Ingrediente.Bacon);
			ingredientes.Add(Ingrediente.Queijo);
			ingredientes.Add(Ingrediente.Alface);
			return ingredientes;
		}
	}
}

