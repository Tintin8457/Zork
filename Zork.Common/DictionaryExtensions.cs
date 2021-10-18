using System.Collections.Generic;

namespace Zork
{
    public static class DictionaryExtensions
    {
        public static TValue GetValueOrDefault<Tkey, TValue>(this IDictionary<Tkey, TValue> dictionary, Tkey key, TValue defaultValue = default)
        {
            return dictionary != null && key != null && dictionary.TryGetValue(key, out TValue value) ? value : defaultValue;
        }
    }
}
