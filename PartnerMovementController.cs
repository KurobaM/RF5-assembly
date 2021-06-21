using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x020002AF RID: 687
[Token(Token = "0x200021E")]
public class PartnerMovementController
{
	// Token: 0x060011D5 RID: 4565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600103F")]
	[Address(RVA = "0x23294F0", Offset = "0x23295F1", VA = "0x23294F0")]
	public PartnerMovementController(PartnerNPCBehaviorController controller)
	{
	}

	// Token: 0x060011D6 RID: 4566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001040")]
	[Address(RVA = "0x2328B20", Offset = "0x2328C21", VA = "0x2328B20")]
	public PartnerMovementController(PartnerMonsterBehaviorController controller)
	{
	}

	// Token: 0x060011D7 RID: 4567 RVA: 0x000082C8 File Offset: 0x000064C8
	[Token(Token = "0x6001041")]
	[Address(RVA = "0x2329650", Offset = "0x2329751", VA = "0x2329650")]
	public bool IsChangeMovementOrderType()
	{
		return default(bool);
	}

	// Token: 0x060011D8 RID: 4568 RVA: 0x000082E0 File Offset: 0x000064E0
	[Token(Token = "0x6001042")]
	[Address(RVA = "0x23296B0", Offset = "0x23297B1", VA = "0x23296B0")]
	public PartnerMovementOrderType GetMovementOrderType(bool isUpdatePrevious = false)
	{
		return PartnerMovementOrderType.None;
	}

	// Token: 0x060011D9 RID: 4569 RVA: 0x000082F8 File Offset: 0x000064F8
	[Token(Token = "0x6001043")]
	[Address(RVA = "0x2329720", Offset = "0x2329821", VA = "0x2329720")]
	private float GetMoveRangeByMovementOrder(PartnerMovementOrderType orderType)
	{
		return 0f;
	}

	// Token: 0x060011DA RID: 4570 RVA: 0x00008310 File Offset: 0x00006510
	[Token(Token = "0x6001044")]
	[Address(RVA = "0x2329750", Offset = "0x2329851", VA = "0x2329750")]
	public float CalcMargin(float range)
	{
		return 0f;
	}

	// Token: 0x060011DB RID: 4571 RVA: 0x00008328 File Offset: 0x00006528
	[Token(Token = "0x6001045")]
	[Address(RVA = "0x2329760", Offset = "0x2329861", VA = "0x2329760")]
	public bool TryGetMovementInformation(PartnerMovementOrderType orderType, out PartnerMovementController.MovementInformation info)
	{
		return default(bool);
	}

	// Token: 0x060011DC RID: 4572 RVA: 0x00008340 File Offset: 0x00006540
	[Token(Token = "0x6001046")]
	[Address(RVA = "0x2329A90", Offset = "0x2329B91", VA = "0x2329A90")]
	public Vector3 GetLeavePosition()
	{
		return default(Vector3);
	}

	// Token: 0x04000A0C RID: 2572
	[Token(Token = "0x40007EB")]
	private const float RangeMargin = 0.125f;

	// Token: 0x04000A0D RID: 2573
	[Token(Token = "0x40007EC")]
	[FieldOffset(Offset = "0x10")]
	private AIInput AIInput;

	// Token: 0x04000A0E RID: 2574
	[Token(Token = "0x40007ED")]
	[FieldOffset(Offset = "0x18")]
	private PartnerMovementController.StatusType CurrentStatusType;

	// Token: 0x04000A0F RID: 2575
	[Token(Token = "0x40007EE")]
	[FieldOffset(Offset = "0x20")]
	private HumanStatusData HumanStatusData;

	// Token: 0x04000A10 RID: 2576
	[Token(Token = "0x40007EF")]
	[FieldOffset(Offset = "0x28")]
	private EnemyStatusData HandCuffsMonsterStatusData;

	// Token: 0x04000A11 RID: 2577
	[Token(Token = "0x40007F0")]
	[FieldOffset(Offset = "0x30")]
	private FriendMonsterStatusData MonsterStatusData;

	// Token: 0x04000A12 RID: 2578
	[Token(Token = "0x40007F1")]
	[FieldOffset(Offset = "0x38")]
	private PartnerMovementOrderType PreviousOrderType;

	// Token: 0x04000A13 RID: 2579
	[Token(Token = "0x40007F2")]
	[FieldOffset(Offset = "0x3C")]
	private float CloseRange;

	// Token: 0x04000A14 RID: 2580
	[Token(Token = "0x40007F3")]
	[FieldOffset(Offset = "0x40")]
	private float LeaveRange;

	// Token: 0x04000A15 RID: 2581
	[Token(Token = "0x40007F4")]
	[FieldOffset(Offset = "0x48")]
	private NavMeshPath CalcPath;

	// Token: 0x04000A16 RID: 2582
	[Token(Token = "0x40007F5")]
	[FieldOffset(Offset = "0x50")]
	private Vector3[] CalcCorners;

	// Token: 0x020002B0 RID: 688
	[Token(Token = "0x200101A")]
	private enum StatusType
	{
		// Token: 0x04000A18 RID: 2584
		[Token(Token = "0x4018E95")]
		Human,
		// Token: 0x04000A19 RID: 2585
		[Token(Token = "0x4018E96")]
		FriendMonster,
		// Token: 0x04000A1A RID: 2586
		[Token(Token = "0x4018E97")]
		HandCuffsMonster
	}

	// Token: 0x020002B1 RID: 689
	[Token(Token = "0x200101B")]
	public class MovementInformation
	{
		// Token: 0x060011DD RID: 4573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C81")]
		[Address(RVA = "0x2134DF0", Offset = "0x2134EF1", VA = "0x2134DF0")]
		public MovementInformation()
		{
		}

		// Token: 0x04000A1B RID: 2587
		[Token(Token = "0x4018E98")]
		[FieldOffset(Offset = "0x10")]
		public MovementBehaviorType MovementBehaviorType;

		// Token: 0x04000A1C RID: 2588
		[Token(Token = "0x4018E99")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 MovePosition;
	}
}
