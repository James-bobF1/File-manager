﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_manager
{
    public static class Command
    {
        public static CommandLinePattern WithName(string name)
        {
            return new CommandLinePattern
            {
                Name = name,
                Parameters = new List<string>(),
                Options = new List<string>(),
            };
        }
    }
}