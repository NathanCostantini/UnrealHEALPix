// Copyright Epic Games, Inc. All Rights Reserved.

using System.IO;
using UnrealBuildTool;

public class HEALPix : ModuleRules
{
    public HEALPix(ReadOnlyTargetRules Target) : base(Target)
    {
        // For the static library, disable RTTI and exceptions if not needed
        bUseRTTI = true;
        bEnableExceptions = true;

        Type = ModuleType.CPlusPlus;
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        CppStandard = CppStandardVersion.Cpp17;

        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "include", "healpix", "Healpix_cxx"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "include", "healpix", "cxxsupport"));

        PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "lib", "healpix.lib"));

        PublicDefinitions.Add("USE_HEALPIX=1");
    }
}
