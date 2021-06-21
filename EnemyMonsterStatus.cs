using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020008A3 RID: 2211
[Token(Token = "0x20005B9")]
public class EnemyMonsterStatus : MonsterStatusBase
{
	// Token: 0x17000833 RID: 2099
	// (get) Token: 0x06003A70 RID: 14960 RVA: 0x000144D8 File Offset: 0x000126D8
	[Token(Token = "0x17000678")]
	public override Alliance Alliance
	{
		[Token(Token = "0x60030DE")]
		[Address(RVA = "0x22B3DE0", Offset = "0x22B3EE1", VA = "0x22B3DE0", Slot = "6")]
		get
		{
			return Alliance.None;
		}
	}

	// Token: 0x17000834 RID: 2100
	// (get) Token: 0x06003A71 RID: 14961 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000679")]
	public override string Name
	{
		[Token(Token = "0x60030DF")]
		[Address(RVA = "0x22B3DF0", Offset = "0x22B3EF1", VA = "0x22B3DF0", Slot = "26")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000835 RID: 2101
	// (get) Token: 0x06003A72 RID: 14962 RVA: 0x000144F0 File Offset: 0x000126F0
	[Token(Token = "0x1700067A")]
	public override MonsterDataID MonsterDataID
	{
		[Token(Token = "0x60030E0")]
		[Address(RVA = "0x22B3E00", Offset = "0x22B3F01", VA = "0x22B3E00", Slot = "27")]
		get
		{
			return MonsterDataID.MonsterData_EMPTY;
		}
	}

	// Token: 0x17000836 RID: 2102
	// (get) Token: 0x06003A73 RID: 14963 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700067B")]
	public EnemyStatusData EnemyStatusData
	{
		[Token(Token = "0x60030E1")]
		[Address(RVA = "0x22B3E90", Offset = "0x22B3F91", VA = "0x22B3E90")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000837 RID: 2103
	// (get) Token: 0x06003A74 RID: 14964 RVA: 0x00014508 File Offset: 0x00012708
	[Token(Token = "0x1700067C")]
	protected override float PoisonDamagePercent
	{
		[Token(Token = "0x60030E2")]
		[Address(RVA = "0x22B3F30", Offset = "0x22B4031", VA = "0x22B3F30", Slot = "16")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000838 RID: 2104
	// (get) Token: 0x06003A75 RID: 14965 RVA: 0x00014520 File Offset: 0x00012720
	// (set) Token: 0x06003A76 RID: 14966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700067D")]
	public override int BrushCount
	{
		[Token(Token = "0x60030E3")]
		[Address(RVA = "0x22B3F40", Offset = "0x22B4041", VA = "0x22B3F40", Slot = "22")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60030E4")]
		[Address(RVA = "0x22B3F50", Offset = "0x22B4051", VA = "0x22B3F50", Slot = "23")]
		set
		{
		}
	}

	// Token: 0x17000839 RID: 2105
	// (get) Token: 0x06003A77 RID: 14967 RVA: 0x00014538 File Offset: 0x00012738
	// (set) Token: 0x06003A78 RID: 14968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700067E")]
	public override int PresentCount
	{
		[Token(Token = "0x60030E5")]
		[Address(RVA = "0x22B3F60", Offset = "0x22B4061", VA = "0x22B3F60", Slot = "24")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60030E6")]
		[Address(RVA = "0x22B3F70", Offset = "0x22B4071", VA = "0x22B3F70", Slot = "25")]
		set
		{
		}
	}

	// Token: 0x06003A79 RID: 14969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030E7")]
	[Address(RVA = "0x22B3F80", Offset = "0x22B4081", VA = "0x22B3F80")]
	public EnemyMonsterStatus(int spawnLevel, MonsterControllerBase owner, MonsterDataID id)
	{
	}

	// Token: 0x06003A7A RID: 14970 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030E8")]
	[Address(RVA = "0x22B4380", Offset = "0x22B4481", VA = "0x22B4380", Slot = "20")]
	protected override void LevelUp()
	{
	}

	// Token: 0x06003A7B RID: 14971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030E9")]
	[Address(RVA = "0x22B4400", Offset = "0x22B4501", VA = "0x22B4400", Slot = "21")]
	protected override void LevelDown()
	{
	}

	// Token: 0x04007D98 RID: 32152
	[Token(Token = "0x400718A")]
	[FieldOffset(Offset = "0x230")]
	private int m_BrushCount;

	// Token: 0x04007D99 RID: 32153
	[Token(Token = "0x400718B")]
	[FieldOffset(Offset = "0x234")]
	private int m_PresentCount;

	// Token: 0x04007D9A RID: 32154
	[Token(Token = "0x400718C")]
	[FieldOffset(Offset = "0x238")]
	private string FocusName;
}
