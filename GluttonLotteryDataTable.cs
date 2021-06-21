using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000519 RID: 1305
[Token(Token = "0x20003B8")]
public class GluttonLotteryDataTable : ScriptableObject
{
	// Token: 0x1700051D RID: 1309
	// (get) Token: 0x06001FAC RID: 8108 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001FAD RID: 8109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700042D")]
	public List<GluttonItemTerm> DataTable
	{
		[Token(Token = "0x6001AFE")]
		[Address(RVA = "0x1FEF690", Offset = "0x1FEF791", VA = "0x1FEF690")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FE90", Offset = "0x19FF91")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001AFF")]
		[Address(RVA = "0x1FEF6A0", Offset = "0x1FEF7A1", VA = "0x1FEF6A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FEA0", Offset = "0x19FFA1")]
		private set
		{
		}
	}

	// Token: 0x06001FAE RID: 8110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B00")]
	[Address(RVA = "0x1FEF6B0", Offset = "0x1FEF7B1", VA = "0x1FEF6B0")]
	public void Setup()
	{
	}

	// Token: 0x06001FAF RID: 8111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B01")]
	[Address(RVA = "0x1FEF730", Offset = "0x1FEF831", VA = "0x1FEF730")]
	public void Clear()
	{
	}

	// Token: 0x06001FB0 RID: 8112 RVA: 0x0000D380 File Offset: 0x0000B580
	[Token(Token = "0x6001B02")]
	[Address(RVA = "0x1FEF7A0", Offset = "0x1FEF8A1", VA = "0x1FEF7A0")]
	public FoodID Lottery(int term)
	{
		return FoodID.Apple;
	}

	// Token: 0x06001FB1 RID: 8113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B03")]
	[Address(RVA = "0x1FEFA40", Offset = "0x1FEFB41", VA = "0x1FEFA40")]
	public GluttonLotteryDataTable()
	{
	}

	// Token: 0x0400668E RID: 26254
	[Token(Token = "0x40060D1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<GluttonItemTerm> TermList;

	// Token: 0x0400668F RID: 26255
	[Token(Token = "0x40060D2")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1659F0", Offset = "0x165AF1")]
	private List<GluttonItemTerm> <DataTable>k__BackingField;

	// Token: 0x0200051A RID: 1306
	[Token(Token = "0x20010EA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157CE0", Offset = "0x157DE1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001FB3 RID: 8115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F9A")]
		[Address(RVA = "0x1FEFAC0", Offset = "0x1FEFBC1", VA = "0x1FEFAC0")]
		public <>c()
		{
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x0000D398 File Offset: 0x0000B598
		[Token(Token = "0x6006F9B")]
		[Address(RVA = "0x1FEFAD0", Offset = "0x1FEFBD1", VA = "0x1FEFAD0")]
		internal int <Lottery>b__7_0(GluttonItem x)
		{
			return 0;
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x0000D3B0 File Offset: 0x0000B5B0
		[Token(Token = "0x6006F9C")]
		[Address(RVA = "0x1FEFAF0", Offset = "0x1FEFBF1", VA = "0x1FEFAF0")]
		internal int <Lottery>b__7_1(GluttonItem x)
		{
			return 0;
		}

		// Token: 0x04006690 RID: 26256
		[Token(Token = "0x4019230")]
		[FieldOffset(Offset = "0x0")]
		public static readonly GluttonLotteryDataTable.<>c <>9;

		// Token: 0x04006691 RID: 26257
		[Token(Token = "0x4019231")]
		[FieldOffset(Offset = "0x8")]
		public static Func<GluttonItem, int> <>9__7_0;

		// Token: 0x04006692 RID: 26258
		[Token(Token = "0x4019232")]
		[FieldOffset(Offset = "0x10")]
		public static Func<GluttonItem, int> <>9__7_1;
	}
}
