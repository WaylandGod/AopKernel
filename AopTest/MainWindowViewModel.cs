﻿using Kernel.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Kernel.Aop;

namespace AopTest
{
    [MethodInterceptor]
    public class MainWindowViewModel : NotifyPropertyChangedObject
    {
        public virtual string Name { get; set; }

        public virtual async Task changName(string name)
        {
            //await Task.Delay(3000); //延时3s
            Name = name;
            //throw new TaskCanceledException();
        }

        [OhterAsepct]
        [TimeDifference]
        [Log]
        public virtual async Task change(string name)
        {
             await changName(name);
        }
    }
}
