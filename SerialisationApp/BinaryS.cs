//using System;
//using System.IO;
//using System.Runtime.Serialization.Formatters.Binary;

//namespace SerialisationApp
//{
//    class BinaryS
//    {
//        static readonly string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

//        static void Main(string[] args)
//        {
//            //create a trainee
//            Trainee t1 = new Trainee { FirstName = "Barath", LastName = "Nallusamy", SpartaNo = 101 };
//            SerializeToFileBinary(t1);

//            Trainee t2 = DeSerializeFromFileBinary("BinaryTrainee.bin");

//        }

//        private static Trainee DeSerializeFromFileBinary(string fileName)
//        {
//            //create a file path
//            var filePath = $"{_path}/{fileName}";

//            //create a stream for reading
//            Stream file = File.OpenRead(filePath);

//            //create the binary formatter and use it to read the file
//            BinaryFormatter reader = new BinaryFormatter();
//            var trainee = (Trainee)reader.Deserialize(file);
//            file.Close();
//            return trainee;
//        }

//        private static void SerializeToFileBinary(object o)
//        {
//            //create the file path
//            var filePath = $"{_path}/BinaryTrainee.bin";

//            //create a file stream object
//            FileStream file = File.Create(filePath);

//            //create a binary formatter object, and use it to serialize the trainee object to file
//            BinaryFormatter writer = new BinaryFormatter();
//            writer.Serialize(file, o);
//            file.Close();
//        }
//    }
//}
