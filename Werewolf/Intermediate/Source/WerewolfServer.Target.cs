using UnrealBuildTool;

public class WerewolfServerTarget : TargetRules
{
	public WerewolfServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Werewolf");
	}
}
