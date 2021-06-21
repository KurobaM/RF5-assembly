using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005CF RID: 1487
[Token(Token = "0x200042F")]
public class GimmickBreakeMoveCloudConditions : CharacterBase
{
	// Token: 0x0600247C RID: 9340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EC2")]
	[Address(RVA = "0x1FA90C0", Offset = "0x1FA91C1", VA = "0x1FA90C0")]
	private void OnTriggerStay(Collider other)
	{
	}

	// Token: 0x0600247D RID: 9341 RVA: 0x0000EC10 File Offset: 0x0000CE10
	[Token(Token = "0x6001EC3")]
	[Address(RVA = "0x1FA9310", Offset = "0x1FA9411", VA = "0x1FA9310", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult totalDamage)
	{
		return default(bool);
	}

	// Token: 0x0600247E RID: 9342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EC4")]
	[Address(RVA = "0x1FA9510", Offset = "0x1FA9611", VA = "0x1FA9510")]
	public GimmickBreakeMoveCloudConditions()
	{
	}

	// Token: 0x04006BE6 RID: 27622
	[Token(Token = "0x4006536")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	public AttackType attackType;

	// Token: 0x04006BE7 RID: 27623
	[Token(Token = "0x4006537")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	public AttackAttribute[] attackAttribute;

	// Token: 0x04006BE8 RID: 27624
	[Token(Token = "0x4006538")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public int Hp;

	// Token: 0x04006BE9 RID: 27625
	[Token(Token = "0x4006539")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x167080", Offset = "0x167181")]
	private float PushPercent;
}
