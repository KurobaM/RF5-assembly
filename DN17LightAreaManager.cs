using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005BF RID: 1471
[Token(Token = "0x2000421")]
public class DN17LightAreaManager : MonoBehaviour
{
	// Token: 0x06002416 RID: 9238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E5C")]
	[Address(RVA = "0x1D9F280", Offset = "0x1D9F381", VA = "0x1D9F280")]
	private void Start()
	{
	}

	// Token: 0x06002417 RID: 9239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E5D")]
	[Address(RVA = "0x1D9F210", Offset = "0x1D9F311", VA = "0x1D9F210")]
	public void SetLightColor(Color color)
	{
	}

	// Token: 0x06002418 RID: 9240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E5E")]
	[Address(RVA = "0x1D9F1D0", Offset = "0x1D9F2D1", VA = "0x1D9F1D0")]
	public void SetPlayer(GameObject gameObject)
	{
	}

	// Token: 0x06002419 RID: 9241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E5F")]
	[Address(RVA = "0x1D9F370", Offset = "0x1D9F471", VA = "0x1D9F370")]
	public DN17LightAreaManager()
	{
	}

	// Token: 0x04006B7E RID: 27518
	[Token(Token = "0x40064D5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private DN17LightArea[] LightAreas;

	// Token: 0x04006B7F RID: 27519
	[Token(Token = "0x40064D6")]
	private const float duration = 1.5f;

	// Token: 0x04006B80 RID: 27520
	[Token(Token = "0x40064D7")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private DN17Light Light;
}
