using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000196 RID: 406
[Token(Token = "0x2000141")]
[Serializable]
public class BulletSwing : BulletSubModule
{
	// Token: 0x06000856 RID: 2134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000726")]
	[Address(RVA = "0x219A700", Offset = "0x219A801", VA = "0x219A700", Slot = "7")]
	public override void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000727")]
	[Address(RVA = "0x219A870", Offset = "0x219A971", VA = "0x219A870", Slot = "9")]
	public override void OnFixedUpdate(BulletBase bullet)
	{
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000728")]
	[Address(RVA = "0x219AA50", Offset = "0x219AB51", VA = "0x219AA50")]
	public BulletSwing()
	{
	}

	// Token: 0x040004EA RID: 1258
	[Token(Token = "0x40003CE")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public Vector3 size;

	// Token: 0x040004EB RID: 1259
	[Token(Token = "0x40003CF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public Vector3 duration;
}
