using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020001D8 RID: 472
[Token(Token = "0x2000176")]
public class GrappleLiftObserve : NormalizedTimeObserve
{
	// Token: 0x060009B1 RID: 2481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000862")]
	[Address(RVA = "0x1FF69E0", Offset = "0x1FF6AE1", VA = "0x1FF69E0", Slot = "19")]
	public override void DoEvent()
	{
	}

	// Token: 0x060009B2 RID: 2482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000863")]
	[Address(RVA = "0x1FF6BB0", Offset = "0x1FF6CB1", VA = "0x1FF6BB0")]
	public void Setup(ActorID actorID)
	{
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000864")]
	[Address(RVA = "0x1FF6BC0", Offset = "0x1FF6CC1", VA = "0x1FF6BC0")]
	public GrappleLiftObserve()
	{
	}

	// Token: 0x04000620 RID: 1568
	[Token(Token = "0x40004C9")]
	[FieldOffset(Offset = "0x24")]
	private ActorID m_ActorID;
}
