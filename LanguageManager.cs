using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002E9 RID: 745
[Token(Token = "0x2000247")]
public class LanguageManager
{
	// Token: 0x060013B9 RID: 5049 RVA: 0x00008F28 File Offset: 0x00007128
	[Token(Token = "0x60011EB")]
	[Address(RVA = "0x23014F0", Offset = "0x23015F1", VA = "0x23014F0")]
	public static SystemLanguage GetLanguage()
	{
		return SystemLanguage.Afrikaans;
	}

	// Token: 0x060013BA RID: 5050 RVA: 0x00008F40 File Offset: 0x00007140
	[Token(Token = "0x60011EC")]
	[Address(RVA = "0x2301840", Offset = "0x2301941", VA = "0x2301840")]
	public static SystemLanguage GetVoiceLanguage()
	{
		return SystemLanguage.Afrikaans;
	}

	// Token: 0x060013BB RID: 5051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011ED")]
	[Address(RVA = "0x23019C0", Offset = "0x2301AC1", VA = "0x23019C0")]
	public LanguageManager()
	{
	}

	// Token: 0x04000B10 RID: 2832
	[Token(Token = "0x40008A8")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, SystemLanguage> DicSystemLanguage;
}
