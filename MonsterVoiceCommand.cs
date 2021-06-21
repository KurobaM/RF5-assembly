using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020000A1 RID: 161
[Token(Token = "0x200007B")]
public class MonsterVoiceCommand : MonsterActionCommandBase
{
	// Token: 0x17000085 RID: 133
	// (get) Token: 0x0600031F RID: 799 RVA: 0x00002F88 File Offset: 0x00001188
	[Token(Token = "0x17000082")]
	public VoiceGroup VoiceGroup
	{
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1E0F0A0", Offset = "0x1E0F1A1", VA = "0x1E0F0A0")]
		get
		{
			return VoiceGroup.Attack;
		}
	}

	// Token: 0x06000320 RID: 800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000268")]
	[Address(RVA = "0x1E0F190", Offset = "0x1E0F291", VA = "0x1E0F190")]
	public MonsterVoiceCommand(ActionCommandDataTable actionCommandData, MonsterActionScriptsController controller)
	{
	}

	// Token: 0x06000321 RID: 801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000269")]
	[Address(RVA = "0x1E0F1F0", Offset = "0x1E0F2F1", VA = "0x1E0F1F0", Slot = "8")]
	public override void DoAction()
	{
	}
}
