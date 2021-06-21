using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002AC RID: 684
[Token(Token = "0x200021C")]
public class OnGroundItemPickupCollider : InteractionColliderBase
{
	// Token: 0x060011CB RID: 4555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001035")]
	[Address(RVA = "0x20C51D0", Offset = "0x20C52D1", VA = "0x20C51D0")]
	public void DoUpdate()
	{
	}

	// Token: 0x060011CC RID: 4556 RVA: 0x00008268 File Offset: 0x00006468
	[Token(Token = "0x6001036")]
	[Address(RVA = "0x20C5AF0", Offset = "0x20C5BF1", VA = "0x20C5AF0")]
	public static OnGroundItemPickupCollider.AutoPickUpType CheckAutoPickUpType(OnGroundItem onGroundItem, ActorController controller, bool isHandCuffs)
	{
		return OnGroundItemPickupCollider.AutoPickUpType.Not;
	}

	// Token: 0x060011CD RID: 4557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001037")]
	[Address(RVA = "0x20C5E20", Offset = "0x20C5F21", VA = "0x20C5E20")]
	public OnGroundItemPickupCollider()
	{
	}

	// Token: 0x04000A05 RID: 2565
	[Token(Token = "0x40007E9")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool m_IsHandCuffs;

	// Token: 0x020002AD RID: 685
	[Token(Token = "0x2001019")]
	public enum AutoPickUpType
	{
		// Token: 0x04000A07 RID: 2567
		[Token(Token = "0x4018E90")]
		Not,
		// Token: 0x04000A08 RID: 2568
		[Token(Token = "0x4018E91")]
		Hold,
		// Token: 0x04000A09 RID: 2569
		[Token(Token = "0x4018E92")]
		HoldMerge,
		// Token: 0x04000A0A RID: 2570
		[Token(Token = "0x4018E93")]
		Ruck
	}
}
