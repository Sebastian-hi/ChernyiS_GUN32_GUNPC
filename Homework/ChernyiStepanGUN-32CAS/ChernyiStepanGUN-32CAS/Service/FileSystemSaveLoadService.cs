using System;

namespace ChernyiStepanGUN_32CAS.Service
{
    internal class FileSystemSaveLoadService(string path1) : ISaveLoadService
    {
        private string _path = path1;
    }


    public interface ISaveLoadService
    {
        public void SaveData<T>(string path, T text)
        {
            using StreamWriter sw = File.CreateText(path);
            sw.Write(text);
        }

        public string? LoadData<T>(string path)
        {
            using StreamReader sr = File.OpenText(path);
            string? texts;
            while ( (texts = sr.ReadLine() ) != null)
            {
                return texts;
            }
            return null;
        }
    }
}