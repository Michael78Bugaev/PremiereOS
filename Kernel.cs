using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace PremiereOS
{
    public class Kernel : Sys.Kernel
    {
        CosmosVFS fs = new CosmosVFS();
        protected override void BeforeRun()
        {
            VFSManager.RegisterVFS(fs);
        }

        protected override void Run()
        {
            
        }
    }
}
