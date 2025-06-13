// Copyright Epic Games, Inc. All Rights Reserved.

using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnrealBuildTool;

public class Cfitsio : ModuleRules
{
	public Cfitsio(ReadOnlyTargetRules Target) : base(Target)
	{
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        // These are required for non-UE code
        bUseRTTI = true;
        bEnableExceptions = true;
        bUseUnity = false;

        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "include"));
        PrivateIncludePaths.Add(Path.Combine(ModuleDirectory, "src"));

        // Add every .cpp in src
        foreach (string File in Directory.GetFiles(Path.Combine(ModuleDirectory, "src"), "*.c", SearchOption.AllDirectories))
        {
            PrivateDefinitions.Add("INCLUDE_" + Path.GetFileNameWithoutExtension(File).ToUpper()); // Optional tagging
        }

        PublicDependencyModuleNames.AddRange(new string[] {
            "Core"
        });

        PrivateDependencyModuleNames.AddRange(new string[] {
            "CoreUObject",
            "Engine"
        });
    }
}
