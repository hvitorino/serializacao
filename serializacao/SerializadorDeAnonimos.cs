namespace serializacao
{
	public class SerializadorDeAnonimos : Serializador
	{
		public SerializadorDeAnonimos()
			: base()
		{
		}

		public override string Serializa()
		{
			var objeto = new
							{
								Chave = 1,
								Valor = "Teste"
							};

			serializer.Serialize(writer, objeto);

			var json = jsonString.ToString();
			jsonString.Clear();

			return json;
		}
	}
}