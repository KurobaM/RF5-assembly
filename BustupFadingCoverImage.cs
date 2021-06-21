using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200092A RID: 2346
[Token(Token = "0x2000622")]
public class BustupFadingCoverImage : MonoBehaviour
{
	// Token: 0x06003D59 RID: 15705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600338D")]
	[Address(RVA = "0x219B030", Offset = "0x219B131", VA = "0x219B030")]
	private void Start()
	{
	}

	// Token: 0x06003D5A RID: 15706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600338E")]
	[Address(RVA = "0x219B090", Offset = "0x219B191", VA = "0x219B090")]
	private void LateUpdate()
	{
	}

	// Token: 0x06003D5B RID: 15707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600338F")]
	[Address(RVA = "0x219B1F0", Offset = "0x219B2F1", VA = "0x219B1F0")]
	public BustupFadingCoverImage()
	{
	}

	// Token: 0x04007FB2 RID: 32690
	[Token(Token = "0x4007328")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image FadeImage;

	// Token: 0x04007FB3 RID: 32691
	[Token(Token = "0x4007329")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image BaseAnimationImage;

	// Token: 0x04007FB4 RID: 32692
	[Token(Token = "0x400732A")]
	[FieldOffset(Offset = "0x28")]
	private Image myImage;
}
