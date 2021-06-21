using System;
using Il2CppDummyDll;

// Token: 0x020002D6 RID: 726
[Token(Token = "0x2000237")]
[Attribute(Name = "DefaultMemberAttribute", RVA = "0x145A20", Offset = "0x145B21")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x145A20", Offset = "0x145B21")]
public struct BitVector32Int
{
	// Token: 0x17000372 RID: 882
	// (get) Token: 0x06001361 RID: 4961 RVA: 0x00008B38 File Offset: 0x00006D38
	// (set) Token: 0x06001362 RID: 4962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700033E")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8560", Offset = "0x1B8661")]
	public bool Item
	{
		[Token(Token = "0x60011A4")]
		[Address(RVA = "0x2F2780", Offset = "0x2F2881", VA = "0x2F2780")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60011A5")]
		[Address(RVA = "0x2F27A0", Offset = "0x2F28A1", VA = "0x2F27A0")]
		set
		{
		}
	}

	// Token: 0x17000373 RID: 883
	// (get) Token: 0x06001363 RID: 4963 RVA: 0x00008B50 File Offset: 0x00006D50
	// (set) Token: 0x06001364 RID: 4964 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700033F")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8570", Offset = "0x1B8671")]
	public int Item
	{
		[Token(Token = "0x60011A6")]
		[Address(RVA = "0x2F27C0", Offset = "0x2F28C1", VA = "0x2F27C0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60011A7")]
		[Address(RVA = "0x2F2850", Offset = "0x2F2951", VA = "0x2F2850")]
		set
		{
		}
	}

	// Token: 0x17000374 RID: 884
	// (get) Token: 0x06001365 RID: 4965 RVA: 0x00008B68 File Offset: 0x00006D68
	[Token(Token = "0x17000340")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8580", Offset = "0x1B8681")]
	public int Data
	{
		[Token(Token = "0x60011A8")]
		[Address(RVA = "0x2F28A0", Offset = "0x2F29A1", VA = "0x2F28A0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06001366 RID: 4966 RVA: 0x00008B80 File Offset: 0x00006D80
	[Token(Token = "0x60011A9")]
	[Address(RVA = "0x24562F0", Offset = "0x24563F1", VA = "0x24562F0")]
	private static short CountBitsSet(uint mask)
	{
		return 0;
	}

	// Token: 0x06001367 RID: 4967 RVA: 0x00008B98 File Offset: 0x00006D98
	[Token(Token = "0x60011AA")]
	[Address(RVA = "0x2456320", Offset = "0x2456421", VA = "0x2456320")]
	public static int CreateMask()
	{
		return 0;
	}

	// Token: 0x06001368 RID: 4968 RVA: 0x00008BB0 File Offset: 0x00006DB0
	[Token(Token = "0x60011AB")]
	[Address(RVA = "0x2456360", Offset = "0x2456461", VA = "0x2456360")]
	public static int CreateMask(int previous)
	{
		return 0;
	}

	// Token: 0x06001369 RID: 4969 RVA: 0x00008BC8 File Offset: 0x00006DC8
	[Token(Token = "0x60011AC")]
	[Address(RVA = "0x2456400", Offset = "0x2456501", VA = "0x2456400")]
	private static uint CreateMaskFromHighValue(uint highValue)
	{
		return 0U;
	}

	// Token: 0x0600136A RID: 4970 RVA: 0x00008BE0 File Offset: 0x00006DE0
	[Token(Token = "0x60011AD")]
	[Address(RVA = "0x2456450", Offset = "0x2456551", VA = "0x2456450")]
	public static BitVector32Int.Section CreateSection(uint maxValue, bool signed = false)
	{
		return default(BitVector32Int.Section);
	}

	// Token: 0x0600136B RID: 4971 RVA: 0x00008BF8 File Offset: 0x00006DF8
	[Token(Token = "0x60011AE")]
	[Address(RVA = "0x2456630", Offset = "0x2456731", VA = "0x2456630")]
	public static BitVector32Int.Section CreateSection(uint maxValue, BitVector32Int.Section previous, bool signed = false)
	{
		return default(BitVector32Int.Section);
	}

	// Token: 0x0600136C RID: 4972 RVA: 0x00008C10 File Offset: 0x00006E10
	[Token(Token = "0x60011AF")]
	[Address(RVA = "0x2456460", Offset = "0x2456561", VA = "0x2456460")]
	private static BitVector32Int.Section CreateSectionHelper(uint maxValue, uint priorMask, short priorOffset, bool signed)
	{
		return default(BitVector32Int.Section);
	}

	// Token: 0x0600136D RID: 4973 RVA: 0x00008C28 File Offset: 0x00006E28
	[Token(Token = "0x60011B0")]
	[Address(RVA = "0x2F28B0", Offset = "0x2F29B1", VA = "0x2F28B0", Slot = "0")]
	public override bool Equals(object o)
	{
		return default(bool);
	}

	// Token: 0x0600136E RID: 4974 RVA: 0x00008C40 File Offset: 0x00006E40
	[Token(Token = "0x60011B1")]
	[Address(RVA = "0x2F2960", Offset = "0x2F2A61", VA = "0x2F2960", Slot = "2")]
	public override int GetHashCode()
	{
		return 0;
	}

	// Token: 0x0600136F RID: 4975 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011B2")]
	[Address(RVA = "0x24567A0", Offset = "0x24568A1", VA = "0x24567A0")]
	public static string ToString(BitVector32Int value)
	{
		return null;
	}

	// Token: 0x06001370 RID: 4976 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011B3")]
	[Address(RVA = "0x2F29E0", Offset = "0x2F2AE1", VA = "0x2F29E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x04000AE4 RID: 2788
	[Token(Token = "0x4000884")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "KeyAttribute", RVA = "0x15F430", Offset = "0x15F531")]
	public uint data;

	// Token: 0x020002D7 RID: 727
	[Token(Token = "0x2001028")]
	public struct Section
	{
		// Token: 0x06001371 RID: 4977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CA8")]
		[Address(RVA = "0x2F2A60", Offset = "0x2F2B61", VA = "0x2F2A60")]
		internal Section(uint mask, short offset, bool signed)
		{
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x00008C58 File Offset: 0x00006E58
		[Token(Token = "0x17000BF1")]
		public uint Mask
		{
			[Token(Token = "0x6006CA9")]
			[Address(RVA = "0x2F2A90", Offset = "0x2F2B91", VA = "0x2F2A90")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001373 RID: 4979 RVA: 0x00008C70 File Offset: 0x00006E70
		[Token(Token = "0x17000BF2")]
		public short Offset
		{
			[Token(Token = "0x6006CAA")]
			[Address(RVA = "0x2F2AA0", Offset = "0x2F2BA1", VA = "0x2F2AA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x00008C88 File Offset: 0x00006E88
		[Token(Token = "0x17000BF3")]
		public byte BitCount
		{
			[Token(Token = "0x6006CAB")]
			[Address(RVA = "0x2F2AB0", Offset = "0x2F2BB1", VA = "0x2F2AB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001375 RID: 4981 RVA: 0x00008CA0 File Offset: 0x00006EA0
		[Token(Token = "0x17000BF4")]
		public bool IsSigned
		{
			[Token(Token = "0x6006CAC")]
			[Address(RVA = "0x2F2AC0", Offset = "0x2F2BC1", VA = "0x2F2AC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00008CB8 File Offset: 0x00006EB8
		[Token(Token = "0x6006CAD")]
		[Address(RVA = "0x2F2AD0", Offset = "0x2F2BD1", VA = "0x2F2AD0", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x00008CD0 File Offset: 0x00006ED0
		[Token(Token = "0x6006CAE")]
		[Address(RVA = "0x2F2BA0", Offset = "0x2F2CA1", VA = "0x2F2BA0")]
		public bool Equals(BitVector32Int.Section obj)
		{
			return default(bool);
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x00008CE8 File Offset: 0x00006EE8
		[Token(Token = "0x6006CAF")]
		[Address(RVA = "0x24569E0", Offset = "0x2456AE1", VA = "0x24569E0")]
		public static bool operator ==(BitVector32Int.Section a, BitVector32Int.Section b)
		{
			return default(bool);
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x00008D00 File Offset: 0x00006F00
		[Token(Token = "0x6006CB0")]
		[Address(RVA = "0x2456A00", Offset = "0x2456B01", VA = "0x2456A00")]
		public static bool operator !=(BitVector32Int.Section a, BitVector32Int.Section b)
		{
			return default(bool);
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x00008D18 File Offset: 0x00006F18
		[Token(Token = "0x6006CB1")]
		[Address(RVA = "0x2F2BD0", Offset = "0x2F2CD1", VA = "0x2F2BD0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB2")]
		[Address(RVA = "0x2456AA0", Offset = "0x2456BA1", VA = "0x2456AA0")]
		public static string ToString(BitVector32Int.Section value)
		{
			return null;
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB3")]
		[Address(RVA = "0x2F2C50", Offset = "0x2F2D51", VA = "0x2F2C50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000AE5 RID: 2789
		[Token(Token = "0x4018ED3")]
		[FieldOffset(Offset = "0x0")]
		private readonly uint mask;

		// Token: 0x04000AE6 RID: 2790
		[Token(Token = "0x4018ED4")]
		[FieldOffset(Offset = "0x4")]
		private readonly short offset;

		// Token: 0x04000AE7 RID: 2791
		[Token(Token = "0x4018ED5")]
		[FieldOffset(Offset = "0x6")]
		private readonly byte bitCount;

		// Token: 0x04000AE8 RID: 2792
		[Token(Token = "0x4018ED6")]
		[FieldOffset(Offset = "0x7")]
		private readonly bool isSigned;
	}
}
