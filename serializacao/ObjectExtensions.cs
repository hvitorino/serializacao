namespace serializacao
{
	public static class ObjectExtensions
	{
		public static DynamicObjectBuilder<T> ToDto<T>(this T objeto)
			where T : class
		{
			return new DynamicObjectBuilder<T>(objeto);
		}
	}
}