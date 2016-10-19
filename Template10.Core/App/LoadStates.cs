using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;

namespace Template10.App
{

    public enum LoadStates
    {
        None,
        Running,

        BeforeInitializeAsync,
        AfterInitializeAsync,

        BeforeInternalPrelaunch,
        AfterInternalPrelaunch,

        BeforeStartAsync,
        AfterStartAsync,

        BeforeInternalLaunch,
        AfterInternalLaunch,

        BeforeInternalActivate,
        AfterInternalActivate,
    }

}