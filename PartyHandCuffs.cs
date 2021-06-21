using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020000F9 RID: 249
[Token(Token = "0x20000C4")]
[Serializable]
public class PartyHandCuffs : PartyBase
{
	// Token: 0x17000141 RID: 321
	// (get) Token: 0x0600055F RID: 1375 RVA: 0x00003F48 File Offset: 0x00002148
	[Token(Token = "0x1700013B")]
	public override PartyType PartyType
	{
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x213AD20", Offset = "0x213AE21", VA = "0x213AD20", Slot = "4")]
		get
		{
			return PartyType.Player;
		}
	}

	// Token: 0x17000142 RID: 322
	// (get) Token: 0x06000560 RID: 1376 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000561 RID: 1377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700013C")]
	public EnemyStatusData StatusData
	{
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x213AD40", Offset = "0x213AE41", VA = "0x213AD40")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x213AD60", Offset = "0x213AE61", VA = "0x213AD60")]
		set
		{
		}
	}

	// Token: 0x17000143 RID: 323
	// (get) Token: 0x06000562 RID: 1378 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000563 RID: 1379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700013D")]
	public MonsterControllerBase MonsterController
	{
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x213AD80", Offset = "0x213AE81", VA = "0x213AD80")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x213AE90", Offset = "0x213AF91", VA = "0x213AE90")]
		set
		{
		}
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000489")]
	[Address(RVA = "0x213AEA0", Offset = "0x213AFA1", VA = "0x213AEA0")]
	public PartyHandCuffs(PartyData data)
	{
	}

	// Token: 0x17000144 RID: 324
	// (get) Token: 0x06000565 RID: 1381 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700013E")]
	public override CharacterStatusBase Status
	{
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x213AEF0", Offset = "0x213AFF1", VA = "0x213AEF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000145 RID: 325
	// (get) Token: 0x06000566 RID: 1382 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700013F")]
	public HandCuffsStatus HandCuffsStatus
	{
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x213AFA0", Offset = "0x213B0A1", VA = "0x213AFA0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600048C")]
	[Address(RVA = "0x213B040", Offset = "0x213B141", VA = "0x213B040", Slot = "6")]
	public override void PartyIn()
	{
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600048D")]
	[Address(RVA = "0x213B430", Offset = "0x213B531", VA = "0x213B430", Slot = "7")]
	public override void PartyOut()
	{
	}

	// Token: 0x06000569 RID: 1385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600048E")]
	[Address(RVA = "0x213B570", Offset = "0x213B671", VA = "0x213B570")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A4B0", Offset = "0x19A5B1")]
	private void <PartyIn>b__16_0(TimeManager.JustTimerData timeData)
	{
	}

	// Token: 0x0600056A RID: 1386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600048F")]
	[Address(RVA = "0x213B620", Offset = "0x213B721", VA = "0x213B620")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A4C0", Offset = "0x19A5C1")]
	private void <PartyIn>b__16_1()
	{
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000490")]
	[Address(RVA = "0x213B750", Offset = "0x213B851", VA = "0x213B750")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A4D0", Offset = "0x19A5D1")]
	private void <PartyIn>b__16_2()
	{
	}

	// Token: 0x040002CE RID: 718
	[Token(Token = "0x400022F")]
	[FieldOffset(Offset = "0x18")]
	private MonsterControllerBase monsterController;

	// Token: 0x040002CF RID: 719
	[Token(Token = "0x4000230")]
	[FieldOffset(Offset = "0x20")]
	private HandCuffsStatus handCuffsStatusData;

	// Token: 0x040002D0 RID: 720
	[Token(Token = "0x4000231")]
	[FieldOffset(Offset = "0x28")]
	private TimeManager.JustTimerData JustTimePartyOutData;
}
