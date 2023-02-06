namespace Core.IO
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Directory is FileSystemItem
    /// </summary>
    public partial class
                                Directory
                                :
                                FileSystemItem
    {

        static
                                Directory
                                    (
                                    )
        {
            Current = new Dictionary<string, string>
            {
                {
                    "System.Environment.CurrentDirectory",
                    System.Environment.CurrentDirectory
                },
                {
                    "System.AppContext.BaseDirectory",
                    System.AppContext.BaseDirectory
                },
                {
                    "AppDomain.CurrentDomain.BaseDirectory",
                    System.AppDomain.CurrentDomain.BaseDirectory
                },
                {
                    "System.IO.Directory.GetCurrentDirectory()",
                    System.IO.Directory.GetCurrentDirectory()
                },
                {
                    "typeof(Directory).Assembly.GetType().Assembly.Location",
                    typeof(Directory).Assembly.GetType().Assembly.Location
                },
                #if WINDOWS_FORMS
                {
                    "",
                    Application.ExecutablePath
                },
                {
                    "",
                    Application.StartupPath
                },
                # endif
            };

            return;
        }


        /// <summary>
        /// https://yetanotherchris.dev/csharp/6-ways-to-get-the-current-directory-in-csharp/
        /// </summary>
        public static
            Dictionary<string, string>
                                        Current
        {
            get;

            set;
        }
    }
}
