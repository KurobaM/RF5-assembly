using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001DD RID: 477
[Token(Token = "0x200017B")]
public class HandCuffsThrowObserve : NormalizedTimeObserve
{
	// Token: 0x060009BE RID: 2494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600086F")]
	[Address(RVA = "0x24E67B0", Offset = "0x24E68B1", VA = "0x24E67B0", Slot = "19")]
	public override void DoEvent()
	{
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000870")]
	[Address(RVA = "0x24E6880", Offset = "0x24E6981", VA = "0x24E6880")]
	public void Setup(ActorID actorID)
	{
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000871")]
	[Address(RVA = "0x24E6890", Offset = "0x24E6991", VA = "0x24E6890")]
	public HandCuffsThrowObserve()
	{
	}

	// Token: 0x04000628 RID: 1576
	[Token(Token = "0x40004D1")]
	[FieldOffset(Offset = "0x21")]
	[SerializeField]
	private bool m_IsCharge;

	// Token: 0x04000629 RID: 1577
	[Token(Token = "0x40004D2")]
	[FieldOffset(Offset = "0x24")]
	private ActorID m_ActorID;
}
