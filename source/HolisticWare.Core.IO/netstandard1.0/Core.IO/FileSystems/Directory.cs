namespace Core.IO.FileSystems
{
    using System.Collections.Generic;

    /// <summary>
    /// FileSystem Abstractions
    /// Directory is FileSystemItem
    /// </summary>
    public partial class
                                        Directory
                                        :
                                        FileSystemItem
    {
        public
            IEnumerable<FileSystemItem>?
                                        FileSystemItems
        {
            get;
            set;
        }


    }
}
