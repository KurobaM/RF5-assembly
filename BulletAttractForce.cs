using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000181 RID: 385
[Token(Token = "0x200012D")]
[Serializable]
public class BulletAttractForce : BulletSubModule
{
	// Token: 0x06000805 RID: 2053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D7")]
	[Address(RVA = "0x218DDE0", Offset = "0x218DEE1", VA = "0x218DDE0", Slot = "7")]
	public override void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D8")]
	[Address(RVA = "0x218DF20", Offset = "0x218E021", VA = "0x218DF20", Slot = "9")]
	public override void OnFixedUpdate(BulletBase bullet)
	{
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D9")]
	[Address(RVA = "0x218E350", Offset = "0x218E451", VA = "0x218E350")]
	private void AddForce(BulletBase bullet, Character chara)
	{
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DA")]
	[Address(RVA = "0x218E490", Offset = "0x218E591", VA = "0x218E490")]
	public BulletAttractForce()
	{
	}

	// Token: 0x040004A9 RID: 1193
	[Token(Token = "0x400038E")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float radius;

	// Token: 0x040004AA RID: 1194
	[Token(Token = "0x400038F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float power;

	// Token: 0x040004AB RID: 1195
	[Token(Token = "0x4000390")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public TargetAlliance alliance;
}
