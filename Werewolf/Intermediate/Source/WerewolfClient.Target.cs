using UnrealBuildTool;

public class WerewolfClientTarget : TargetRules
{
	public WerewolfClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Werewolf");
	}
}
