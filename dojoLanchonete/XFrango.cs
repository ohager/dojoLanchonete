using System;
using System.Collections.Generic;

namespace dojoLanchonete
{
	public class XFrango : Lanche {

		public XFrango() : base(ingredientesXFrango()) {

		}

		private static List<Ingrediente> ingredientesXFrango() {
			List<Ingrediente> ingredientes = new List<Ingrediente>();
			ingredientes.Add(Ingrediente.HamburguerFrango);
			ingredientes.Add(Ingrediente.Queijo);
			ingredientes.Add(Ingrediente.Alface);

			return ingredientes;
		}
	}
}

