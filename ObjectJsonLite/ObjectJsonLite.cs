using System;
using System.Reflection;
using System.Text;

namespace ObjectJsonLite
{
    public class ObjectJsonLite
    {
        public static string Serialize(object obj, bool ignoreNull = false)
        {
            object _temp = obj;
            StringBuilder jsonString = new StringBuilder("{"); //start json string
            foreach (var prop in _temp.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static))
            {
                PropertyToString(prop, _temp, jsonString, ignoreNull);
            }
            //remove trailing comma and close out json object
            jsonString.Length--;
            jsonString.Append("}");
            return jsonString.ToString();
        }
        private static void PropertyToString(PropertyInfo prop, object _temp, StringBuilder jsonString, bool ignoreNull)
        {
            object sub = prop.GetValue(_temp);
            if (sub != null)
            { //not null value
                var subType = sub.GetType();
                var subProps = subType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
                jsonString.Append($"\"{prop.Name}\":");
                if (subProps.Length == 0 || (subType == typeof(string)))
                {
                    jsonString.Append($"\"{prop.GetValue(_temp)}\",");
                }
                else
                {
                    jsonString.Append("{");
                    foreach (var property in subProps)
                    {
                        _temp = sub;
                        PropertyToString(property, _temp, jsonString, ignoreNull);
                    }
                    jsonString.Length--;
                    jsonString.Append("},");
                }
            }
            else if (!ignoreNull)
            { //null value --print if ignoreNull = false
                jsonString.Append($"\"{prop.Name}\":\"null\",");
            }
        }
    }
}
