// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class plugin_makrEditorTarget : TargetRules
{
	public plugin_makrEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "plugin_makr","CSWUtilities" } );
	}
}
