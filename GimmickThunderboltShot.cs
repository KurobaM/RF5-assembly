using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005EF RID: 1519
[Token(Token = "0x2000445")]
public class GimmickThunderboltShot : MonoBehaviour
{
	// Token: 0x0600256B RID: 9579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F8D")]
	[Address(RVA = "0x1FEBDE0", Offset = "0x1FEBEE1", VA = "0x1FEBDE0")]
	private void Awake()
	{
	}

	// Token: 0x0600256C RID: 9580 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F8E")]
	[Address(RVA = "0x1FEBF80", Offset = "0x1FEC081", VA = "0x1FEBF80")]
	private void Update()
	{
	}

	// Token: 0x0600256D RID: 9581 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F8F")]
	[Address(RVA = "0x1FEB4F0", Offset = "0x1FEB5F1", VA = "0x1FEB4F0")]
	public void SetCollider(Vector3 center, float radius, float height)
	{
	}

	// Token: 0x0600256E RID: 9582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F90")]
	[Address(RVA = "0x1FEBFC0", Offset = "0x1FEC0C1", VA = "0x1FEBFC0")]
	private void OnStayEvent(Collider fromCollider, Collider toCollider)
	{
	}

	// Token: 0x0600256F RID: 9583 RVA: 0x0000EEF8 File Offset: 0x0000D0F8
	[Token(Token = "0x6001F91")]
	[Address(RVA = "0x1FEC480", Offset = "0x1FEC581", VA = "0x1FEC480")]
	private bool IsRubberRaincoat()
	{
		return default(bool);
	}

	// Token: 0x06002570 RID: 9584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F92")]
	[Address(RVA = "0x1FEC500", Offset = "0x1FEC601", VA = "0x1FEC500")]
	public GimmickThunderboltShot()
	{
	}

	// Token: 0x04006CBB RID: 27835
	[Token(Token = "0x40065DD")]
	[FieldOffset(Offset = "0x18")]
	public float Damage;

	// Token: 0x04006CBC RID: 27836
	[Token(Token = "0x40065DE")]
	[FieldOffset(Offset = "0x1C")]
	public float AttackKnockbackPower;

	// Token: 0x04006CBD RID: 27837
	[Token(Token = "0x40065DF")]
	[FieldOffset(Offset = "0x20")]
	private SimpleTriggerEventDispatcher SimpleTriggerEventDispatcher;

	// Token: 0x04006CBE RID: 27838
	[Token(Token = "0x40065E0")]
	[FieldOffset(Offset = "0x28")]
	private CapsuleCollider _collider;

	// Token: 0x04006CBF RID: 27839
	[Token(Token = "0x40065E1")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float IntervalCount;
}
