using System;
using System.Collections.Generic;

namespace dojoLanchonete
{
	public class XTudo : Lanche {

		public XTudo() : base(ingredientesXTudo()){

		}

		private static List<Ingrediente> ingredientesXTudo() {
			List<Ingrediente> ingredientes = new List<Ingrediente>();
			ingredientes.Add(Ingrediente.HamburguerCarne);
			ingredientes.Add(Ingrediente.HamburguerFrango);
			ingredientes.Add(Ingrediente.Bacon);
			ingredientes.Add(Ingrediente.Queijo);
			ingredientes.Add(Ingrediente.Ovo);
			ingredientes.Add(Ingrediente.Alface);

			return ingredientes;
		}
	}
}

