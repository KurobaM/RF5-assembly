using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003C9 RID: 969
[Token(Token = "0x20002EB")]
public class TimeConst : ScriptableObject
{
	// Token: 0x1700041C RID: 1052
	// (get) Token: 0x06001780 RID: 6016 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003B2")]
	public static TimeConst Instance
	{
		[Token(Token = "0x60014E4")]
		[Address(RVA = "0x2060480", Offset = "0x2060581", VA = "0x2060480")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001781 RID: 6017 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014E5")]
	[Address(RVA = "0x2060590", Offset = "0x2060691", VA = "0x2060590")]
	public TimeConst()
	{
	}

	// Token: 0x040010D9 RID: 4313
	[Token(Token = "0x4000D75")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float MultiplicationTimeSpeed;

	// Token: 0x040010DA RID: 4314
	[Token(Token = "0x4000D76")]
	[FieldOffset(Offset = "0x0")]
	private static TimeConst _Instance;
}
