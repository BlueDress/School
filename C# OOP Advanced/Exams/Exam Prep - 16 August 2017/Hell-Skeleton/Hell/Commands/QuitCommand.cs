﻿using Hell.Commands;
using Hell.Interfaces.Core;
using System.Collections.Generic;

public class QuitCommand : AbstractCommand
{
    public QuitCommand(IList<string> args, IManager manager) : base(args, manager)
    {
    }
    
    public override string Execute()
    {
       return this.Manager.Quit(this.Args);
    }
}