using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F1 RID: 497
[Token(Token = "0x200018F")]
public class BitBody : CharacterBase
{
	// Token: 0x170001D7 RID: 471
	// (get) Token: 0x06000A32 RID: 2610 RVA: 0x000051F0 File Offset: 0x000033F0
	[Token(Token = "0x170001BA")]
	public override Alliance Alliance
	{
		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x2454350", Offset = "0x2454451", VA = "0x2454350", Slot = "8")]
		get
		{
			return Alliance.None;
		}
	}

	// Token: 0x06000A33 RID: 2611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E4")]
	[Address(RVA = "0x2454460", Offset = "0x2454561", VA = "0x2454460")]
	public void Setup(BitBase bitBase)
	{
	}

	// Token: 0x06000A34 RID: 2612 RVA: 0x00005208 File Offset: 0x00003408
	[Token(Token = "0x60008E5")]
	[Address(RVA = "0x2454470", Offset = "0x2454571", VA = "0x2454470", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x06000A35 RID: 2613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E6")]
	[Address(RVA = "0x2454540", Offset = "0x2454641", VA = "0x2454540")]
	public BitBody()
	{
	}

	// Token: 0x0400066E RID: 1646
	[Token(Token = "0x4000517")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private BitBase m_bitBase;
}
