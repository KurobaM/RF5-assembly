using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005E1 RID: 1505
[Token(Token = "0x200043D")]
public class GimmickMagicArrow2 : GimmickMagicArrow
{
	// Token: 0x060024FD RID: 9469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F37")]
	[Address(RVA = "0x1FE5BC0", Offset = "0x1FE5CC1", VA = "0x1FE5BC0", Slot = "6")]
	protected override void Start()
	{
	}

	// Token: 0x060024FE RID: 9470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F38")]
	[Address(RVA = "0x1FE5C30", Offset = "0x1FE5D31", VA = "0x1FE5C30", Slot = "11")]
	protected override void OnEnterEvent(Collider fromCollider, Collider toCollider)
	{
	}

	// Token: 0x060024FF RID: 9471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F39")]
	[Address(RVA = "0x1FE5C40", Offset = "0x1FE5D41", VA = "0x1FE5C40", Slot = "12")]
	protected override void OnStayEvent(Collider fromCollider, Collider toCollider)
	{
	}

	// Token: 0x06002500 RID: 9472 RVA: 0x0000EDA8 File Offset: 0x0000CFA8
	[Token(Token = "0x6001F3A")]
	[Address(RVA = "0x1FE5FB0", Offset = "0x1FE60B1", VA = "0x1FE5FB0")]
	private bool IsWithinRangeAngle(Vector3 i_forwardDir, Vector3 i_toTargetDir, float i_cosTheta)
	{
		return default(bool);
	}

	// Token: 0x06002501 RID: 9473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F3B")]
	[Address(RVA = "0x1FE60E0", Offset = "0x1FE61E1", VA = "0x1FE60E0")]
	public GimmickMagicArrow2()
	{
	}

	// Token: 0x04006C5B RID: 27739
	[Token(Token = "0x4006595")]
	private const float RUN_THRESHOLD = 0.5f;

	// Token: 0x04006C5C RID: 27740
	[Token(Token = "0x4006596")]
	public const float STOP_THRESHOLD = 0.1f;

	// Token: 0x04006C5D RID: 27741
	[Token(Token = "0x4006597")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x1674D0", Offset = "0x1675D1")]
	private float SearchAngle;

	// Token: 0x04006C5E RID: 27742
	[Token(Token = "0x4006598")]
	[FieldOffset(Offset = "0x70")]
	private SphereCollider sphere;
}
