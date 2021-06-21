using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005A1 RID: 1441
[Token(Token = "0x2000403")]
[Serializable]
public class TeleportPortalData
{
	// Token: 0x06002373 RID: 9075 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DB9")]
	[Address(RVA = "0x1F6A5E0", Offset = "0x1F6A6E1", VA = "0x1F6A5E0")]
	public TeleportPortalData()
	{
	}

	// Token: 0x04006B26 RID: 27430
	[Token(Token = "0x400647D")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 position;

	// Token: 0x04006B27 RID: 27431
	[Token(Token = "0x400647E")]
	[FieldOffset(Offset = "0x1C")]
	public float rotationY;

	// Token: 0x04006B28 RID: 27432
	[Token(Token = "0x400647F")]
	[FieldOffset(Offset = "0x20")]
	public float cameraRotationY;
}
