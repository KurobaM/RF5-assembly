using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000959 RID: 2393
[Token(Token = "0x2000647")]
[Serializable]
public struct AdvScriptDefCountParam
{
	// Token: 0x06003F77 RID: 16247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034CE")]
	[Address(RVA = "0x2F2740", Offset = "0x2F2841", VA = "0x2F2740")]
	public void Init()
	{
	}

	// Token: 0x06003F78 RID: 16248 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60034CF")]
	[Address(RVA = "0x2432700", Offset = "0x2432801", VA = "0x2432700")]
	private static AdvScriptDefCountData GetDataTable()
	{
		return null;
	}

	// Token: 0x06003F79 RID: 16249 RVA: 0x00015888 File Offset: 0x00013A88
	[Token(Token = "0x60034D0")]
	[Address(RVA = "0x2432820", Offset = "0x2432921", VA = "0x2432820")]
	private static AdvScriptDefCountParam GetDataParam(int npcid)
	{
		return default(AdvScriptDefCountParam);
	}

	// Token: 0x06003F7A RID: 16250 RVA: 0x000158A0 File Offset: 0x00013AA0
	[Token(Token = "0x60034D1")]
	[Address(RVA = "0x2432880", Offset = "0x2432981", VA = "0x2432880")]
	public static int GetRandNum(int npcid, int lv)
	{
		return 0;
	}

	// Token: 0x06003F7B RID: 16251 RVA: 0x000158B8 File Offset: 0x00013AB8
	[Token(Token = "0x60034D2")]
	[Address(RVA = "0x2432A10", Offset = "0x2432B11", VA = "0x2432A10")]
	public static ValueTuple<int, int> GetDailyTalk_TypeAndID(int npcid, int lv, int rand)
	{
		return default(ValueTuple<int, int>);
	}

	// Token: 0x06003F7C RID: 16252 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60034D3")]
	[Address(RVA = "0x2432990", Offset = "0x2432A91", VA = "0x2432990")]
	public static AdvScriptDefCountData.AdvScriptDefScriptType GetUseScriptTypes(int lv)
	{
		return null;
	}

	// Token: 0x06003F7D RID: 16253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034D4")]
	[Address(RVA = "0x2432B80", Offset = "0x2432C81", VA = "0x2432B80")]
	public static void LoadData()
	{
	}

	// Token: 0x170008F0 RID: 2288
	// (get) Token: 0x06003F7E RID: 16254 RVA: 0x000158D0 File Offset: 0x00013AD0
	[Token(Token = "0x17000726")]
	public static bool IsLoaded
	{
		[Token(Token = "0x60034D5")]
		[Address(RVA = "0x2432CB0", Offset = "0x2432DB1", VA = "0x2432CB0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x040080F0 RID: 33008
	[Token(Token = "0x4007421")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public int NpcId;

	// Token: 0x040080F1 RID: 33009
	[Token(Token = "0x4007422")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	public int[] RAND_NUM;

	// Token: 0x040080F2 RID: 33010
	[Token(Token = "0x4007423")]
	[FieldOffset(Offset = "0x0")]
	private static AdvScriptDefCountData _AdvScriptDefCountDataTable;

	// Token: 0x0200095A RID: 2394
	[Token(Token = "0x2001294")]
	public enum DefTalkType
	{
		// Token: 0x040080F4 RID: 33012
		[Token(Token = "0x4019933")]
		Def_Lv1 = 1,
		// Token: 0x040080F5 RID: 33013
		[Token(Token = "0x4019934")]
		Def_Lv2,
		// Token: 0x040080F6 RID: 33014
		[Token(Token = "0x4019935")]
		Def_Max,
		// Token: 0x040080F7 RID: 33015
		[Token(Token = "0x4019936")]
		Lover = 3,
		// Token: 0x040080F8 RID: 33016
		[Token(Token = "0x4019937")]
		Spouse,
		// Token: 0x040080F9 RID: 33017
		[Token(Token = "0x4019938")]
		Num,
		// Token: 0x040080FA RID: 33018
		[Token(Token = "0x4019939")]
		AboutChild_Spouse = 5,
		// Token: 0x040080FB RID: 33019
		[Token(Token = "0x401993A")]
		AboutChild_Other,
		// Token: 0x040080FC RID: 33020
		[Token(Token = "0x401993B")]
		AboutEntry,
		// Token: 0x040080FD RID: 33021
		[Token(Token = "0x401993C")]
		AboutBirthDay,
		// Token: 0x040080FE RID: 33022
		[Token(Token = "0x401993D")]
		AboutFavorite,
		// Token: 0x040080FF RID: 33023
		[Token(Token = "0x401993E")]
		AboutNotFavorite,
		// Token: 0x04008100 RID: 33024
		[Token(Token = "0x401993F")]
		AboutNPC,
		// Token: 0x04008101 RID: 33025
		[Token(Token = "0x4019940")]
		TypeMax
	}
}
