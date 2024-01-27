using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;

namespace InfoViewer

{
    public static class ExtensionMethods
    {
        public static int Remove<T>(this ObservableCollection<T> coll, Func<T, bool> condition)
        {
            var itemsToRemove = coll.Where(condition).ToList();

            foreach (var itemToRemove in itemsToRemove)
            {
                coll.Remove(itemToRemove);
            }

            return itemsToRemove.Count;
        }


        // Конвертирование Анонимного List to List<T>
        // https://www.codeproject.com/Articles/38635/Converting-anonymous-types-to-any-type
        public static List<TConverted> ToNonAnonymousList<TOriginal, TConverted>(this List<TOriginal> originalList, List<TConverted> convertedList)
            where TOriginal : class
            where TConverted : class
        {
            //loop through the calling list:
            foreach (TOriginal item in originalList)
            {
                //convert each object of the list into TConverted object by calling extension ToType<TConverted>()
                //Add this object to newly created list:
                convertedList.Add(item.ToType<TConverted>());
            }
            //return List of TConverted objects:
            return convertedList;
        }
        public static TConverted ToType<TConverted>(this object originalObj)
            where TConverted : class
        {
            //create instance of TConverted type object:
            TConverted convertedObj = Activator.CreateInstance<TConverted>();

            //loop through the properties of the object you want to covert:          
            foreach (PropertyInfo pi in originalObj.GetType().GetProperties())
            {
                try
                {
                    //get the value of property and try to assign it to the property of TConverted type object:
                    convertedObj.GetType().GetProperty(pi.Name).SetValue(convertedObj, pi.GetValue(originalObj, null), null);
                }
                catch { }
            }
            //return the TConverted type object:         
            return convertedObj;
        }
    }
}
