using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020001DC RID: 476
[Token(Token = "0x200017A")]
public abstract class GrappleThrowObserve : NormalizedTimeObserve
{
	// Token: 0x060009BB RID: 2491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600086C")]
	[Address(RVA = "0x1FF7030", Offset = "0x1FF7131", VA = "0x1FF7030", Slot = "19")]
	public override void DoEvent()
	{
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600086D")]
	[Address(RVA = "0x1FF71F0", Offset = "0x1FF72F1", VA = "0x1FF71F0")]
	public void Setup(ActorID actorID, float angle, float power, MagicParamID id1, MagicParamID id2)
	{
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600086E")]
	[Address(RVA = "0x1FF69D0", Offset = "0x1FF6AD1", VA = "0x1FF69D0")]
	protected GrappleThrowObserve()
	{
	}

	// Token: 0x04000623 RID: 1571
	[Token(Token = "0x40004CC")]
	[FieldOffset(Offset = "0x24")]
	private ActorID m_ActorID;

	// Token: 0x04000624 RID: 1572
	[Token(Token = "0x40004CD")]
	[FieldOffset(Offset = "0x28")]
	private float m_ThrowAngle;

	// Token: 0x04000625 RID: 1573
	[Token(Token = "0x40004CE")]
	[FieldOffset(Offset = "0x2C")]
	private float m_ThrowPower;

	// Token: 0x04000626 RID: 1574
	[Token(Token = "0x40004CF")]
	[FieldOffset(Offset = "0x30")]
	private MagicParamID m_ParamID1;

	// Token: 0x04000627 RID: 1575
	[Token(Token = "0x40004D0")]
	[FieldOffset(Offset = "0x34")]
	private MagicParamID m_ParamID2;
}
