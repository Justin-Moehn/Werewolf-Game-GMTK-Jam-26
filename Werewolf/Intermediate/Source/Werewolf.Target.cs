using UnrealBuildTool;

public class WerewolfTarget : TargetRules
{
	public WerewolfTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Werewolf");
	}
}
