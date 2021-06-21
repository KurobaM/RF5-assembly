using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000182 RID: 386
[Token(Token = "0x200012E")]
[Serializable]
public class BulletChangeAcceleration : BulletSubModule
{
	// Token: 0x06000809 RID: 2057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DB")]
	[Address(RVA = "0x2191770", Offset = "0x2191871", VA = "0x2191770", Slot = "7")]
	public override void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DC")]
	[Address(RVA = "0x2191840", Offset = "0x2191941", VA = "0x2191840", Slot = "9")]
	public override void OnFixedUpdate(BulletBase bullet)
	{
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DD")]
	[Address(RVA = "0x2191880", Offset = "0x2191981", VA = "0x2191880")]
	public BulletChangeAcceleration()
	{
	}

	// Token: 0x040004AC RID: 1196
	[Token(Token = "0x4000391")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float startTime;

	// Token: 0x040004AD RID: 1197
	[Token(Token = "0x4000392")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float acceleration;
}
