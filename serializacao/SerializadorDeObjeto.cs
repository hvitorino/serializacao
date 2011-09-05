namespace serializacao
{
	public class SerializadorDeObjeto : Serializador
	{
		public SerializadorDeObjeto()
			: base()
		{
		}

		public override string Serializa()
		{
			var objeto = new Objeto { Chave = 1, Valor = "Teste" };

			serializer.Serialize(writer, objeto);

			var json = jsonString.ToString();
			jsonString.Clear();

			return json;
		}
	}
}