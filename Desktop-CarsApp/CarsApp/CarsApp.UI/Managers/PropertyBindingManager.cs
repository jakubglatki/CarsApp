﻿using LGBS.MVPFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarsApp.UI.Managers
{
    public static class PropertyBindingManager
    {

		#region Protected methods



		/// <summary>
		/// Bindowanie danych z różnych tabel.
		/// </summary>
		/// <param name="property">obiekt.</param>
		/// <param name="propertyName">nazwa.</param>
		public static string BindProperty(object property, string propertyName)
		{
			string retValue;

			retValue = "";

			if (propertyName.Contains("."))
			{
				if (property == null)
					return retValue;

					PropertyInfo[] arrayProperties;
					string leftPropertyName;

					leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
					arrayProperties = property.GetType().GetProperties();

					foreach (PropertyInfo propertyInfo in arrayProperties)
					{
						if (propertyInfo.Name == leftPropertyName)
						{
							retValue = BindProperty(propertyInfo.GetValue(property, null), propertyName.Substring(propertyName.IndexOf(".") + 1));
							break;
						}
					}
				
			}
			else
			{
				if (property == null)
					return retValue;

				Type propertyType;
				PropertyInfo propertyInfo;

				propertyType = property.GetType();
				propertyInfo = propertyType.GetProperty(propertyName);
				retValue = propertyInfo.GetValue(property, null).ToString();
			}

				return retValue;
			
		}

		#endregion Protected methods
	}
}
