﻿using System.IO;

namespace program
{
    public static class FilePolicySource 
    {


        public static string GetPolicyFromSource()
        {
            return File.ReadAllText("policy.json");
        }
    }
}
