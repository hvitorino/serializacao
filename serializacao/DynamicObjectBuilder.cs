using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace serializacao
{
	public class DynamicObjectBuilder<T>
	{
		private const BindingFlags FLAGS = BindingFlags.Public | BindingFlags.Instance;
		private readonly dynamic objetoCriado;
		private readonly IDictionary<string, object> propriedades;
		private readonly object source;
		private readonly Type sourceType;

		public DynamicObjectBuilder(object source)
		{
			this.source = source;
			objetoCriado = new ExpandoObject();
			propriedades = (IDictionary<String, Object>) objetoCriado;
			sourceType = typeof(T);

			BuildObjectDom(sourceType.GetProperties(FLAGS));
		}

		public void BuildObjectDom(PropertyInfo[] properties)
		{
			foreach (PropertyInfo propertyInfo in properties)
			{
				propriedades.Add(propertyInfo.Name, null);
			}
		}

		public DynamicObjectBuilder<T> Include(string propertyName, object propertyValue)
		{
			propriedades.Add(propertyName, propertyValue);
			return this;
		}

		public DynamicObjectBuilder<T> Exclude<TProperty>(Expression<Func<T, TProperty>> expression)
		{
			var parameterExpression = expression.Body as MemberExpression;

			propriedades.Remove(parameterExpression.Member.Name);
			return this;
		}

		public dynamic Build()
		{
			for (int i = 0; i < propriedades.Count; i++)
			{
				KeyValuePair<string, object> property = propriedades.ElementAt(i);
				PropertyInfo objProperty = sourceType.GetProperty(property.Key);
				if (objProperty != null)
				{
					object propertyValue = objProperty.GetValue(source, null);
					propriedades[ property.Key ] = propertyValue;
				}
			}
			return objetoCriado;
		}

		private bool EhStringENaoPrimitivo(PropertyInfo objProperty)
		{
			return !objProperty.PropertyType.IsPrimitive && objProperty.PropertyType.Name != typeof(String).Name && objProperty.PropertyType.Name != typeof(DateTime).Name;
		}
	}
}