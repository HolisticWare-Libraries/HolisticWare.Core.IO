namespace Core.IO.FileSystems
{
    using System.Collections.Generic;

    /// <summary>
    /// FileSystem Abstractions
    /// FileSystem
    /// </summary>
    public partial class
                                        FileSystem
    {
        public
            string?
                                        Name
        {
            get;
            set;
        }

        public
            IEnumerable<FileSystemItem>?
                                        FileSystemItems
        {
            get;
            set;
        }
    }
}
