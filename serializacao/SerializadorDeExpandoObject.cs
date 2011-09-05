using System.Dynamic;

namespace serializacao
{
	public class SerializadorDeExpandoObject : Serializador
	{
		public SerializadorDeExpandoObject()
			: base()
		{
		}

		public override string Serializa()
		{
			dynamic dto = new ExpandoObject();

			dto.Chave = 1;
			dto.Valor = "Teste";

			serializer.Serialize(writer, dto);

			var json = jsonString.ToString();
			jsonString.Clear();

			return json;
		}
	}
}