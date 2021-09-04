using Sandbox;
using System;

public static class SboxUtils 
{
    public static void UtilLog(object inMessage)
    {
        var prefix = Host.IsServer ? "[SERVER]" : "[CLIENT]";
        Log.Info($"{prefix}: {inMessage.ToString()}");

        if(Host.IsClient)
        {
            Sandbox.UI.ChatBox.AddChatEntry(prefix, inMessage.ToString());

        }
    }
}
