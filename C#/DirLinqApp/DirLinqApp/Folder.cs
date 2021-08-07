namespace DirLinqApp
{
    internal class Folder
    {
        private string _name;
        private long _fileSize;

        public Folder(string name, long fileSize)
         {
            _name = name;
            _fileSize = fileSize;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public long Size
        {
            get
            {
                return _fileSize;
            }
        }

    }
}