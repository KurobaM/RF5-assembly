using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A90 RID: 2704
[Token(Token = "0x2000714")]
public class UIGetBatchSetImage : MonoBehaviour
{
	// Token: 0x0600465F RID: 18015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AE3")]
	[Address(RVA = "0x2010F50", Offset = "0x2011051", VA = "0x2010F50")]
	private void Start()
	{
	}

	// Token: 0x06004660 RID: 18016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AE4")]
	[Address(RVA = "0x2011000", Offset = "0x2011101", VA = "0x2011000")]
	public UIGetBatchSetImage()
	{
	}

	// Token: 0x0400A56A RID: 42346
	[Token(Token = "0x4007CF1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image BatchImage;

	// Token: 0x0400A56B RID: 42347
	[Token(Token = "0x4007CF2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Sprite[] BatchSprite;
}
