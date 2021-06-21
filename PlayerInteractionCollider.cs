using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002BF RID: 703
[Token(Token = "0x2000225")]
public class PlayerInteractionCollider : SingletonMonoBehaviour<PlayerInteractionCollider>
{
	// Token: 0x17000347 RID: 839
	// (get) Token: 0x06001276 RID: 4726 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700031D")]
	public BoxCollider FarmRapidCollider
	{
		[Token(Token = "0x60010D7")]
		[Address(RVA = "0x214BDC0", Offset = "0x214BEC1", VA = "0x214BDC0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000348 RID: 840
	// (get) Token: 0x06001277 RID: 4727 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700031E")]
	public static InteractionCollider InteractionCollider
	{
		[Token(Token = "0x60010D8")]
		[Address(RVA = "0x214BDD0", Offset = "0x214BED1", VA = "0x214BDD0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000349 RID: 841
	// (get) Token: 0x06001278 RID: 4728 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700031F")]
	public static OnGroundItemPickupCollider OnGroundItemPickupCollider
	{
		[Token(Token = "0x60010D9")]
		[Address(RVA = "0x214BE30", Offset = "0x214BF31", VA = "0x214BE30")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700034A RID: 842
	// (get) Token: 0x06001279 RID: 4729 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000320")]
	public static SymbolFieldInteractionCollider SymbolFieldInteractionCollider
	{
		[Token(Token = "0x60010DA")]
		[Address(RVA = "0x214BE90", Offset = "0x214BF91", VA = "0x214BE90")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600127A RID: 4730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010DB")]
	[Address(RVA = "0x214BEF0", Offset = "0x214BFF1", VA = "0x214BEF0")]
	private void FixedUpdate()
	{
	}

	// Token: 0x0600127B RID: 4731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010DC")]
	[Address(RVA = "0x214BF00", Offset = "0x214C001", VA = "0x214BF00")]
	private void DoUpdate()
	{
	}

	// Token: 0x0600127C RID: 4732 RVA: 0x00008730 File Offset: 0x00006930
	[Token(Token = "0x60010DD")]
	[Address(RVA = "0x214CC00", Offset = "0x214CD01", VA = "0x214CC00")]
	public static bool CanInteraction(HumanController human)
	{
		return default(bool);
	}

	// Token: 0x0600127D RID: 4733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010DE")]
	[Address(RVA = "0x214CD70", Offset = "0x214CE71", VA = "0x214CD70")]
	public static void DoInteraction(HumanController human)
	{
	}

	// Token: 0x0600127E RID: 4734 RVA: 0x00008748 File Offset: 0x00006948
	[Token(Token = "0x60010DF")]
	[Address(RVA = "0x214AEF0", Offset = "0x214AFF1", VA = "0x214AEF0")]
	public static bool CanInteraction(MonsterControllerBase monster)
	{
		return default(bool);
	}

	// Token: 0x0600127F RID: 4735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010E0")]
	[Address(RVA = "0x214B060", Offset = "0x214B161", VA = "0x214B060")]
	public static void DoInteraction(MonsterControllerBase monster)
	{
	}

	// Token: 0x06001280 RID: 4736 RVA: 0x00008760 File Offset: 0x00006960
	[Token(Token = "0x60010E1")]
	[Address(RVA = "0x214CF50", Offset = "0x214D051", VA = "0x214CF50")]
	public static bool CanItemInteraction(HumanController human)
	{
		return default(bool);
	}

	// Token: 0x06001281 RID: 4737 RVA: 0x00008778 File Offset: 0x00006978
	[Token(Token = "0x60010E2")]
	[Address(RVA = "0x214D0C0", Offset = "0x214D1C1", VA = "0x214D0C0")]
	public static bool CanRapidItemInteraction(HumanController human)
	{
		return default(bool);
	}

	// Token: 0x06001282 RID: 4738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010E3")]
	[Address(RVA = "0x214D230", Offset = "0x214D331", VA = "0x214D230")]
	public static void DoItemInteraction(HumanController human)
	{
	}

	// Token: 0x06001283 RID: 4739 RVA: 0x00008790 File Offset: 0x00006990
	[Token(Token = "0x60010E4")]
	[Address(RVA = "0x214CA80", Offset = "0x214CB81", VA = "0x214CA80")]
	private int FindClosestRotationIndex(Vector3 vector)
	{
		return 0;
	}

	// Token: 0x06001284 RID: 4740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010E5")]
	[Address(RVA = "0x214D440", Offset = "0x214D541", VA = "0x214D440")]
	public PlayerInteractionCollider()
	{
	}

	// Token: 0x04000A71 RID: 2673
	[Token(Token = "0x4000825")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private InteractionCollider m_InteractionCollider;

	// Token: 0x04000A72 RID: 2674
	[Token(Token = "0x4000826")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private OnGroundItemPickupCollider m_OnGroundItemPickupCollider;

	// Token: 0x04000A73 RID: 2675
	[Token(Token = "0x4000827")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private FarmChargeInteraction m_FarmChargeInteraction;

	// Token: 0x04000A74 RID: 2676
	[Token(Token = "0x4000828")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private BoxCollider m_FarmRapidCollider;

	// Token: 0x04000A75 RID: 2677
	[Token(Token = "0x4000829")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private SymbolFieldInteractionCollider m_SymbolFieldInteractionCollider;

	// Token: 0x04000A76 RID: 2678
	[Token(Token = "0x400082A")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x15F0C0", Offset = "0x15F1C1")]
	private static readonly ValueTuple<Vector3, Quaternion>[] FarmColliderRotations;
}
