using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A2B RID: 2603
[Token(Token = "0x20006D5")]
public class UILoveEventTextSet : MonoBehaviour
{
	// Token: 0x06004421 RID: 17441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600390A")]
	[Address(RVA = "0x201FF60", Offset = "0x2020061", VA = "0x201FF60")]
	public void SetText()
	{
	}

	// Token: 0x06004422 RID: 17442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600390B")]
	[Address(RVA = "0x2020160", Offset = "0x2020261", VA = "0x2020160")]
	public UILoveEventTextSet()
	{
	}

	// Token: 0x0400A30E RID: 41742
	[Token(Token = "0x4007B41")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text Topic;

	// Token: 0x0400A30F RID: 41743
	[Token(Token = "0x4007B42")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text Detail;

	// Token: 0x0400A310 RID: 41744
	[Token(Token = "0x4007B43")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image CharaImage;

	// Token: 0x0400A311 RID: 41745
	[Token(Token = "0x4007B44")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Sprite[] CharaSprites;

	// Token: 0x0400A312 RID: 41746
	[Token(Token = "0x4007B45")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UISubEventTextSet SubEventBlock;
}
