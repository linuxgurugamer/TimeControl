using KSP.UI.Screens;
using System.Collections;
using ToolbarControl_NS;
using UnityEngine;

namespace TimeControl
{
    [KSPAddon(KSPAddon.Startup.MainMenu, true)]
    internal sealed class Toolbars : MonoBehaviour
    {
        #region Singleton

        static ToolbarControl toolbarControl;

        internal const string MODID = "TimeControl";
        internal const string MODNAME = "Time Control";

        #endregion

        private readonly ApplicationLauncher.AppScenes AppScenes = ApplicationLauncher.AppScenes.FLIGHT | ApplicationLauncher.AppScenes.MAPVIEW | ApplicationLauncher.AppScenes.SPACECENTER | ApplicationLauncher.AppScenes.TRACKSTATION;


        private void Awake()
        {
            DontDestroyOnLoad(this);
        }

        private void Start()
        {
            toolbarControl = gameObject.AddComponent<ToolbarControl>();
            toolbarControl.AddToAllToolbars(OnClick, OnClick,
                AppScenes,
                MODID,
                "TimeCtlBtn",
                PluginAssemblyUtilities.GameDatabasePathStockToolbarIcons + "/enabled",
                PluginAssemblyUtilities.GameDatabasePathStockToolbarIcons + "/disabled",
                PluginAssemblyUtilities.GameDatabasePathBlizzyToolbarIcons + "/enabled",
                PluginAssemblyUtilities.GameDatabasePathBlizzyToolbarIcons + "/disabled",
                MODNAME
            );
        }

        private void OnClick()
        {
            TimeControlIMGUI.Instance.ToggleGUIVisibility();
        }

    }
}


/*
All code in this file Copyright(c) 2016 Nate West

The MIT License (MIT)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

*/
