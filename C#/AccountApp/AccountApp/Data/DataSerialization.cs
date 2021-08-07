using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AccountApp.Data
{
    class DataSerialization
    {
        public void Serialization(Object obj)
        {
            FileStream serializeDataFile;
            BinaryFormatter formatter = new BinaryFormatter();
            if(File.Exists("SerializedData.Txt"))
            {
                File.Delete("SerializedData.Txt");
            }
            serializeDataFile = File.Create("SerializedData.Txt");
            formatter.Serialize(serializeDataFile, obj);
            serializeDataFile.Close();
        }

        public object Deserialization()
        {
            Object obj = null;
            FileStream serializedDataFile;
            BinaryFormatter formatter = new BinaryFormatter();
            if (File.Exists("SerializedData.Txt"))
            {
                serializedDataFile = File.OpenRead("SerializedData.Txt");
                obj = formatter.Deserialize(serializedDataFile);
                serializedDataFile.Close();
            }


                return obj;
        }
    }
}
