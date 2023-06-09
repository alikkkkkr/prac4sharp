using Newtonsoft.Json;

namespace deserLib
{
    public class Class1
    {
        public static T deserializ<T>(string p)
        {
            string json = File.ReadAllText(p);
            T json_text = JsonConvert.DeserializeObject<T>(json);
            return json_text;
        }

        public static void serializ<T>(T items_zametki, string p)
        {
            string json = JsonConvert.SerializeObject(items_zametki);
            File.WriteAllText(p, json);
        }
    }
}