using HarmonyLib;
using Verse;

namespace Dryad_Caravan;

public class Mod : Verse.Mod
{
    public Mod(ModContentPack content) : base(content)
    {
        new Harmony("Garethp.rimworld.Dryad_Caravan.main").PatchAll();
    }
}