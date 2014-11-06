using System;
using System.Collections.Generic;

namespace dojoLanchonete
{
	public class Lanche {

		private List<Ingrediente> ingredientes { get; set; }

		public Lanche() {
			this.ingredientes = new List<Ingrediente> ();
		}

		public Lanche(List<Ingrediente> ingredientes) {
			this.ingredientes = ingredientes;
		}

		private bool existeIngrediente(Ingrediente i) {


			foreach (Ingrediente ingrediente in this.ingredientes) {

				if (ingrediente.Equals(i)) {
					return true;
				}
			}
			return false;
		}

		/**
     * Método que calcula o preço do lanche baseado nos valores dos ingredientes, 
     * e aplica a promoção DoubleHambuerguer ganha bacon
     * 
     * @return Um valor de preço
     */
		public double preco() {
			double s = 0.0;
			int nroCarne = 0, nroBacon = 0;

			foreach (Ingrediente ingrediente in this.ingredientes) {
				s += ingrediente.Preco;
				if (ingrediente == Ingrediente.HamburguerCarne) {
					nroCarne++;
				} else if (ingrediente == Ingrediente.Bacon) {
					nroBacon++;
				}
			}

			while (nroCarne >= 2 && nroBacon > 0) {
				s = s - Ingrediente.Bacon.Preco;
				nroCarne -= 2;
				nroBacon--;
			}

			/*   do  {
            s = s - Ingrediente.Alface.preco();
            nroBacon++; 
            nroCarne = 1;
           } while ((nroCarne >= 2 && nroAlface > 0)) 
        */

			return s;
		}

		public void add(Ingrediente ingrediente) {
			//if (!existeIngrediente(ingrediente)) {
			this.ingredientes.Add(ingrediente);
			//}
		}


	}
}

