using System.Collections.Generic;
using System.Text.Json;

namespace program{

    public static class JsonSerializetion{

       public static T  JsonToObj<T>(string stringtext){
                T? temp = JsonSerializer.Deserialize<T>(stringtext);

            return temp;
        }
    }
}