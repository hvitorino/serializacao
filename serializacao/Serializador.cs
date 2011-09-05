using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace serializacao
{
	public abstract class Serializador : ISerializador, IDisposable
	{
		protected readonly JsonSerializer serializer;
		protected readonly StringBuilder jsonString;
		protected readonly JsonTextWriter writer;

		protected Serializador()
		{
			serializer = new JsonSerializer();
			jsonString = new StringBuilder();
			writer = new JsonTextWriter(new StringWriter(jsonString));
		}

		public void Dispose()
		{
			if (writer != null)
				writer.Close();
		}

		public abstract string Serializa();
	}
}