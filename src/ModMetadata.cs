using SPTarkov.Server.Core.Models.Spt.Mod;

namespace SJXStims;

/// <summary>
/// Metadata the SPT mod loader reads when loading this mod. Every property must be
/// implemented; unused ones may be null.
/// </summary>
public record ModMetadata : IModMetadata
{
    public string ModGuid { get; init; } = "com.almightytank.sjxstims";
    public string Name { get; init; } = "AlmightyTank-SJX-Stims";
    public string Author { get; init; } = "AlmightyTank";
    public List<string>? Contributors { get; init; }
    public SemanticVersioning.Version Version { get; init; } = new("1.0.0");
    public SemanticVersioning.Range SptVersion { get; init; } = new("~4.1.1");
    public bool HasPrepatcher { get; init; } = false;
    public List<string>? Incompatibilities { get; init; }

    // Requires Consumables Galore to already be loaded so its LoadAdditionalItems
    // extension point is registered in the DI container.
    public Dictionary<string, SemanticVersioning.Range>? ModDependencies { get; init; } = new()
    {
        { "com.musicmaniac.consumablesgalore", new SemanticVersioning.Range(">=3.0.0") },
    };

    public string? Url { get; init; }
    public string License { get; init; } = "MIT";
}
