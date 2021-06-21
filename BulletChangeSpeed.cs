using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000184 RID: 388
[Token(Token = "0x2000130")]
[Serializable]
public class BulletChangeSpeed : BulletSubModule
{
	// Token: 0x0600080F RID: 2063 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E1")]
	[Address(RVA = "0x2191BD0", Offset = "0x2191CD1", VA = "0x2191BD0", Slot = "7")]
	public override void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x06000810 RID: 2064 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E2")]
	[Address(RVA = "0x2191CA0", Offset = "0x2191DA1", VA = "0x2191CA0", Slot = "9")]
	public override void OnFixedUpdate(BulletBase bullet)
	{
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E3")]
	[Address(RVA = "0x2191E60", Offset = "0x2191F61", VA = "0x2191E60")]
	public BulletChangeSpeed()
	{
	}

	// Token: 0x040004B2 RID: 1202
	[Token(Token = "0x4000397")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float startTime;

	// Token: 0x040004B3 RID: 1203
	[Token(Token = "0x4000398")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float speed;
}
