using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppReactor.Components;

class AppShell : Component
{
    public override VisualNode Render()
    {
        return Shell(            
            ShellContent("Home", ()=> new MainPage())
                .Route("MainPage")
        );
    }
}
