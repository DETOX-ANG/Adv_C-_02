using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics.Modelo;
using System.IO;
using System.Web.Script.Serialization;

namespace Generics {
    class Serializadora {

        public static void Serializar(object obj) {
            StreamWriter writer = new StreamWriter($@"E:\Temp\Writer\Class_{obj.GetType().Name}_JSON.json");
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string objSerialized = serializer.Serialize(obj);
            writer.WriteLine(objSerialized);
            writer.Close();
        }

        //Criando uma classe generica
        public static T Deserializar<T>() {

            //Ao isntanciar o reader abaixo, eu indico que o nome do arquivo se refere ao nome da classe T que será especificada na hora da declaração.
            StreamReader reader = new StreamReader($@"E:\Temp\Writer\Class_{typeof(T).Name}_JSON.json");
            string conteudo = reader.ReadToEnd();

            JavaScriptSerializer deserializer = new JavaScriptSerializer();
            T obj = (T)deserializer.Deserialize(conteudo,typeof(T));

            return obj;
        }

    }
}
