using System;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A3 RID: 419
[Token(Token = "0x2000149")]
public class FarmEventCamera : LandscapeVcam
{
	// Token: 0x060008B4 RID: 2228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600077A")]
	[Address(RVA = "0x21A8020", Offset = "0x21A8121", VA = "0x21A8020")]
	private void Start()
	{
	}

	// Token: 0x060008B5 RID: 2229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600077B")]
	[Address(RVA = "0x21A80D0", Offset = "0x21A81D1", VA = "0x21A80D0")]
	public void Enable()
	{
	}

	// Token: 0x060008B6 RID: 2230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600077C")]
	[Address(RVA = "0x21A8150", Offset = "0x21A8251", VA = "0x21A8150")]
	public new void Disable()
	{
	}

	// Token: 0x060008B7 RID: 2231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600077D")]
	[Address(RVA = "0x21A81E0", Offset = "0x21A82E1", VA = "0x21A81E0")]
	public void ChangeSubCamera()
	{
	}

	// Token: 0x060008B8 RID: 2232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600077E")]
	[Address(RVA = "0x21A8230", Offset = "0x21A8331", VA = "0x21A8230")]
	public FarmEventCamera()
	{
	}

	// Token: 0x0400051E RID: 1310
	[Token(Token = "0x40003EC")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CinemachineVirtualCameraBase subCinemachineVirtualCameraBase;
}
