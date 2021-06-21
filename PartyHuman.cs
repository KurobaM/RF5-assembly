using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020000FA RID: 250
[Token(Token = "0x20000C5")]
[Serializable]
public class PartyHuman : PartyBase
{
	// Token: 0x17000146 RID: 326
	// (get) Token: 0x0600056C RID: 1388 RVA: 0x00003F60 File Offset: 0x00002160
	[Token(Token = "0x17000140")]
	public override PartyType PartyType
	{
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x213B770", Offset = "0x213B871", VA = "0x213B770", Slot = "4")]
		get
		{
			return PartyType.Player;
		}
	}

	// Token: 0x17000147 RID: 327
	// (get) Token: 0x0600056D RID: 1389 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000141")]
	public override CharacterStatusBase Status
	{
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x213B790", Offset = "0x213B891", VA = "0x213B790", Slot = "5")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000493")]
	[Address(RVA = "0x213B7B0", Offset = "0x213B8B1", VA = "0x213B7B0")]
	public PartyHuman(PartyData data)
	{
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000494")]
	[Address(RVA = "0x213B810", Offset = "0x213B911", VA = "0x213B810", Slot = "6")]
	public override void PartyIn()
	{
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000495")]
	[Address(RVA = "0x213B9B0", Offset = "0x213BAB1", VA = "0x213B9B0", Slot = "7")]
	public override void PartyOut()
	{
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000496")]
	[Address(RVA = "0x213BB60", Offset = "0x213BC61", VA = "0x213BB60", Slot = "8")]
	protected override void PartyEventUpdate(int hour)
	{
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000497")]
	[Address(RVA = "0x213BF80", Offset = "0x213C081", VA = "0x213BF80")]
	private void OnDeadEvent()
	{
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000498")]
	[Address(RVA = "0x213BB90", Offset = "0x213BC91", VA = "0x213BB90")]
	private void AddLovePoint(int diff)
	{
	}

	// Token: 0x06000574 RID: 1396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000499")]
	[Address(RVA = "0x213BD50", Offset = "0x213BE51", VA = "0x213BD50")]
	private void LeavePartnerByTime(int diff)
	{
	}
}
