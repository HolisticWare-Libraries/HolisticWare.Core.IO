namespace Core.IO
{
    public partial class
                                        Directory
    {
        /// <summary>
        /// https://yetanotherchris.dev/csharp/6-ways-to-get-the-current-directory-in-csharp/
        /// </summary>
        public static
            System.Collections.Generic.Dictionary<string, string>
                                        Current
        {
            get;
            set;
        }

        static
                                        Directory
                                            (
                                            )
        {
            Current = new System.Collections.Generic.Dictionary<string, string>
            {
                // #if NETSTANDARD1_3
                {
                    "System.IO.Directory.GetCurrentDirectory()",
                    System.IO.Directory.GetCurrentDirectory()
                },
                {
                    "System.AppContext.BaseDirectory",
                    System.AppContext.BaseDirectory
                },
                // #endif
                // #if NETSTANDARD2_0
                {
                    "AppDomain.CurrentDomain.BaseDirectory",
                    System.AppDomain.CurrentDomain.BaseDirectory
                },
                {
                    "System.Environment.CurrentDirectory",
                    System.Environment.CurrentDirectory
                },
                {
                    "typeof(Directory).Assembly.GetType().Assembly.Location",
                    typeof(Directory).Assembly.GetType().Assembly.Location
                },
                // #endif
                #if WINDOWS_FORMS
                {
                    "",
                    Application.ExecutablePath
                },
                {
                    "",
                    Application.StartupPath
                },
                #endif
            };

            return;
        }

    }
}
