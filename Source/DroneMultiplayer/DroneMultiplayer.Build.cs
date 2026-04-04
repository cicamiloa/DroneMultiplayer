// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class DroneMultiplayer : ModuleRules
{
	public DroneMultiplayer(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"DroneMultiplayer",
			"DroneMultiplayer/Variant_Horror",
			"DroneMultiplayer/Variant_Horror/UI",
			"DroneMultiplayer/Variant_Shooter",
			"DroneMultiplayer/Variant_Shooter/AI",
			"DroneMultiplayer/Variant_Shooter/UI",
			"DroneMultiplayer/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
