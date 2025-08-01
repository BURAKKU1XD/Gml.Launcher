﻿namespace Gml.Launcher.Assets;

using System;

public static class ResourceKeysDictionary
{
    public const string MainPageTitle = "DefaultPageTitle";
    public const string DefaultPageTitle = "DefaultPageTitle";
    public const string Error = "Error";
    public const string Information = "Information";
    public const string GameProfileError = "GameProfileError";
    public const string InvalidFolder = "InvalidFolder";
    public const string NotSetting = "NotSetting";
    public const string Updating = "Updating";
    public const string Stay = "Stay";
    public const string Files = "Files";
    public const string DefaultDRpcText = "DefaultDRpcText";
    public const string PlayDRpcText = "PlayDRpcText";
    public const string Launching = "Launching";
    public const string PreparingLaunch = "PreparingLaunch";
    public const string CheckingFileIntegrity = "CheckingFileIntegrity";
    public const string ProfileNotConfigured = "ProfileNotConfigured";
    public const string UpdatingDescription = "UpdatingDescription";
    public const string InvalidAuthData = "InvalidAuthData";
    public const string InvalidSession = "InvalidSession";
    public const string Warning = "Warning";
    public const string VpnUse = "VpnUse";
    public const string Reconnecting = "Reconnecting";
    public const string LostConnection = "LostConnection";
    public const string CheckUpdates = "CheckUpdates";
    public const string InstallingUpdates = "InstallingUpdates";
    public const string FailedOs = "FailedOs";
    public const string JavaNotFound = "JavaNotFound";
    public const string IsDiskFull = "IsDiskFull";
    // public const string Host = "https://gmlb.recloud.tech";
#if DEBUG
    private const string DevelopmentHost = "http://10.0.10.74:5000";
#endif
    public static string Host
    {
        get
        {
            var host = Environment.GetEnvironmentVariable("GML_HOST");
#if DEBUG
            if (string.IsNullOrWhiteSpace(host))
                host = DevelopmentHost;
#endif
            return host ?? string.Empty;
        }
    }
    public const string FolderName = "GamerVIILacunerhV2";
}
