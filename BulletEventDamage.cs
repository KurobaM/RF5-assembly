using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200017B RID: 379
[Token(Token = "0x2000129")]
public class BulletEventDamage : MonoBehaviour
{
	// Token: 0x060007EF RID: 2031 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C6")]
	[Address(RVA = "0x21940F0", Offset = "0x21941F1", VA = "0x21940F0")]
	public void OnHit(Collider collider, Vector3 point)
	{
	}

	// Token: 0x060007F0 RID: 2032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C7")]
	[Address(RVA = "0x2194380", Offset = "0x2194481", VA = "0x2194380")]
	public BulletEventDamage()
	{
	}

	// Token: 0x04000499 RID: 1177
	[Token(Token = "0x400037F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public DamageInfo damageInfo;
}
