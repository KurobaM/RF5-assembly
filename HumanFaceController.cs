using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200023A RID: 570
[Token(Token = "0x20001CA")]
public class HumanFaceController : CharaFaceController
{
	// Token: 0x06000D8C RID: 3468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2B")]
	[Address(RVA = "0x20A4A20", Offset = "0x20A4B21", VA = "0x20A4A20", Slot = "4")]
	public override void SetFaceType(FaceType requestFaceType)
	{
	}

	// Token: 0x06000D8D RID: 3469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2C")]
	[Address(RVA = "0x20A4B60", Offset = "0x20A4C61", VA = "0x20A4B60", Slot = "6")]
	public override void ApplyFaceType(FaceType faceType)
	{
	}

	// Token: 0x06000D8E RID: 3470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2D")]
	[Address(RVA = "0x20A4CC0", Offset = "0x20A4DC1", VA = "0x20A4CC0")]
	public HumanFaceController()
	{
	}

	// Token: 0x040007D0 RID: 2000
	[Token(Token = "0x4000659")]
	[FieldOffset(Offset = "0x0")]
	private static string FaceLayer;

	// Token: 0x040007D1 RID: 2001
	[Token(Token = "0x400065A")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<FaceType, string> FaceNames;
}
