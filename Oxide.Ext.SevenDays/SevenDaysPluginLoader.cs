﻿using System;

using Oxide.Core.Plugins;

namespace Oxide.SevenDays.Plugins
{
    /// <summary>
    /// Responsible for loading 7 Days to Die core plugins
    /// </summary>
    public class SevenDaysPluginLoader : PluginLoader
    {
        public override Type[] CorePlugins => new[] { typeof(SevenDaysCore) };
    }
}
