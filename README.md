# MediaPager.Plugins.Interface.Download

Community-owned, installable interface plugin for inter-plugin media transfer delegation. Its
manifest and `DownloadInterfacePlugin` descriptor let users install, inspect, disable, and
uninstall the interface like any other community plugin. The host SDK does not reference this
assembly or define transfer-specific behavior. A provider implements
`IDownloadProviderPlugin`; other plugins discover it through `IPluginHost` and delegate a
`PluginActionContext`.

The shared contract repository is referenced by community plugins through the optional
manifest `references` list so the deployer stages it beside the plugin before publishing.
