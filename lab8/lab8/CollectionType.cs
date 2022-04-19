using System;
using System.Collections.Generic;
using System.IO;

namespace lab8
{
    public class CollectionType<T> : IUser<T> where T : class
    {
        private string FilePath = @"C:\Users\User\Desktop\GitHub\oop\lab8\lab8\file.txt";

        private readonly List<T> _list = new List<T>();

        public void Add(T elem)
        {
            _list.Add(elem);
        }

        public void Remove(T elem)
        {
            _list.Remove(elem);
        }

        public void View()
        {
            foreach (var elem in _list)
            {
                Console.WriteLine(elem);
            }
        }

        public void WriteFile()
        {
            using (StreamWriter sw = new StreamWriter(FilePath, false, System.Text.Encoding.Default))
            {
                foreach (var elem in _list)
                {
                    sw.WriteLine(elem);
                }
            }
        }

        public void ReadFile()
        {
            using (StreamReader sr = new StreamReader(FilePath, System.Text.Encoding.Default))
            {
                sr.ReadToEnd();
            }
        }
    }
}