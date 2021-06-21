using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200037A RID: 890
[Token(Token = "0x20002A4")]
[Attribute(Name = "DefaultMemberAttribute", RVA = "0x145B10", Offset = "0x145C11")]
[Serializable]
public class HitSoundData
{
	// Token: 0x17000412 RID: 1042
	// (get) Token: 0x060016D0 RID: 5840 RVA: 0x0000A128 File Offset: 0x00008328
	[Token(Token = "0x170003A8")]
	public SoundID Item
	{
		[Token(Token = "0x6001440")]
		[Address(RVA = "0x24F6E70", Offset = "0x24F6F71", VA = "0x24F6E70")]
		get
		{
			return SoundID.Sound_EMPTY;
		}
	}

	// Token: 0x060016D1 RID: 5841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001441")]
	[Address(RVA = "0x24F6EC0", Offset = "0x24F6FC1", VA = "0x24F6EC0")]
	public HitSoundData()
	{
	}

	// Token: 0x04000F4A RID: 3914
	[Token(Token = "0x4000C02")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public SoundID[] SoundIDList;
}
