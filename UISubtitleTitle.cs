using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000AD6 RID: 2774
[Token(Token = "0x2000744")]
public class UISubtitleTitle : MonoBehaviour
{
	// Token: 0x06004808 RID: 18440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C50")]
	[Address(RVA = "0x21228E0", Offset = "0x21229E1", VA = "0x21228E0")]
	public void Setup(int id, float _lifeTime, UISystemTextData _textData)
	{
	}

	// Token: 0x06004809 RID: 18441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C51")]
	[Address(RVA = "0x2122970", Offset = "0x2122A71", VA = "0x2122970")]
	private void Update()
	{
	}

	// Token: 0x0600480A RID: 18442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C52")]
	[Address(RVA = "0x2122A00", Offset = "0x2122B01", VA = "0x2122A00")]
	public UISubtitleTitle()
	{
	}

	// Token: 0x0400A769 RID: 42857
	[Token(Token = "0x4007E86")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text TextObject;

	// Token: 0x0400A76A RID: 42858
	[Token(Token = "0x4007E87")]
	[FieldOffset(Offset = "0x20")]
	private UISystemTextData textData;

	// Token: 0x0400A76B RID: 42859
	[Token(Token = "0x4007E88")]
	[FieldOffset(Offset = "0x28")]
	private float nTime;

	// Token: 0x0400A76C RID: 42860
	[Token(Token = "0x4007E89")]
	[FieldOffset(Offset = "0x2C")]
	private float lifeTime;
}
