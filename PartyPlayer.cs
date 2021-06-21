using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020000FC RID: 252
[Token(Token = "0x20000C7")]
[Serializable]
public class PartyPlayer : PartyBase
{
	// Token: 0x1700014B RID: 331
	// (get) Token: 0x0600057B RID: 1403 RVA: 0x00003F90 File Offset: 0x00002190
	[Token(Token = "0x17000145")]
	public override PartyType PartyType
	{
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x213C440", Offset = "0x213C541", VA = "0x213C440", Slot = "4")]
		get
		{
			return PartyType.Player;
		}
	}

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x0600057C RID: 1404 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000146")]
	public override CharacterStatusBase Status
	{
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x213C460", Offset = "0x213C561", VA = "0x213C460", Slot = "5")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x213C480", Offset = "0x213C581", VA = "0x213C480")]
	public PartyPlayer(PartyData data)
	{
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x213C4D0", Offset = "0x213C5D1", VA = "0x213C4D0", Slot = "6")]
	public override void PartyIn()
	{
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x213C4E0", Offset = "0x213C5E1", VA = "0x213C4E0", Slot = "7")]
	public override void PartyOut()
	{
	}
}
