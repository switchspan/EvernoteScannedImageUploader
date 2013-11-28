using System.IO;

namespace EvernoteScannedImageUploader.Core
{
    public class EnscriptExecutor
    {
        private readonly string _enscriptPath;

        public EnscriptExecutor(string enscriptPath)
        {
            _enscriptPath = enscriptPath;
        }

        public bool IsValid()
        {
            return File.Exists(_enscriptPath);
        }
    }
}