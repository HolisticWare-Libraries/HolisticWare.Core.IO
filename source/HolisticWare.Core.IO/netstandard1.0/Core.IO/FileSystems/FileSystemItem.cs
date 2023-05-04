namespace Core.IO.FileSystems
{
    using System.Collections.Generic;

    /// <summary>
    /// FileSystem Abstractions
    /// Directory
    /// </summary>
    public partial class FileSystemItem
    {
        public IEnumerable<FileSystemItem> FileSystemItems
        {
            get;
            set;
        }
    }
}
