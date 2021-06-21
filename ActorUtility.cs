using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;

// Token: 0x020000ED RID: 237
[Token(Token = "0x20000BE")]
public static class ActorUtility
{
	// Token: 0x06000514 RID: 1300 RVA: 0x00003D80 File Offset: 0x00001F80
	[Token(Token = "0x6000446")]
	[Address(RVA = "0x1D54130", Offset = "0x1D54231", VA = "0x1D54130")]
	public static CharID NpcIDToCharaID(NPCID npcId)
	{
		return CharID.ch000;
	}

	// Token: 0x040002AD RID: 685
	[Token(Token = "0x4000218")]
	[FieldOffset(Offset = "0x0")]
	public static readonly Dictionary<ActorID, NPCID> ActorIdToNpcId;

	// Token: 0x040002AE RID: 686
	[Token(Token = "0x4000219")]
	[FieldOffset(Offset = "0x8")]
	public static readonly Dictionary<NPCID, ActorID> NpcIdToActorId;

	// Token: 0x040002AF RID: 687
	[Token(Token = "0x400021A")]
	[FieldOffset(Offset = "0x10")]
	public static readonly Dictionary<CharID, NPCID> CharIdToNpcId;

	// Token: 0x040002B0 RID: 688
	[Token(Token = "0x400021B")]
	[FieldOffset(Offset = "0x18")]
	private static readonly Dictionary<NPCID, CharID> NpcIdToCharId;

	// Token: 0x040002B1 RID: 689
	[Token(Token = "0x400021C")]
	[FieldOffset(Offset = "0x20")]
	public static readonly Dictionary<NPCID, HairType[]> ChildCombination;

	// Token: 0x040002B2 RID: 690
	[Token(Token = "0x400021D")]
	[FieldOffset(Offset = "0x28")]
	public static readonly Dictionary<NPCID, ActorUtility.ActorCreateData> NpcIdToActorCreateData;

	// Token: 0x020000EE RID: 238
	[Token(Token = "0x2000FB9")]
	public class ActorCreateData
	{
		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00003D98 File Offset: 0x00001F98
		[Token(Token = "0x17000BC0")]
		public CharID CharacterID
		{
			[Token(Token = "0x6006BB9")]
			[Address(RVA = "0x1D55AE0", Offset = "0x1D55BE1", VA = "0x1D55AE0")]
			get
			{
				return CharID.ch000;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[Token(Token = "0x17000BC1")]
		public VariationNo VaritationNo
		{
			[Token(Token = "0x6006BBA")]
			[Address(RVA = "0x1D55AF0", Offset = "0x1D55BF1", VA = "0x1D55AF0")]
			get
			{
				return VariationNo.VARIA_000;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[Token(Token = "0x17000BC2")]
		public HairType HairType
		{
			[Token(Token = "0x6006BBB")]
			[Address(RVA = "0x1D55B00", Offset = "0x1D55C01", VA = "0x1D55B00")]
			get
			{
				return HairType.HAIR00_00;
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BBC")]
		[Address(RVA = "0x1D55AA0", Offset = "0x1D55BA1", VA = "0x1D55AA0")]
		public ActorCreateData(CharID _charaId, VariationNo _variaNo, HairType _hairType)
		{
		}

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x4018D0D")]
		[FieldOffset(Offset = "0x10")]
		private CharID charaId;

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x4018D0E")]
		[FieldOffset(Offset = "0x14")]
		private VariationNo variaNo;

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x4018D0F")]
		[FieldOffset(Offset = "0x18")]
		private HairType hairType;
	}
}
