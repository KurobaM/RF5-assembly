using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000A76 RID: 2678
[Token(Token = "0x2000707")]
public class UINamingWindow : CursorLinkConnector
{
	// Token: 0x060045E2 RID: 17890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A82")]
	[Address(RVA = "0x1EA6C10", Offset = "0x1EA6D11", VA = "0x1EA6C10")]
	private void Start()
	{
	}

	// Token: 0x060045E3 RID: 17891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A83")]
	[Address(RVA = "0x1EA7280", Offset = "0x1EA7381", VA = "0x1EA7280")]
	public void OpenInputText()
	{
	}

	// Token: 0x060045E4 RID: 17892 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003A84")]
	[Address(RVA = "0x1EA7380", Offset = "0x1EA7481", VA = "0x1EA7380")]
	public static string GetNameStr(UINamingWindow.NamingId id)
	{
		return null;
	}

	// Token: 0x060045E5 RID: 17893 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003A85")]
	[Address(RVA = "0x1EA7510", Offset = "0x1EA7611", VA = "0x1EA7510")]
	public static string GetSceneNameStr(string SceneName)
	{
		return null;
	}

	// Token: 0x060045E6 RID: 17894 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003A86")]
	[Address(RVA = "0x1EA7A70", Offset = "0x1EA7B71", VA = "0x1EA7A70")]
	public static string GetDefaultNameStr(UINamingWindow.NamingId id)
	{
		return null;
	}

	// Token: 0x060045E7 RID: 17895 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003A87")]
	[Address(RVA = "0x1EA6F80", Offset = "0x1EA7081", VA = "0x1EA6F80")]
	public static string GetNowNameStr(UINamingWindow.NamingId id)
	{
		return null;
	}

	// Token: 0x060045E8 RID: 17896 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A88")]
	[Address(RVA = "0x1EA8290", Offset = "0x1EA8391", VA = "0x1EA8290")]
	public static void OpenNamingWindow(UINamingWindow.NamingId _namingId, UnityAction<string> _callback, string _defaultNameStr = "")
	{
	}

	// Token: 0x060045E9 RID: 17897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A89")]
	[Address(RVA = "0x1EA8370", Offset = "0x1EA8471", VA = "0x1EA8370")]
	public void Close()
	{
	}

	// Token: 0x060045EA RID: 17898 RVA: 0x000171C0 File Offset: 0x000153C0
	[Token(Token = "0x6003A8A")]
	[Address(RVA = "0x1EA8940", Offset = "0x1EA8A41", VA = "0x1EA8940")]
	private bool CheckNGWord(string word)
	{
		return default(bool);
	}

	// Token: 0x060045EB RID: 17899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A8B")]
	[Address(RVA = "0x1EA89B0", Offset = "0x1EA8AB1", VA = "0x1EA89B0")]
	private void SetClose()
	{
	}

	// Token: 0x060045EC RID: 17900 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A8C")]
	[Address(RVA = "0x1EA8A50", Offset = "0x1EA8B51", VA = "0x1EA8A50")]
	private void OnDestroy()
	{
	}

	// Token: 0x060045ED RID: 17901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A8D")]
	[Address(RVA = "0x1EA8B10", Offset = "0x1EA8C11", VA = "0x1EA8B10")]
	public UINamingWindow()
	{
	}

	// Token: 0x060045EF RID: 17903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A8F")]
	[Address(RVA = "0x1EA8C10", Offset = "0x1EA8D11", VA = "0x1EA8C10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7C80", Offset = "0x1A7D81")]
	private void <Close>b__15_0(bool a)
	{
	}

	// Token: 0x060045F0 RID: 17904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A90")]
	[Address(RVA = "0x1EA8CC0", Offset = "0x1EA8DC1", VA = "0x1EA8CC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7C90", Offset = "0x1A7D91")]
	private void <Close>b__15_2(bool a)
	{
	}

	// Token: 0x0400A4CE RID: 42190
	[Token(Token = "0x4007C92")]
	[FieldOffset(Offset = "0x58")]
	private readonly int[] NameLength;

	// Token: 0x0400A4CF RID: 42191
	[Token(Token = "0x4007C93")]
	[FieldOffset(Offset = "0x0")]
	private static string NamingStr;

	// Token: 0x0400A4D0 RID: 42192
	[Token(Token = "0x4007C94")]
	[FieldOffset(Offset = "0x8")]
	private static UnityAction<string> callback;

