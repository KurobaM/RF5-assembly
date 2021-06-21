using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020000CB RID: 203
[Token(Token = "0x20000A1")]
public class JoroVoiceCommand : ToolActionCommandBase
{
	// Token: 0x170000BD RID: 189
	// (get) Token: 0x060003D5 RID: 981 RVA: 0x00003420 File Offset: 0x00001620
	[Token(Token = "0x170000BA")]
	public VoiceGroup VoiceGroup1
	{
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x2241B30", Offset = "0x2241C31", VA = "0x2241B30")]
		get
		{
			return VoiceGroup.Attack;
		}
	}

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x060003D6 RID: 982 RVA: 0x00003438 File Offset: 0x00001638
	[Token(Token = "0x170000BB")]
	public VoiceGroup VoiceGroup2
	{
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x2241C20", Offset = "0x2241D21", VA = "0x2241C20")]
		get
		{
			return VoiceGroup.Attack;
		}
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x060003D7 RID: 983 RVA: 0x00003450 File Offset: 0x00001650
	[Token(Token = "0x170000BC")]
	public float Probability
	{
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x2241D10", Offset = "0x2241E11", VA = "0x2241D10")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060003D8 RID: 984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600031A")]
	[Address(RVA = "0x2241D30", Offset = "0x2241E31", VA = "0x2241D30")]
	public JoroVoiceCommand(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600031B")]
	[Address(RVA = "0x2241D90", Offset = "0x2241E91", VA = "0x2241D90", Slot = "8")]
	public override void DoAction()
	{
	}
}
