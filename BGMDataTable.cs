using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Loader.ID;
using UnityEngine;

// Token: 0x0200033B RID: 827
[Token(Token = "0x200026C")]
[Serializable]
public class BGMDataTable
{
	// Token: 0x06001635 RID: 5685 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013AB")]
	[Address(RVA = "0x229A1C0", Offset = "0x229A2C1", VA = "0x229A1C0")]
	public static BGMDataTable GetDataTable(BGMID bgmID)
	{
		return null;
	}

	// Token: 0x06001636 RID: 5686 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013AC")]
	[Address(RVA = "0x229A310", Offset = "0x229A411", VA = "0x229A310")]
	public static string GetBgmTitleKey(BGMID bgmID)
	{
		return null;
	}

	// Token: 0x06001637 RID: 5687 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013AD")]
	[Address(RVA = "0x229A330", Offset = "0x229A431", VA = "0x229A330")]
	public static List<BgmList> GetBgmList(int recordType)
	{
		return null;
	}

	// Token: 0x06001638 RID: 5688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013AE")]
	[Address(RVA = "0x229A670", Offset = "0x229A771", VA = "0x229A670")]
	public BGMDataTable()
	{
	}

	// Token: 0x04000CCB RID: 3275
	[Token(Token = "0x40009B2")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public Audio AudioID;

	// Token: 0x04000CCC RID: 3276
	[Token(Token = "0x40009B3")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public float LoopStartPoint;

	// Token: 0x04000CCD RID: 3277
	[Token(Token = "0x40009B4")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float LoopEndPoint;

	// Token: 0x04000CCE RID: 3278
	[Token(Token = "0x40009B5")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public bool IsLoop;

	// Token: 0x04000CCF RID: 3279
	[Token(Token = "0x40009B6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public string NameKey;

	// Token: 0x04000CD0 RID: 3280
	[Token(Token = "0x40009B7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public int RecordType;

	// Token: 0x04000CD1 RID: 3281
	[Token(Token = "0x40009B8")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public int SortOrder;

	// Token: 0x04000CD2 RID: 3282
	[Token(Token = "0x40009B9")]
	[FieldOffset(Offset = "0x0")]
	private static BGMDataTableArray _BGMDataTableArray;

	// Token: 0x0200033C RID: 828
	[Token(Token = "0x2001058")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157570", Offset = "0x157671")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600163A RID: 5690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D76")]
		[Address(RVA = "0x229A6F0", Offset = "0x229A7F1", VA = "0x229A6F0")]
		public <>c()
		{
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00009E58 File Offset: 0x00008058
		[Token(Token = "0x6006D77")]
		[Address(RVA = "0x229A700", Offset = "0x229A801", VA = "0x229A700")]
		internal int <GetBgmList>b__10_0(BgmList a, BgmList b)
		{
			return 0;
		}

		// Token: 0x04000CD3 RID: 3283
		[Token(Token = "0x4018F8C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BGMDataTable.<>c <>9;

		// Token: 0x04000CD4 RID: 3284
		[Token(Token = "0x4018F8D")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<BgmList> <>9__10_0;
	}
}
