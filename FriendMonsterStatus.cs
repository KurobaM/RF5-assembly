using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020008A5 RID: 2213
[Token(Token = "0x20005BB")]
public class FriendMonsterStatus : MonsterStatusBase
{
	// Token: 0x1700083B RID: 2107
	// (get) Token: 0x06003A7E RID: 14974 RVA: 0x00014568 File Offset: 0x00012768
	[Token(Token = "0x17000680")]
	public override Alliance Alliance
	{
		[Token(Token = "0x60030EC")]
		[Address(RVA = "0x23CD610", Offset = "0x23CD711", VA = "0x23CD610", Slot = "6")]
		get
		{
			return Alliance.None;
		}
	}

	// Token: 0x1700083C RID: 2108
	// (get) Token: 0x06003A7F RID: 14975 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000681")]
	public override string Name
	{
		[Token(Token = "0x60030ED")]
		[Address(RVA = "0x23CD620", Offset = "0x23CD721", VA = "0x23CD620", Slot = "26")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700083D RID: 2109
	// (get) Token: 0x06003A80 RID: 14976 RVA: 0x00014580 File Offset: 0x00012780
	[Token(Token = "0x17000682")]
	public override MonsterDataID MonsterDataID
	{
		[Token(Token = "0x60030EE")]
		[Address(RVA = "0x23CD750", Offset = "0x23CD851", VA = "0x23CD750", Slot = "27")]
		get
		{
			return MonsterDataID.MonsterData_EMPTY;
		}
	}

	// Token: 0x1700083E RID: 2110
	// (get) Token: 0x06003A81 RID: 14977 RVA: 0x00014598 File Offset: 0x00012798
	[Token(Token = "0x17000683")]
	public uint FriendDataID
	{
		[Token(Token = "0x60030EF")]
		[Address(RVA = "0x23CD7E0", Offset = "0x23CD8E1", VA = "0x23CD7E0")]
		get
		{
			return 0U;
		}
	}

	// Token: 0x06003A82 RID: 14978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030F0")]
	[Address(RVA = "0x23CD870", Offset = "0x23CD971", VA = "0x23CD870")]
	public FriendMonsterStatus(FriendMonsterStatusData statusData)
	{
	}

	// Token: 0x1700083F RID: 2111
	// (get) Token: 0x06003A83 RID: 14979 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000684")]
	public FriendMonsterStatusData FriendMonsterStatusData
	{
		[Token(Token = "0x60030F1")]
		[Address(RVA = "0x23CD6B0", Offset = "0x23CD7B1", VA = "0x23CD6B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000840 RID: 2112
	// (get) Token: 0x06003A84 RID: 14980 RVA: 0x000145B0 File Offset: 0x000127B0
	[Token(Token = "0x17000685")]
	protected override float PoisonDamagePercent
	{
		[Token(Token = "0x60030F2")]
		[Address(RVA = "0x23CD8C0", Offset = "0x23CD9C1", VA = "0x23CD8C0", Slot = "16")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000841 RID: 2113
	// (get) Token: 0x06003A85 RID: 14981 RVA: 0x000145C8 File Offset: 0x000127C8
	// (set) Token: 0x06003A86 RID: 14982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000686")]
	public int LoveLV
	{
		[Token(Token = "0x60030F3")]
		[Address(RVA = "0x23CD8D0", Offset = "0x23CD9D1", VA = "0x23CD8D0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60030F4")]
		[Address(RVA = "0x23CD960", Offset = "0x23CDA61", VA = "0x23CD960")]
		set
		{
		}
	}

	// Token: 0x17000842 RID: 2114
	// (get) Token: 0x06003A87 RID: 14983 RVA: 0x000145E0 File Offset: 0x000127E0
	// (set) Token: 0x06003A88 RID: 14984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000687")]
	public override int BrushCount
	{
		[Token(Token = "0x60030F5")]
		[Address(RVA = "0x23CD970", Offset = "0x23CDA71", VA = "0x23CD970", Slot = "22")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60030F6")]
		[Address(RVA = "0x23CDA00", Offset = "0x23CDB01", VA = "0x23CDA00", Slot = "23")]
		set
		{
		}
	}

	// Token: 0x17000843 RID: 2115
	// (get) Token: 0x06003A89 RID: 14985 RVA: 0x000145F8 File Offset: 0x000127F8
	// (set) Token: 0x06003A8A RID: 14986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000688")]
	public override int PresentCount
	{
		[Token(Token = "0x60030F7")]
		[Address(RVA = "0x23CDAA0", Offset = "0x23CDBA1", VA = "0x23CDAA0", Slot = "24")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60030F8")]
		[Address(RVA = "0x23CDB30", Offset = "0x23CDC31", VA = "0x23CDB30", Slot = "25")]
		set
		{
		}
	}

	// Token: 0x06003A8B RID: 14987 RVA: 0x00014610 File Offset: 0x00012810
	[Token(Token = "0x60030F9")]
	[Address(RVA = "0x23CDBD0", Offset = "0x23CDCD1", VA = "0x23CDBD0")]
	public int AddLovePoint(MonsterLovePoint.FluctuationType type, int AddLikePoint = 0, bool isRenew = true)
	{
		return 0;
	}

	// Token: 0x06003A8C RID: 14988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030FA")]
	[Address(RVA = "0x23CDCA0", Offset = "0x23CDDA1", VA = "0x23CDCA0", Slot = "20")]
	protected override void LevelUp()
	{
	}

	// Token: 0x06003A8D RID: 14989 RVA: 0x00014628 File Offset: 0x00012828
	[Token(Token = "0x60030FB")]
	[Address(RVA = "0x23CDE00", Offset = "0x23CDF01", VA = "0x23CDE00")]
	public bool AddDefeatBonus(MonsterDataID monsterDataID)
	{
		return default(bool);
	}

	// Token: 0x06003A8E RID: 14990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030FC")]
	[Address(RVA = "0x23CE4D0", Offset = "0x23CE5D1", VA = "0x23CE4D0")]
	public void Present(ItemData item, out bool isFavorite)
	{
	}

	// Token: 0x06003A8F RID: 14991 RVA: 0x00014640 File Offset: 0x00012840
	[Token(Token = "0x60030FD")]
	[Address(RVA = "0x23CE870", Offset = "0x23CE971", VA = "0x23CE870")]
	private static Parameter PresentStatusUp_Item(ItemData item, bool isFav)
	{
		return default(Parameter);
	}

	// Token: 0x06003A90 RID: 14992 RVA: 0x00014658 File Offset: 0x00012858
	[Token(Token = "0x60030FE")]
	[Address(RVA = "0x23CEB50", Offset = "0x23CEC51", VA = "0x23CEB50")]
	private static Parameter PresentStatusUp_Category(ItemCategory category)
	{
		return default(Parameter);
	}
}
