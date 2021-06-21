using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020000F7 RID: 247
[Token(Token = "0x20000C2")]
public abstract class PartyBase
{
	// Token: 0x17000139 RID: 313
	// (get) Token: 0x0600054E RID: 1358 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600054F RID: 1359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000133")]
	public PartyData Data
	{
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x213AA30", Offset = "0x213AB31", VA = "0x213AA30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A490", Offset = "0x19A591")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x213AA40", Offset = "0x213AB41", VA = "0x213AA40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A4A0", Offset = "0x19A5A1")]
		private set
		{
		}
	}

	// Token: 0x1700013A RID: 314
	// (get) Token: 0x06000550 RID: 1360 RVA: 0x00003EE8 File Offset: 0x000020E8
	[Token(Token = "0x17000134")]
	public int PartyNo
	{
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x213AA50", Offset = "0x213AB51", VA = "0x213AA50")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700013B RID: 315
	// (get) Token: 0x06000551 RID: 1361 RVA: 0x00003F00 File Offset: 0x00002100
	// (set) Token: 0x06000552 RID: 1362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000135")]
	public ActorID ActorId
	{
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x213AA70", Offset = "0x213AB71", VA = "0x213AA70")]
		get
		{
			return ActorID.act000;
		}
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x213AA90", Offset = "0x213AB91", VA = "0x213AA90")]
		set
		{
		}
	}

	// Token: 0x1700013C RID: 316
	// (get) Token: 0x06000553 RID: 1363 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000136")]
	public Actor Actor
	{
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x213AAB0", Offset = "0x213ABB1", VA = "0x213AAB0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700013D RID: 317
	// (get) Token: 0x06000554 RID: 1364 RVA: 0x00003F18 File Offset: 0x00002118
	[Token(Token = "0x17000137")]
	public bool IsActive
	{
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x213AAD0", Offset = "0x213ABD1", VA = "0x213AAD0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700013E RID: 318
	// (get) Token: 0x06000555 RID: 1365 RVA: 0x00003F30 File Offset: 0x00002130
	[Token(Token = "0x17000138")]
	public virtual PartyType PartyType
	{
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x213ABB0", Offset = "0x213ACB1", VA = "0x213ABB0", Slot = "4")]
		get
		{
			return PartyType.Player;
		}
	}

	// Token: 0x1700013F RID: 319
	// (get) Token: 0x06000556 RID: 1366 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000139")]
	public virtual CharacterStatusBase Status
	{
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x213ABC0", Offset = "0x213ACC1", VA = "0x213ABC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000140 RID: 320
	// (get) Token: 0x06000557 RID: 1367 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700013A")]
	public ActorController ActorController
	{
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x213ABD0", Offset = "0x213ACD1", VA = "0x213ABD0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600047D")]
	[Address(RVA = "0x213AC00", Offset = "0x213AD01", VA = "0x213AC00")]
	public PartyBase(PartyData partyData)
	{
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600047E")]
	[Address(RVA = "0x213AC40", Offset = "0x213AD41", VA = "0x213AC40", Slot = "6")]
	public virtual void PartyIn()
	{
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600047F")]
	[Address(RVA = "0x213AC50", Offset = "0x213AD51", VA = "0x213AC50", Slot = "7")]
	public virtual void PartyOut()
	{
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000480")]
	[Address(RVA = "0x213AC60", Offset = "0x213AD61", VA = "0x213AC60", Slot = "8")]
	protected virtual void PartyEventUpdate(int hour)
	{
	}

	// Token: 0x040002C7 RID: 711
	[Token(Token = "0x4000228")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15BB10", Offset = "0x15BC11")]
	private PartyData <Data>k__BackingField;
}
