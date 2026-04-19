// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Myeongjo : ModuleRules
{
	public Myeongjo(ReadOnlyTargetRules Target) : base(Target)
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
			"Myeongjo",
			"Myeongjo/Variant_Platforming",
			"Myeongjo/Variant_Platforming/Animation",
			"Myeongjo/Variant_Combat",
			"Myeongjo/Variant_Combat/AI",
			"Myeongjo/Variant_Combat/Animation",
			"Myeongjo/Variant_Combat/Gameplay",
			"Myeongjo/Variant_Combat/Interfaces",
			"Myeongjo/Variant_Combat/UI",
			"Myeongjo/Variant_SideScrolling",
			"Myeongjo/Variant_SideScrolling/AI",
			"Myeongjo/Variant_SideScrolling/Gameplay",
			"Myeongjo/Variant_SideScrolling/Interfaces",
			"Myeongjo/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
