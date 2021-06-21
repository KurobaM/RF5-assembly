using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000194 RID: 404
[Token(Token = "0x200013F")]
[Serializable]
public class BulletSpin : BulletSubModule
{
	// Token: 0x0600084C RID: 2124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600071C")]
	[Address(RVA = "0x219A380", Offset = "0x219A481", VA = "0x219A380", Slot = "7")]
	public override void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600071D")]
	[Address(RVA = "0x219A470", Offset = "0x219A571", VA = "0x219A470", Slot = "9")]
	public override void OnFixedUpdate(BulletBase bullet)
	{
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600071E")]
	[Address(RVA = "0x219A690", Offset = "0x219A791", VA = "0x219A690")]
	public BulletSpin()
	{
	}

	// Token: 0x040004E8 RID: 1256
	[Token(Token = "0x40003CC")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public Vector3 speed;
}
