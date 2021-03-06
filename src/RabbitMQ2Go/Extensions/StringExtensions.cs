﻿using System.IO;

namespace RabbitMQ2Go.Extensions
{
    public static class StringExtensions
    {
        public static string MakePathForCmd(this string path)
        {
            return path.TrimEnd(Path.DirectorySeparatorChar).Replace(Path.DirectorySeparatorChar.ToString(), "\\" + Path.DirectorySeparatorChar);
        }
    }
}
