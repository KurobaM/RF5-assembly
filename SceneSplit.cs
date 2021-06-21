using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000BB1 RID: 2993
[Token(Token = "0x20007C4")]
[Serializable]
public class SceneSplit
{
	// Token: 0x06004C8F RID: 19599 RVA: 0x000185E8 File Offset: 0x000167E8
	[Token(Token = "0x6004038")]
	[Address(RVA = "0x21D4550", Offset = "0x21D4651", VA = "0x21D4550")]
	public int GetPosId()
	{
		return 0;
	}

	// Token: 0x06004C90 RID: 19600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004039")]
	[Address(RVA = "0x21D4570", Offset = "0x21D4671", VA = "0x21D4570")]
	public SceneSplit()
	{
	}

	// Token: 0x0400AE04 RID: 44548
	[Token(Token = "0x400832B")]
	[FieldOffset(Offset = "0x10")]
	public int posX;

	// Token: 0x0400AE05 RID: 44549
	[Token(Token = "0x400832C")]
	[FieldOffset(Offset = "0x14")]
	public int posY;

	// Token: 0x0400AE06 RID: 44550
	[Token(Token = "0x400832D")]
	[FieldOffset(Offset = "0x18")]
	public int posZ;

	// Token: 0x0400AE07 RID: 44551
	[Token(Token = "0x400832E")]
	[FieldOffset(Offset = "0x20")]
	public string sceneName;

	// Token: 0x0400AE08 RID: 44552
	[Token(Token = "0x400832F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject sceneGo;

	// Token: 0x0400AE09 RID: 44553
	[Token(Token = "0x4008330")]
	[FieldOffset(Offset = "0x30")]
	public bool loaded;

	// Token: 0x0400AE0A RID: 44554
	[Token(Token = "0x4008331")]
	[FieldOffset(Offset = "0x34")]
	public float posXLimitMove;

	// Token: 0x0400AE0B RID: 44555
	[Token(Token = "0x4008332")]
	[FieldOffset(Offset = "0x38")]
	public int xDeloadLimit;

	// Token: 0x0400AE0C RID: 44556
	[Token(Token = "0x4008333")]
	[FieldOffset(Offset = "0x3C")]
	public float posYLimitMove;

	// Token: 0x0400AE0D RID: 44557
	[Token(Token = "0x4008334")]
	[FieldOffset(Offset = "0x40")]
	public int yDeloadLimit;

	// Token: 0x0400AE0E RID: 44558
	[Token(Token = "0x4008335")]
	[FieldOffset(Offset = "0x44")]
	public float posZLimitMove;

	// Token: 0x0400AE0F RID: 44559
	[Token(Token = "0x4008336")]
	[FieldOffset(Offset = "0x48")]
	public int zDeloadLimit;
}
