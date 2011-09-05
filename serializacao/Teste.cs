using System;

namespace serializacao
{
	public class Teste
	{
		public static void Main(params string[] args)
		{
			const int ciclos = 3;
			const int dezMil = 10000;
			const int cemMil = 100000;

			Console.WriteLine("Serialização");
			Console.WriteLine();
			Console.WriteLine("10k chamadas");

			Executa(dezMil, ciclos,
				new SerializadorDeAnonimos(),
				new SerializadorDeObject(),
				new SerializadorDeObjeto(),
				new SerializadorDeExpandoObject());

			2.Vezes(Console.WriteLine);

			Console.WriteLine("100k chamadas");

			Executa(cemMil, ciclos,
				new SerializadorDeAnonimos(),
				new SerializadorDeObject(),
				new SerializadorDeObjeto(),
				new SerializadorDeExpandoObject());

			Console.ReadLine();
		}

		public static void Executa(int execucoes, int ciclos, params Serializador[] serializadores)
		{
			foreach (var serializador in serializadores)
			{
				using (serializador)
				{
					Console.WriteLine("Tipo: " + serializador.GetType().Name);

					for (int i = 0; i < ciclos; i++)
					{
						var inicio = DateTime.Now;
						execucoes.Vezes(() => serializador.Serializa());
						var fim = DateTime.Now;
						var total = fim.Subtract(inicio).Milliseconds;

						Console.WriteLine(string.Format("[Ciclo {0}] --> {1}: {2} ms",
														i + 1, serializador.GetType().Name, total));
					}

					2.Vezes(Console.WriteLine);
				}
			}
		}
	}

	public static class IntExtensions
	{
		public static void Vezes(this int quantidade, Action action)
		{
			for (int i= 0; i < quantidade; i++)
				action.Invoke();
		}
	}
}