using System.Collections.Generic;
using System.Linq;
using LGBS.MVPFramework.Data;

namespace CarsApp.Common.ExtensionMethods
{
	public static class ExtensionMethods
	{
		/// <summary>
		/// Tworzy kolekcję obiektów zawierającą dodatkowo domyślny (pusty) obiekt.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection"></param>
		/// <returns></returns>
		public static ICollection<T> ToListWithEmptyValue<T>(this ICollection<T> collection)
			where T : IExtendedObject<T>, new()
		{
			List<T> list = collection.ToList();

			if (collection.Count == 0)
			{
				T newObj = new T();
				collection.Add(newObj.CreateEmptyObject());
			}
			else
			{
				list.Insert(0, collection.First().CreateEmptyObject());
			}

			return list;
		}
	}
}
