using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonFormaterCSharp
{
    public class ConveterToJson
    {
        public static string SerializerPers(object obj)
        {
            var personType = obj.GetType();
            
            var fields = personType.GetProperties();
            string json = "";
            
            foreach (var item in fields)
            {
                var attrs = item.GetCustomAttributes(false);
                var text = "";
                if (attrs.Any(x => x.GetType() == typeof(IgnorePropertyAttribute)))
                {
                    text = "";
                    json = json + text;
                }
                else
                {
                    if (item == fields[0])
                    {
                        var name = item.Name;
                        var value = item.GetValue(obj);
                        if (value is string)
                            text = $"{{\"{name}\":\"{value}\",";
                        else
                            text = $"{{\"{name}\":{value},";
                    }
                    else if (item == fields.LastOrDefault())
                    {
                        var name = item.Name;
                        var value = item.GetValue(obj);
                        if (value is string)
                            text = $"\"{name}\":\"{value}\"}}";
                        else
                            text = $"\"{name}\":{value}}}";
                    }
                    else
                    {
                        var name = item.Name;
                        var value = item.GetValue(obj);
                        if (value is string)
                            text = $"\"{name}\":\"{value}\",";
                        else
                            text = $"\"{name}\":{value},";
                    }
                    json = json + text;
                }
            }
            return json;
        }
    }
}
