using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000845 RID: 2117
[Token(Token = "0x200056E")]
public class MagicTestChara : Character
{
	// Token: 0x170007C8 RID: 1992
	// (get) Token: 0x06003836 RID: 14390 RVA: 0x00013500 File Offset: 0x00011700
	[Token(Token = "0x1700060D")]
	public override Alliance Alliance
	{
		[Token(Token = "0x6002EC0")]
		[Address(RVA = "0x1F157F0", Offset = "0x1F158F1", VA = "0x1F157F0", Slot = "8")]
		get
		{
			return Alliance.None;
		}
	}

	// Token: 0x06003837 RID: 14391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EC1")]
	[Address(RVA = "0x1F15800", Offset = "0x1F15901", VA = "0x1F15800")]
	public MagicTestChara()
	{
	}

	// Token: 0x04007B47 RID: 31559
	[Token(Token = "0x4006F73")]
	[FieldOffset(Offset = "0x184")]
	[SerializeField]
	private Alliance m_Alliance;
}
