using UnrealBuildTool;

public class WerewolfEditorTarget : TargetRules
{
	public WerewolfEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Werewolf");
	}
}
