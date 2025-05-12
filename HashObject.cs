using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HASH_Checker
{
    internal class HashObject
    {
        private string filename, filepath, hashstring = "";
        private int hashScanVersion = 0;

        internal HashObject(string filepath)
        {
            this.filepath = filepath;
            filename = Path.GetFileName(filepath);
        }

        internal static bool hasMatchingRecord(List<HashObject> list, string filePath)
        {
            return list.FirstOrDefault(h => h.FilePath.Equals(filePath, StringComparison.OrdinalIgnoreCase)) != null;
        }

        internal string FileName
        {
            get { return filename; }
        }

        internal string FilePath
        {
            get { return filepath; }
        }

        internal string HashString
        {
            set { hashstring = value.ToUpper(); }
            get { return hashstring; }
        }

        internal int HashScanVersion
        {
            set { hashScanVersion = value; }
            get { return hashScanVersion; }
        }
    }
}
