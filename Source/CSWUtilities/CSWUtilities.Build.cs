// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CSWUtilities : ModuleRules
{
	public CSWUtilities(ReadOnlyTargetRules Target) : base(Target)
	{
		
		//Override UnrealEngineBuildTool to speedup compilation times.
		MinFilesUsingPrecompiledHeaderOverride = 1;
		bFasterWithoutUnity = true;

		//Include what you need convention activation
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		bEnforceIWYU = true;

		//Engine dependencies  -->   add the parts you need.
		PublicDependencyModuleNames.AddRange(new string[] {"Core", "CoreUObject", "Engine"});

		//The path for the header file
		PublicIncludePaths.AddRange(new string[] {"CSWUtilities/Public"});

		//The path for the source file
		PrivateIncludePaths.AddRange(new string[] {"CSWUtilities/Private"});


		/* The Default contents.
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);*/

	}
}
