using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BasicHelper.Extentions
{
    public static class BasicExtentions
    {
        public static T? DeepClone<T>(this T obj) where T : class?
        {
            if (obj is null) return default;

            // Serialize the object to JSON
            string json = JsonSerializer.Serialize(obj);

            // Deserialize the JSON to a new object
            T? newObj = JsonSerializer.Deserialize<T>(json);

            return newObj;
        }

        public static Span<T> ToSpan<T>(this T[] s)
        {
            Memory<T> memory = new(s);
            return memory.Span;
        }
    }
}
