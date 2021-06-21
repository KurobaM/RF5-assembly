using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000183 RID: 387
[Token(Token = "0x200012F")]
[Serializable]
public class BulletChangeScale : BulletSubModule
{
	// Token: 0x0600080C RID: 2060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DE")]
	[Address(RVA = "0x2191890", Offset = "0x2191991", VA = "0x2191890", Slot = "7")]
	public override void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006DF")]
	[Address(RVA = "0x21919F0", Offset = "0x2191AF1", VA = "0x21919F0", Slot = "9")]
	public override void OnFixedUpdate(BulletBase bullet)
	{
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E0")]
	[Address(RVA = "0x2191B30", Offset = "0x2191C31", VA = "0x2191B30")]
	public BulletChangeScale()
	{
	}

	// Token: 0x040004AE RID: 1198
	[Token(Token = "0x4000393")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float starttime;

	// Token: 0x040004AF RID: 1199
	[Token(Token = "0x4000394")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float endtime;

	// Token: 0x040004B0 RID: 1200
	[Token(Token = "0x4000395")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public Vector3 scale;

	// Token: 0x040004B1 RID: 1201
	[Token(Token = "0x4000396")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 startScale;
}
