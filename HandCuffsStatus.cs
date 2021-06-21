using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020008A6 RID: 2214
[Token(Token = "0x20005BC")]
public class HandCuffsStatus : MonsterStatusBase
{
	// Token: 0x17000844 RID: 2116
	// (get) Token: 0x06003A91 RID: 14993 RVA: 0x00014670 File Offset: 0x00012870
	[Token(Token = "0x17000689")]
	public override Alliance Alliance
	{
		[Token(Token = "0x60030FF")]
		[Address(RVA = "0x24E6480", Offset = "0x24E6581", VA = "0x24E6480", Slot = "6")]
		get
		{
			return Alliance.None;
		}
	}

	// Token: 0x17000845 RID: 2117
	// (get) Token: 0x06003A92 RID: 14994 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700068A")]
	public override string Name
	{
		[Token(Token = "0x6003100")]
		[Address(RVA = "0x24E6490", Offset = "0x24E6591", VA = "0x24E6490", Slot = "26")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000846 RID: 2118
	// (get) Token: 0x06003A93 RID: 14995 RVA: 0x00014688 File Offset: 0x00012888
	[Token(Token = "0x1700068B")]
	public override MonsterDataID MonsterDataID
	{
		[Token(Token = "0x6003101")]
		[Address(RVA = "0x24E64A0", Offset = "0x24E65A1", VA = "0x24E64A0", Slot = "27")]
		get
		{
			return MonsterDataID.MonsterData_EMPTY;
		}
	}

	// Token: 0x17000847 RID: 2119
	// (get) Token: 0x06003A94 RID: 14996 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700068C")]
	public EnemyStatusData EnemyStatusData
	{
		[Token(Token = "0x6003102")]
		[Address(RVA = "0x24E6530", Offset = "0x24E6631", VA = "0x24E6530")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000848 RID: 2120
	// (get) Token: 0x06003A95 RID: 14997 RVA: 0x000146A0 File Offset: 0x000128A0
	[Token(Token = "0x1700068D")]
	protected override float PoisonDamagePercent
	{
		[Token(Token = "0x6003103")]
		[Address(RVA = "0x24E65D0", Offset = "0x24E66D1", VA = "0x24E65D0", Slot = "16")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000849 RID: 2121
	// (get) Token: 0x06003A96 RID: 14998 RVA: 0x000146B8 File Offset: 0x000128B8
	// (set) Token: 0x06003A97 RID: 14999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700068E")]
	public override int BrushCount
	{
		[Token(Token = "0x6003104")]
		[Address(RVA = "0x24E65E0", Offset = "0x24E66E1", VA = "0x24E65E0", Slot = "22")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003105")]
		[Address(RVA = "0x24E65F0", Offset = "0x24E66F1", VA = "0x24E65F0", Slot = "23")]
		set
		{
		}
	}

	// Token: 0x1700084A RID: 2122
	// (get) Token: 0x06003A98 RID: 15000 RVA: 0x000146D0 File Offset: 0x000128D0
	// (set) Token: 0x06003A99 RID: 15001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700068F")]
	public override int PresentCount
	{
		[Token(Token = "0x6003106")]
		[Address(RVA = "0x24E6600", Offset = "0x24E6701", VA = "0x24E6600", Slot = "24")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003107")]
		[Address(RVA = "0x24E6610", Offset = "0x24E6711", VA = "0x24E6610", Slot = "25")]
		set
		{
		}
	}

	// Token: 0x06003A9A RID: 15002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003108")]
	[Address(RVA = "0x24E6620", Offset = "0x24E6721", VA = "0x24E6620", Slot = "20")]
	protected override void LevelUp()
	{
	}

	// Token: 0x06003A9B RID: 15003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003109")]
	[Address(RVA = "0x24E6630", Offset = "0x24E6731", VA = "0x24E6630")]
	public HandCuffsStatus(EnemyStatusData statusData)
	{
	}

	// Token: 0x04007D9B RID: 32155
	[Token(Token = "0x400718D")]
	[FieldOffset(Offset = "0x230")]
	private int m_BrushCount;

	// Token: 0x04007D9C RID: 32156
	[Token(Token = "0x400718E")]
	[FieldOffset(Offset = "0x234")]
	private int m_PresentCount;

	// Token: 0x04007D9D RID: 32157
	[Token(Token = "0x400718F")]
	[FieldOffset(Offset = "0x238")]
	private string FocusName;
}
