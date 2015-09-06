﻿using LiveSplit.Model;
using System;

namespace LiveSplit.UI.Components
{
    public class TextComponentFactory : IComponentFactory
    {
        public string ComponentName => "Text";

        public string Description => "Displays any text that you want it to show.";

        public ComponentCategory Category => ComponentCategory.Information;

        public IComponent Create(LiveSplitState state) => new TextComponent(state);

        public string UpdateName => ComponentName;

        public string XMLURL => "http://livesplit.org/update/Components/update.LiveSplit.Text.xml";

        public string UpdateURL => "http://livesplit.org/update/";

        public Version Version => Version.Parse("1.6");
    }
}
