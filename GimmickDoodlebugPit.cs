using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005D7 RID: 1495
[Token(Token = "0x2000435")]
public class GimmickDoodlebugPit : GimmickBase
{
	// Token: 0x060024BC RID: 9404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EF6")]
	[Address(RVA = "0x1FE17D0", Offset = "0x1FE18D1", VA = "0x1FE17D0", Slot = "7")]
	public override void SetGimmickState(bool newState)
	{
	}

	// Token: 0x060024BD RID: 9405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EF7")]
	[Address(RVA = "0x1FE17E0", Offset = "0x1FE18E1", VA = "0x1FE17E0")]
	private void Awake()
	{
	}

	// Token: 0x060024BE RID: 9406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EF8")]
	[Address(RVA = "0x1FE1840", Offset = "0x1FE1941", VA = "0x1FE1840")]
	private void Update()
	{
	}

	// Token: 0x060024BF RID: 9407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EF9")]
	[Address(RVA = "0x1FE1850", Offset = "0x1FE1951", VA = "0x1FE1850")]
	private void UpdateSuction()
	{
	}

	// Token: 0x060024C0 RID: 9408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EFA")]
	[Address(RVA = "0x1FE1AC0", Offset = "0x1FE1BC1", VA = "0x1FE1AC0")]
	private void OnTriggerStay(Collider other)
	{
	}

	// Token: 0x060024C1 RID: 9409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EFB")]
	[Address(RVA = "0x1FE1B50", Offset = "0x1FE1C51", VA = "0x1FE1B50")]
	public GimmickDoodlebugPit()
	{
	}

	// Token: 0x04006C15 RID: 27669
	[Token(Token = "0x4006558")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float SuctionPower;

	// Token: 0x04006C16 RID: 27670
	[Token(Token = "0x4006559")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float LerpMin;

	// Token: 0x04006C17 RID: 27671
	[Token(Token = "0x400655A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float LerpMax;

	// Token: 0x04006C18 RID: 27672
	[Token(Token = "0x400655B")]
	[FieldOffset(Offset = "0x30")]
	private SphereCollider AreaCollider;
}
