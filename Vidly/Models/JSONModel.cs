﻿namespace Vidly.Models
{
    public class JSONModel
    {
        public class Rootobject
        {
            public Logging Logging { get; set; }
            public string AllowedHosts { get; set; }
            public string MyToDo { get; set; }
        }

        public class Logging
        {
            public Loglevel LogLevel { get; set; }
        }

        public class Loglevel
        {
            public string Default { get; set; }
            public string MicrosoftAspNetCore { get; set; }
        }

    }
}
