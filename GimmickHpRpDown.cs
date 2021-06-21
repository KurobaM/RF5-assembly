using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005DB RID: 1499
[Token(Token = "0x2000439")]
public class GimmickHpRpDown : GimmickBase
{
	// Token: 0x060024E2 RID: 9442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F1C")]
	[Address(RVA = "0x1FE4210", Offset = "0x1FE4311", VA = "0x1FE4210", Slot = "6")]
	protected override void Start()
	{
	}

	// Token: 0x060024E3 RID: 9443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F1D")]
	[Address(RVA = "0x1FE43B0", Offset = "0x1FE44B1", VA = "0x1FE43B0")]
	private void Update()
	{
	}

	// Token: 0x060024E4 RID: 9444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F1E")]
	[Address(RVA = "0x1FE4490", Offset = "0x1FE4591", VA = "0x1FE4490")]
	private void DamageHp()
	{
	}

	// Token: 0x060024E5 RID: 9445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F1F")]
	[Address(RVA = "0x1FE4680", Offset = "0x1FE4781", VA = "0x1FE4680")]
	private void DamageRp()
	{
	}

	// Token: 0x060024E6 RID: 9446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F20")]
	[Address(RVA = "0x1FE4810", Offset = "0x1FE4911", VA = "0x1FE4810")]
	private void OnStayEvent(Collider fromCollider, Collider toCollider)
	{
	}

	// Token: 0x060024E7 RID: 9447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F21")]
	[Address(RVA = "0x1FE4920", Offset = "0x1FE4A21", VA = "0x1FE4920")]
	private void OnExitEvent(Collider fromCollider, Collider toCollider)
	{
	}

	// Token: 0x060024E8 RID: 9448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F22")]
	[Address(RVA = "0x1FE4A30", Offset = "0x1FE4B31", VA = "0x1FE4A30")]
	protected void OnChangeSwitchState(bool newState, bool immediate)
	{
	}

	// Token: 0x060024E9 RID: 9449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F23")]
	[Address(RVA = "0x1FE4A40", Offset = "0x1FE4B41", VA = "0x1FE4A40")]
	public GimmickHpRpDown()
	{
	}

	// Token: 0x04006C36 RID: 27702
	[Token(Token = "0x4006579")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GimmickHpRpDown.DamageType damageType;

	// Token: 0x04006C37 RID: 27703
	[Token(Token = "0x400657A")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float Interval;

	// Token: 0x04006C38 RID: 27704
	[Token(Token = "0x400657B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x1673E0", Offset = "0x1674E1")]
	private float DamagePercent;

	// Token: 0x04006C39 RID: 27705
	[Token(Token = "0x400657C")]
	[FieldOffset(Offset = "0x30")]
	protected SimpleTriggerEventDispatcher SimpleTriggerEventDispatcher;

	// Token: 0x04006C3A RID: 27706
	[Token(Token = "0x400657D")]
	[FieldOffset(Offset = "0x38")]
	protected bool stayRoom;

	// Token: 0x04006C3B RID: 27707
	[Token(Token = "0x400657E")]
	[FieldOffset(Offset = "0x3C")]
	private float CurrentTime;

	// Token: 0x020005DC RID: 1500
	[Token(Token = "0x200112B")]
	public enum DamageType
	{
		// Token: 0x04006C3D RID: 27709
		[Token(Token = "0x4019331")]
		HP_DOWN,
		// Token: 0x04006C3E RID: 27710
		[Token(Token = "0x4019332")]
		RP_DOWN
	}
}
