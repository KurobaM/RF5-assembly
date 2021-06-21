using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000189 RID: 393
[Token(Token = "0x2000134")]
[Serializable]
public class BulletGroundEffect : BulletSubModule
{
	// Token: 0x06000820 RID: 2080 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F0")]
	[Address(RVA = "0x2194CE0", Offset = "0x2194DE1", VA = "0x2194CE0", Slot = "7")]
	public override void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x06000821 RID: 2081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F1")]
	[Address(RVA = "0x2194D60", Offset = "0x2194E61", VA = "0x2194D60", Slot = "9")]
	public override void OnFixedUpdate(BulletBase bullet)
	{
	}

	// Token: 0x06000822 RID: 2082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F2")]
	[Address(RVA = "0x2194FF0", Offset = "0x21950F1", VA = "0x2194FF0")]
	public BulletGroundEffect()
	{
	}

	// Token: 0x040004C0 RID: 1216
	[Token(Token = "0x40003A4")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float height;

	// Token: 0x040004C1 RID: 1217
	[Token(Token = "0x40003A5")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private EffectID effectID;

	// Token: 0x040004C2 RID: 1218
	[Token(Token = "0x40003A6")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float interval;

	// Token: 0x040004C3 RID: 1219
	[Token(Token = "0x40003A7")]
	[FieldOffset(Offset = "0x28")]
	private float m_currentElapsed;
}
