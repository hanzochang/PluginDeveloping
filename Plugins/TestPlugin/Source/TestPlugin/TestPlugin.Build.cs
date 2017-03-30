// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

namespace UnrealBuildTool.Rules
{
	public class TestPlugin : ModuleRules
	{
		public TestPlugin(TargetInfo Target)
		{
			PublicIncludePaths.AddRange(new string[]{ "TestPlugin/Public" });
			PrivateIncludePaths.AddRange(new string[]{ "TestPlugin/Private" });
			PrivateDependencyModuleNames.AddRange(new string[]{ "Engine", "Core" });
			DynamicallyLoadedModuleNames.AddRange(new string[]{});
		}
	}
}