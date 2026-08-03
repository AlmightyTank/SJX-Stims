using System.Reflection;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Models.Enums;

namespace SJXStims;

/// <summary>
/// SJX-Stims, an addon for Consumables Galore. Contains only data (items/*.json) —
/// on load it hands its items/ folder to Consumables Galore's LoadAdditionalItems
/// pipeline (clone, buffs, trader, quest hookups, spawns) instead of duplicating that
/// logic here.
/// </summary>
[Injectable(TypePriority = OnLoadOrder.Preload + 2)]
public class SJXStims(ConsumablesGalore.ConsumablesGalore consumablesGalore) : IOnLoad
{
    public async Task OnLoadAsync(CancellationToken cancellationToken)
    {
        await consumablesGalore.LoadAdditionalItems(Assembly.GetExecutingAssembly(), cancellationToken: cancellationToken);
    }
}
