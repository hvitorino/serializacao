namespace serializacao
{
	public class SerializadorDeObject : Serializador
	{
		public SerializadorDeObject()
			: base()
		{
		}

		public override string Serializa()
		{
			var dto = new object().ToDto()
				.Include("Chave", 1)
				.Include("Valor", "Teste")
				.Build();

			serializer.Serialize(writer, dto);

			var json = jsonString.ToString();
			jsonString.Clear();

			return json;
		}
	}
}