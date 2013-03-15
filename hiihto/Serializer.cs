using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using perusluokat;

namespace hiihto
{
    class Serializer
    {
        public Serializer()
        {
        }

        public void SerializeObject(string filename, Hiihtokilpailu objectToSerialize)
        {
            Stream stream = File.Open(filename, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, objectToSerialize);
            stream.Close();
        }

        public Hiihtokilpailu DeSerializeObject(string filename)
        {
            Hiihtokilpailu objectToSerialize;
            Stream stream = File.Open(filename, FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            objectToSerialize = (Hiihtokilpailu)bFormatter.Deserialize(stream);
            stream.Close();
            return objectToSerialize;
        }
    }
}
