using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utilities
{
    public static class FileOperationsExtension
    {
        public static string GetUniqueFilePath(string path, string fileNameAndExt)
        {
            if (String.IsNullOrEmpty(path) || String.IsNullOrEmpty(fileNameAndExt))
                return null;

            if (IsValidPath(path) == false)
                return null;

            if (path.Length + fileNameAndExt.Length> 240)
                return null;
            if (path.Substring(path.Length-1, 1) != "\\")
                path = path + "\\";

            var fileExt = Path.GetExtension(fileNameAndExt);
            var fileName = Path.GetFileNameWithoutExtension(fileNameAndExt);

            return $"{CleanPath(path)}{CleanFileName(fileName)}_{CalendarExtensions.CreatePersianTimeStamp()}{CleanFileName(fileExt)}";
        }

        public static bool IsValidPath(string path)
        {
            try
            {
                var result = Path.GetFullPath(path);
            }
            catch (Exception ex)
            {
                var result = ex.Message; // just for resolving unused variablr warning.
                return false;
            }
            return true;
        }

        public static string CleanFileName (string fileName)
        {
            return string.Join("", fileName.Split(Path.GetInvalidFileNameChars()));
        }

        public static string CleanPath(string path)
        {
            return string.Join("", path.Split(Path.GetInvalidPathChars()));
        }
    }
}
