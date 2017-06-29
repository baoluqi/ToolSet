﻿using System;
using Prism.Events;

namespace ToolSetsCore
{
    public class OpenFileEvent : PubSubEvent
    {
    }

    public class OpenFolderEvent : PubSubEvent
    {
    }

    public class SaveEvent : PubSubEvent
    {

    }

    public class LogEvent : PubSubEvent<string>
    {
    }

    public class ProgeessEvent : PubSubEvent<double>
    {

    }
}