using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200011F RID: 287
[Token(Token = "0x20000E3")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x144E40", Offset = "0x144F41")]
public class MoveAttackRange : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x0600061E RID: 1566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053A")]
	[Address(RVA = "0x1E0F770", Offset = "0x1E0F871", VA = "0x1E0F770", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x0600061F RID: 1567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053B")]
	[Address(RVA = "0x1E0F840", Offset = "0x1E0F941", VA = "0x1E0F840", Slot = "5")]
	public override void OnStart()
	{
	}

	// Token: 0x06000620 RID: 1568 RVA: 0x00004380 File Offset: 0x00002580
	[Token(Token = "0x600053C")]
	[Address(RVA = "0x1E0F8E0", Offset = "0x1E0F9E1", VA = "0x1E0F8E0", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000621 RID: 1569 RVA: 0x00004398 File Offset: 0x00002598
	[Token(Token = "0x600053D")]
	[Address(RVA = "0x1E0FCC0", Offset = "0x1E0FDC1", VA = "0x1E0FCC0")]
	private bool IsHitTargetSphereCast()
	{
		return default(bool);
	}

	// Token: 0x06000622 RID: 1570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053E")]
	[Address(RVA = "0x1E10050", Offset = "0x1E10151", VA = "0x1E10050", Slot = "17")]
	public override void OnDrawGizmos()
	{
	}

	// Token: 0x06000623 RID: 1571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053F")]
	[Address(RVA = "0x1E10060", Offset = "0x1E10161", VA = "0x1E10060")]
	public MoveAttackRange()
	{
	}

	// Token: 0x0400035A RID: 858
	[Token(Token = "0x40002A3")]
	[FieldOffset(Offset = "0x50")]
	public SharedGameObject Target;

	// Token: 0x0400035B RID: 859
	[Token(Token = "0x40002A4")]
	[FieldOffset(Offset = "0x58")]
	public SharedFloat MinAttackRange;

	// Token: 0x0400035C RID: 860
	[Token(Token = "0x40002A5")]
	[FieldOffset(Offset = "0x60")]
	public SharedFloat MaxAttackRange;

	// Token: 0x0400035D RID: 861
	[Token(Token = "0x40002A6")]
	[FieldOffset(Offset = "0x68")]
	public SharedFloat SphereCastHeight;

	// Token: 0x0400035E RID: 862
	[Token(Token = "0x40002A7")]
	[FieldOffset(Offset = "0x70")]
	public SharedFloat SphereCastInterval;

	// Token: 0x0400035F RID: 863
	[Token(Token = "0x40002A8")]
	[FieldOffset(Offset = "0x78")]
	public SharedBool OnlyUseMaxRange;

	// Token: 0x04000360 RID: 864
	[Token(Token = "0x40002A9")]
	[FieldOffset(Offset = "0x80")]
	public SharedMovementBehaviorType ReturnReadyToAttackBehaviorType;

	// Token: 0x04000361 RID: 865
	[Token(Token = "0x40002AA")]
	[FieldOffset(Offset = "0x88")]
	public SharedFloat ReturnMoveSpeedScale;

	// Token: 0x04000362 RID: 866
	[Token(Token = "0x40002AB")]
	[FieldOffset(Offset = "0x90")]
	public SharedFloat ReturnLeaveRange;

	// Token: 0x04000363 RID: 867
	[Token(Token = "0x40002AC")]
	[FieldOffset(Offset = "0x98")]
	public SharedFloat ReturnCloseRange;

	// Token: 0x04000364 RID: 868
	[Token(Token = "0x40002AD")]
	[FieldOffset(Offset = "0xA0")]
	private AIInput AIInput;

	// Token: 0x04000365 RID: 869
	[Token(Token = "0x40002AE")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string OnlyUseMaxRangeKryName;

	// Token: 0x04000366 RID: 870
	[Token(Token = "0x40002AF")]
	[FieldOffset(Offset = "0xA8")]
	private float SphereCastTimer;

	// Token: 0x04000367 RID: 871
	[Token(Token = "0x40002B0")]
	[FieldOffset(Offset = "0xAC")]
	private float SphereCastRadius;

	// Token: 0x04000368 RID: 872
	[Token(Token = "0x40002B1")]
	[FieldOffset(Offset = "0xB0")]
	private float SphereCastMaxDistance;

	// Token: 0x04000369 RID: 873
	[Token(Token = "0x40002B2")]
	[FieldOffset(Offset = "0xB8")]
	private RaycastHit[] SphereCastHit;
}
