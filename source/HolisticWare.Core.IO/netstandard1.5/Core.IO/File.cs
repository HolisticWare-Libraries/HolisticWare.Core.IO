namespace Core.IO.Files.Textual
{
    using System.Collections.Generic;

    /// <summary>
    /// File API for reading textual (large) files
    /// replace System.IO with Core.IO.Files.Textual
    /// </summary>
    public partial class
                                        File
    {
        public static
            string[]
                                        ReadAllLines
                                            (
                                                string path
                                            )
        {
            List<string> lines = new List<string>();

            using (System.IO.FileStream stream = System.IO.File.OpenRead(path))
            using (System.IO.BufferedStream buffered_stream = new System.IO.BufferedStream(stream))
            using (System.IO.StreamReader reader = new System.IO.StreamReader(buffered_stream))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            return lines.ToArray();
        }

        public static
            string?
                                        ReadAllText
                                            (
                                                string path
                                            )
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            using (System.IO.FileStream stream = System.IO.File.OpenRead(path))
            using (System.IO.BufferedStream buffered_stream = new System.IO.BufferedStream(stream))
            using (System.IO.StreamReader reader = new System.IO.StreamReader(buffered_stream))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    sb.AppendLine(line);
                }
            }

            return sb.ToString();
        }
    }
}
