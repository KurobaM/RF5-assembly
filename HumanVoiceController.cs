using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000255 RID: 597
[Token(Token = "0x20001E0")]
public class HumanVoiceController : CharaVoiceController<HumanController>
{
	// Token: 0x170002B3 RID: 691
	// (get) Token: 0x06000E72 RID: 3698 RVA: 0x000068B8 File Offset: 0x00004AB8
	[Token(Token = "0x17000292")]
	protected override CharID CharID
	{
		[Token(Token = "0x6000D09")]
		[Address(RVA = "0x222B9F0", Offset = "0x222BAF1", VA = "0x222B9F0", Slot = "22")]
		get
		{
			return CharID.ch000;
		}
	}

	// Token: 0x170002B4 RID: 692
	// (get) Token: 0x06000E73 RID: 3699 RVA: 0x000068D0 File Offset: 0x00004AD0
	[Token(Token = "0x17000293")]
	protected override int Variation
	{
		[Token(Token = "0x6000D0A")]
		[Address(RVA = "0x222BA30", Offset = "0x222BB31", VA = "0x222BA30", Slot = "23")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000E74 RID: 3700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D0B")]
	[Address(RVA = "0x222BAC0", Offset = "0x222BBC1", VA = "0x222BAC0")]
	public HumanVoiceController()
	{
	}
}
