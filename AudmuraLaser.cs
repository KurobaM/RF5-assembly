using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006BE RID: 1726
[Token(Token = "0x20004D1")]
public class AudmuraLaser : MonoBehaviour
{
	// Token: 0x06002A2F RID: 10799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600238A")]
	[Address(RVA = "0x228F330", Offset = "0x228F431", VA = "0x228F330")]
	public void Setup(Action<AudmuraCrystal, Vector3> hitCrystal)
	{
	}

	// Token: 0x06002A30 RID: 10800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600238B")]
	[Address(RVA = "0x228F340", Offset = "0x228F441", VA = "0x228F340")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06002A31 RID: 10801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600238C")]
	[Address(RVA = "0x228F490", Offset = "0x228F591", VA = "0x228F490")]
	public AudmuraLaser()
	{
	}

	// Token: 0x04007217 RID: 29207
	[Token(Token = "0x40069D6")]
	[FieldOffset(Offset = "0x18")]
	private bool IsHit;

	// Token: 0x04007218 RID: 29208
	[Token(Token = "0x40069D7")]
	[FieldOffset(Offset = "0x20")]
	private Action<AudmuraCrystal, Vector3> HitCrystalAction;
}
