using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000193 RID: 403
[Token(Token = "0x200013E")]
[Serializable]
public class BulletSearchSphere : BulletSubModule
{
	// Token: 0x06000849 RID: 2121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000719")]
	[Address(RVA = "0x2199F20", Offset = "0x219A021", VA = "0x2199F20", Slot = "7")]
	public override void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x0600084A RID: 2122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600071A")]
	[Address(RVA = "0x219A010", Offset = "0x219A111", VA = "0x219A010", Slot = "9")]
	public override void OnFixedUpdate(BulletBase bullet)
	{
	}

	// Token: 0x0600084B RID: 2123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600071B")]
	[Address(RVA = "0x219A350", Offset = "0x219A451", VA = "0x219A350")]
	public BulletSearchSphere()
	{
	}

	// Token: 0x040004E4 RID: 1252
	[Token(Token = "0x40003C8")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float radius;

	// Token: 0x040004E5 RID: 1253
	[Token(Token = "0x40003C9")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public TargetAlliance alliance;

	// Token: 0x040004E6 RID: 1254
	[Token(Token = "0x40003CA")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public float interval;

	// Token: 0x040004E7 RID: 1255
	[Token(Token = "0x40003CB")]
	[FieldOffset(Offset = "0x28")]
	private int m_count;
}
