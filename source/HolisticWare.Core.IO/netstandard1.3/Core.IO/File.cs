namespace Core.IO
{
    /// <summary>
    /// File is FileSystemItem
    /// </summary>
    public partial class
                                        File
                                        :
                                        FileSystemItem
    {
        public static
            string[]
                                        ReadAllLines
                                            (
                                                string path
                                            )
        {
            using (System.IO.FileStream stream = System.IO.File.OpenRead(path))
            using (System.IO.BufferedStream buffered_stream = new System.IO.BufferedStream(stream))
            using (System.IO.StreamReader reader = new System.IO.StreamReader(buffered_stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Process the line here
                }
            }
        }
    }
}
