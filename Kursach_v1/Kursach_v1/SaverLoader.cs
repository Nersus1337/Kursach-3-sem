﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Kursach_v1
{
    internal class SaverLoader
    {
        public static void Save<T>(T obj, string filePath)
        {
            using (var fs = File.OpenWrite(filePath))
                new BinaryFormatter().Serialize(fs, obj);
        }

        //// <summary>
        //// Чтение объекта из файла
        //// </summary>

        public static T Load<T>(string filePath)
        {
            using (var fs = File.OpenRead(filePath))
                return (T)new BinaryFormatter().Deserialize(fs);
        }

    }
}