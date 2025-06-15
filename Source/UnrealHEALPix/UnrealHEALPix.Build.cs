// Copyright Epic Games, Inc. All Rights Reserved.

using System.IO;
using UnrealBuildTool;

public class UnrealHEALPix : ModuleRules
{
	public UnrealHEALPix(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        // CppStandard = CppStandardVersion.Cpp17;

        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
                "HEALPix"
            }
        );

        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "CoreUObject",
                "Engine"
            }
        );
    }
}
