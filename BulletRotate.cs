using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000191 RID: 401
[Token(Token = "0x200013C")]
public class BulletRotate : BulletSubModule
{
	// Token: 0x06000841 RID: 2113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000711")]
	[Address(RVA = "0x2199740", Offset = "0x2199841", VA = "0x2199740", Slot = "7")]
	public override void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x06000842 RID: 2114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000712")]
	[Address(RVA = "0x2199880", Offset = "0x2199981", VA = "0x2199880", Slot = "9")]
	public override void OnFixedUpdate(BulletBase bullet)
	{
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000713")]
	[Address(RVA = "0x2199C00", Offset = "0x2199D01", VA = "0x2199C00")]
	public BulletRotate()
	{
	}

	// Token: 0x040004DE RID: 1246
	[Token(Token = "0x40003C2")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float starttime;

	// Token: 0x040004DF RID: 1247
	[Token(Token = "0x40003C3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float endtime;

	// Token: 0x040004E0 RID: 1248
	[Token(Token = "0x40003C4")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public Vector3 rotate;

	// Token: 0x040004E1 RID: 1249
	[Token(Token = "0x40003C5")]
	[FieldOffset(Offset = "0x30")]
	private Quaternion startRotate;
}
