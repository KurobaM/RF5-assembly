using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000A74 RID: 2676
[Token(Token = "0x2000706")]
public class UIMonsterNaming : CursorLinkConnector
{
	// Token: 0x060045D5 RID: 17877 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A78")]
	[Address(RVA = "0x1EA5CA0", Offset = "0x1EA5DA1", VA = "0x1EA5CA0")]
	private void Start()
	{
	}

	// Token: 0x060045D6 RID: 17878 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A79")]
	[Address(RVA = "0x1EA5E80", Offset = "0x1EA5F81", VA = "0x1EA5E80")]
	public void OpenInputText()
	{
	}

	// Token: 0x060045D7 RID: 17879 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A7A")]
	[Address(RVA = "0x1EA5F20", Offset = "0x1EA6021", VA = "0x1EA5F20")]
	public static void OpenMonsterNamingWindow(MonsterDataID monsterDataID, UnityAction<string> _callback, string defaultNameStr = "")
	{
	}

	// Token: 0x060045D8 RID: 17880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A7B")]
	[Address(RVA = "0x1EA6000", Offset = "0x1EA6101", VA = "0x1EA6000")]
	public void Close()
	{
	}

	// Token: 0x060045D9 RID: 17881 RVA: 0x000171A8 File Offset: 0x000153A8
	[Token(Token = "0x6003A7C")]
	[Address(RVA = "0x1EA64F0", Offset = "0x1EA65F1", VA = "0x1EA64F0")]
	private bool CheckNGWord(string word)
	{
		return default(bool);
	}

	// Token: 0x060045DA RID: 17882 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A7D")]
	[Address(RVA = "0x1EA6560", Offset = "0x1EA6661", VA = "0x1EA6560")]
	private void SetClose()
	{
	}

	// Token: 0x060045DB RID: 17883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A7E")]
	[Address(RVA = "0x1EA6640", Offset = "0x1EA6741", VA = "0x1EA6640")]
	private void OnDestroy()
	{
	}

	// Token: 0x060045DC RID: 17884 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A7F")]
	[Address(RVA = "0x1EA66B0", Offset = "0x1EA67B1", VA = "0x1EA66B0")]
	public UIMonsterNaming()
	{
	}

	// Token: 0x060045DD RID: 17885 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A80")]
	[Address(RVA = "0x1EA66C0", Offset = "0x1EA67C1", VA = "0x1EA66C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7C60", Offset = "0x1A7D61")]
	private void <Close>b__8_0(bool a)
	{
	}

	// Token: 0x060045DE RID: 17886 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A81")]
	[Address(RVA = "0x1EA6740", Offset = "0x1EA6841", VA = "0x1EA6740")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7C70", Offset = "0x1A7D71")]
	private void <Close>b__8_2(bool a)
	{
	}

	// Token: 0x0400A4C7 RID: 42183
	[Token(Token = "0x4007C8D")]
	[FieldOffset(Offset = "0x0")]
	public static string NamingStr;

	// Token: 0x0400A4C8 RID: 42184
	[Token(Token = "0x4007C8E")]
	[FieldOffset(Offset = "0x8")]
	private static UnityAction<string> callback;

	// Token: 0x0400A4C9 RID: 42185
	[Token(Token = "0x4007C8F")]
	[FieldOffset(Offset = "0x10")]
	private static MonsterDataID MonsterDataID;

	// Token: 0x0400A4CA RID: 42186
	[Token(Token = "0x4007C90")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Text HeadText;

	// Token: 0x0400A4CB RID: 42187
	[Token(Token = "0x4007C91")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Text NameText;

	// Token: 0x02000A75 RID: 2677
	[Token(Token = "0x20012F0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159140", Offset = "0x159241")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060045E0 RID: 17888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007642")]
		[Address(RVA = "0x1EA6830", Offset = "0x1EA6931", VA = "0x1EA6830")]
		public <>c()
		{
		}

		// Token: 0x060045E1 RID: 17889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007643")]
		[Address(RVA = "0x1EA6840", Offset = "0x1EA6941", VA = "0x1EA6840")]
		internal void <Close>b__8_1(bool a)
		{
		}

		// Token: 0x0400A4CC RID: 42188
		[Token(Token = "0x401B49D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIMonsterNaming.<>c <>9;

		// Token: 0x0400A4CD RID: 42189
		[Token(Token = "0x401B49E")]
		[FieldOffset(Offset = "0x8")]
		public static UnityAction<bool> <>9__8_1;
	}
}
