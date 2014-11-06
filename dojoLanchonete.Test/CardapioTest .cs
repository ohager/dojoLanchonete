using NUnit.Framework;
using System;

namespace dojoLanchonete.Test
{

	[TestFixture]
	public class CardapioTest 
	{

		[Test]
		public void testPrecosCardapio() {

			Assert.AreEqual(3.2, new XBacon().preco(), 0.01);
			Assert.AreEqual(2.7, new XEgg().preco(), 0.01);
			Assert.AreEqual(2.1, new XFrango().preco(), 0.01);
			Assert.AreEqual(4.9, new XTudo().preco(), 0.01);
		}

		[Test]
		public void testCarneOvoAlface() {

			Lanche lancheNovo = new Lanche();

			lancheNovo.add(Ingrediente.Ovo);
			lancheNovo.add(Ingrediente.Alface);
			lancheNovo.add(Ingrediente.HamburguerCarne);

			Assert.AreEqual(1.9, lancheNovo.preco(), 0.01);
		}

		[Test]
		public void testPromocaoDoubleCarneGanhaBacon() {

			Lanche lancheNovo = new Lanche();

			lancheNovo.add(Ingrediente.Ovo);
			lancheNovo.add(Ingrediente.Alface);
			lancheNovo.add(Ingrediente.HamburguerCarne);
			lancheNovo.add(Ingrediente.HamburguerCarne);
			lancheNovo.add(Ingrediente.Bacon);

			Assert.AreEqual(3.2, lancheNovo.preco(), 0.01);
		}
	}
}

