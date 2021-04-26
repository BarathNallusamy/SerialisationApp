using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerialisationApp
{
    class JSON_S
    {
        static readonly string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        static void Main(string[] args)
        {
            //create a trainee
            Trainee t1 = new Trainee { FirstName = "Barath", LastName = "Nallusamy", SpartaNo = 101 };
            SerializeToFileJSON(t1);

            //Trainee t2 = DeSerializeFromFileJSON("101 - Barath Nallusamy.json");

            //create a course
            Course eng83 = new Course { Title = "Engineering 83", Subject = "C# SDET", StartDate = new DateTime(2021, 3, 16) };
            eng83.AddTrainee(t1);
            eng83.AddTrainee(new Trainee { FirstName = "Martin", LastName = "Beard", SpartaNo = 102 });
            SerializeToFileJSON(eng83);

            Course otherCourse = DeSerializeCourseFromFileJSON("NewCourse.json");
        }

        private static Trainee DeSerializeFromFileJSON(string fileName)
        {
            //create a file path
            var filePath = $"{_path}/{fileName}";
            string jsonString = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Trainee>(jsonString);
        }

        private static Course DeSerializeCourseFromFileJSON(string fileName)
        {
            //create a file path
            var filePath = $"{_path}/{fileName}";
            string jsonString = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Course>(jsonString);
        }

        private static void SerializeToFileJSON(object o)
        {
            //create the file path
            var filePath = $"{_path}/{o}.json";
            string jsonString = JsonConvert.SerializeObject(o);
            File.WriteAllText(filePath, jsonString);
        }
    }
}
