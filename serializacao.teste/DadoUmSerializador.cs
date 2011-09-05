using NUnit.Framework;

namespace serializacao.teste
{
	[TestFixture]
	public class DadoUmSerializador
	{
		[TestCase]
		public void PossoSerializarObjetoEmFormatoJson()
		{
			var serializador = new SerializadorDeObjeto();
			string json = serializador.Serializa();

			Assert.That(json, Is.EqualTo("{\"Chave\":1,\"Valor\":\"Teste\"}"));
		}

		[TestCase]
		public void PossoSerializarUmObjectCriadoComDynamicObjectBuilder()
		{
			var serializador = new SerializadorDeObject();
			string json = serializador.Serializa();

			Assert.That(json, Is.EqualTo("{\"Chave\":1,\"Valor\":\"Teste\"}"));
		}

		[TestCase]
		public void PossoSerializarUmObjetoAnonimo()
		{
			var serializador = new SerializadorDeAnonimos();
			string json = serializador.Serializa();

			Assert.That(json, Is.EqualTo("{\"Chave\":1,\"Valor\":\"Teste\"}"));
		}

		[TestCase]
		public void PossoSerializarUmExpandoObject()
		{
			var serializador = new SerializadorDeExpandoObject();
			string json = serializador.Serializa();

			Assert.That(json, Is.EqualTo("{\"Chave\":1,\"Valor\":\"Teste\"}"));
		}
	}
}