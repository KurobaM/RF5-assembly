using System;
using Define;
using Il2CppDummyDll;

// Token: 0x0200044E RID: 1102
[Token(Token = "0x200034E")]
public class FlagDataStorage
{
	// Token: 0x06001AA3 RID: 6819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017AD")]
	[Address(RVA = "0x1EC87D0", Offset = "0x1EC88D1", VA = "0x1EC87D0")]
	private static void CheckInitFlagStock()
	{
	}

	// Token: 0x06001AA4 RID: 6820 RVA: 0x0000B910 File Offset: 0x00009B10
	[Token(Token = "0x60017AE")]
	[Address(RVA = "0x1EC4090", Offset = "0x1EC4191", VA = "0x1EC4090")]
	public static bool CheckScriptFlag(int eventScriptFlagID)
	{
		return default(bool);
	}

	// Token: 0x06001AA5 RID: 6821 RVA: 0x0000B928 File Offset: 0x00009B28
	[Token(Token = "0x60017AF")]
	[Address(RVA = "0x1EC87E0", Offset = "0x1EC88E1", VA = "0x1EC87E0")]
	public static bool CheckScriptGameClearFlag()
	{
		return default(bool);
	}

	// Token: 0x06001AA6 RID: 6822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017B0")]
	[Address(RVA = "0x1EC40D0", Offset = "0x1EC41D1", VA = "0x1EC40D0")]
	public static void SetScriptFlag(bool value, params int[] eventScriptFlagID)
	{
	}

	// Token: 0x06001AA7 RID: 6823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017B1")]
	[Address(RVA = "0x1EC8870", Offset = "0x1EC8971", VA = "0x1EC8870")]
	public static void SetScriptFlagDontFlagCheck(bool value, params int[] eventScriptFlagID)
	{
	}

	// Token: 0x06001AA8 RID: 6824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017B2")]
	[Address(RVA = "0x1EC8A50", Offset = "0x1EC8B51", VA = "0x1EC8A50")]
	public static void Init()
	{
	}

	// Token: 0x06001AA9 RID: 6825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017B3")]
	[Address(RVA = "0x1EC8A60", Offset = "0x1EC8B61", VA = "0x1EC8A60")]
	public static void DispDicDebugLog()
	{
	}

	// Token: 0x06001AAA RID: 6826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017B4")]
	[Address(RVA = "0x1EC8A70", Offset = "0x1EC8B71", VA = "0x1EC8A70")]
	public static void BeforeGameDataSave()
	{
	}

	// Token: 0x06001AAB RID: 6827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017B5")]
	[Address(RVA = "0x1EC8A80", Offset = "0x1EC8B81", VA = "0x1EC8A80")]
	public static void AfterGameDataLoad()
	{
	}

	// Token: 0x06001AAC RID: 6828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017B6")]
	[Address(RVA = "0x1EC8A90", Offset = "0x1EC8B91", VA = "0x1EC8A90")]
	public FlagDataStorage()
	{
	}

	// Token: 0x04005D9D RID: 23965
	[Token(Token = "0x40059D7")]
	[FieldOffset(Offset = "0x0")]
	public static readonly GameFlagData GameFlagDataGameClear;
}
