using MediaPager.App.PluginContracts;

namespace MediaPager.Plugins.Interface.Download;

/// <summary>Installed marker plugin that makes this contract visible/manageable in the host.</summary>
public sealed class DownloadInterfacePlugin : IPluginInterface
{
    public PluginDescriptor Descriptor { get; } = new(
        "mediapager.interface.download",
        "Download Interface",
        "0.1.0",
        "HappyGoLucky Dev",
        "Community contract for plugins that delegate media transfers.");
}

/// <summary>Community inter-plugin capability for delegating a media transfer. It is
/// intentionally outside the host SDK: hosts do not implement or depend on downloads.</summary>
public interface IDownloadProviderPlugin : IMediaPagerPlugin
{
    Task<bool> IsAvailableAsync(MediaKind kind, CancellationToken cancellationToken = default) =>
        Task.FromResult(true);

    Task QueueDownloadAsync(PluginActionContext context, CancellationToken cancellationToken = default);
}
