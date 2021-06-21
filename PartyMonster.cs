using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020000FB RID: 251
[Token(Token = "0x20000C6")]
[Serializable]
public class PartyMonster : PartyBase
{
	// Token: 0x17000148 RID: 328
	// (get) Token: 0x06000575 RID: 1397 RVA: 0x00003F78 File Offset: 0x00002178
	[Token(Token = "0x17000142")]
	public override PartyType PartyType
	{
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x213C0F0", Offset = "0x213C1F1", VA = "0x213C0F0", Slot = "4")]
		get
		{
			return PartyType.Player;
		}
	}

	// Token: 0x17000149 RID: 329
	// (get) Token: 0x06000576 RID: 1398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000143")]
	public override CharacterStatusBase Status
	{
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x213C110", Offset = "0x213C211", VA = "0x213C110", Slot = "5")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700014A RID: 330
	// (get) Token: 0x06000577 RID: 1399 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000144")]
	public FriendMonsterStatus FriendMonsterStatus
	{
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x213C180", Offset = "0x213C281", VA = "0x213C180")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600049D")]
	[Address(RVA = "0x213C220", Offset = "0x213C321", VA = "0x213C220")]
	public PartyMonster(PartyData data)
	{
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600049E")]
	[Address(RVA = "0x213C270", Offset = "0x213C371", VA = "0x213C270", Slot = "6")]
	public override void PartyIn()
	{
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600049F")]
	[Address(RVA = "0x213C330", Offset = "0x213C431", VA = "0x213C330", Slot = "7")]
	public override void PartyOut()
	{
	}
}