	// Token: 0x0400A4D1 RID: 42193
	[Token(Token = "0x4007C95")]
	[FieldOffset(Offset = "0x10")]
	private static UINamingWindow.NamingId namingId;

	// Token: 0x0400A4D2 RID: 42194
	[Token(Token = "0x4007C96")]
	[FieldOffset(Offset = "0x18")]
	private static string defaultNameStr;

	// Token: 0x0400A4D3 RID: 42195
	[Token(Token = "0x4007C97")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Text HeadText;

	// Token: 0x0400A4D4 RID: 42196
	[Token(Token = "0x4007C98")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Text NameText;

	// Token: 0x02000A77 RID: 2679
	[Token(Token = "0x20012F1")]
	public enum NamingId
	{
		// Token: 0x0400A4D6 RID: 42198
		[Token(Token = "0x401B4A0")]
		PlayerMan,
		// Token: 0x0400A4D7 RID: 42199
		[Token(Token = "0x401B4A1")]
		PlayerWoman,
		// Token: 0x0400A4D8 RID: 42200
		[Token(Token = "0x401B4A2")]
		ChildA,
		// Token: 0x0400A4D9 RID: 42201
		[Token(Token = "0x401B4A3")]
		ChildB,
		// Token: 0x0400A4DA RID: 42202
		[Token(Token = "0x401B4A4")]
		ChildC,
		// Token: 0x0400A4DB RID: 42203
		[Token(Token = "0x401B4A5")]
		Farm_Soil,
		// Token: 0x0400A4DC RID: 42204
		[Token(Token = "0x401B4A6")]
		Farm_Fire,
		// Token: 0x0400A4DD RID: 42205
		[Token(Token = "0x401B4A7")]
		Farm_Ice,
		// Token: 0x0400A4DE RID: 42206
		[Token(Token = "0x401B4A8")]
		Farm_Wind,
		// Token: 0x0400A4DF RID: 42207
		[Token(Token = "0x401B4A9")]
		Farm_Ground,
		// Token: 0x0400A4E0 RID: 42208
		[Token(Token = "0x401B4AA")]
		FarmPet_Soil_A,
		// Token: 0x0400A4E1 RID: 42209
		[Token(Token = "0x401B4AB")]
		FarmPet_Soil_B,
		// Token: 0x0400A4E2 RID: 42210
		[Token(Token = "0x401B4AC")]
		FarmPet_Fire_A,
		// Token: 0x0400A4E3 RID: 42211
		[Token(Token = "0x401B4AD")]
		FarmPet_Fire_B,
		// Token: 0x0400A4E4 RID: 42212
		[Token(Token = "0x401B4AE")]
		FarmPet_Ice_A,
		// Token: 0x0400A4E5 RID: 42213
		[Token(Token = "0x401B4AF")]
		FarmPet_Ice_B,
		// Token: 0x0400A4E6 RID: 42214
		[Token(Token = "0x401B4B0")]
		FarmPet_Wind_A,
		// Token: 0x0400A4E7 RID: 42215
		[Token(Token = "0x401B4B1")]
		FarmPet_Wind_B,
		// Token: 0x0400A4E8 RID: 42216
		[Token(Token = "0x401B4B2")]
		FarmPet_Ground_A,
		// Token: 0x0400A4E9 RID: 42217
		[Token(Token = "0x401B4B3")]
		FarmPet_Ground_B,
		// Token: 0x0400A4EA RID: 42218
		[Token(Token = "0x401B4B4")]
		Max
	}

	// Token: 0x02000A78 RID: 2680
	[Token(Token = "0x20012F2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159150", Offset = "0x159251")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060045F2 RID: 17906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007645")]
		[Address(RVA = "0x1EA8DB0", Offset = "0x1EA8EB1", VA = "0x1EA8DB0")]
		public <>c()
		{
		}

		// Token: 0x060045F3 RID: 17907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007646")]
		[Address(RVA = "0x1EA8DC0", Offset = "0x1EA8EC1", VA = "0x1EA8DC0")]
		internal void <Close>b__15_1(bool a)
		{
		}

		// Token: 0x0400A4EB RID: 42219
		[Token(Token = "0x401B4B5")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UINamingWindow.<>c <>9;

		// Token: 0x0400A4EC RID: 42220
		[Token(Token = "0x401B4B6")]
		[FieldOffset(Offset = "0x8")]
		public static UnityAction<bool> <>9__15_1;
	}
}
