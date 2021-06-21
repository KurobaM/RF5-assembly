using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009E9 RID: 2537
[Token(Token = "0x20006A5")]
public class BuildIconControl : MonoBehaviour
{
	// Token: 0x0600427F RID: 17023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600379A")]
	[Address(RVA = "0x218BC00", Offset = "0x218BD01", VA = "0x218BC00")]
	public void onIcon(bool flg)
	{
	}

	// Token: 0x06004280 RID: 17024 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600379B")]
	[Address(RVA = "0x218BC40", Offset = "0x218BD41", VA = "0x218BC40")]
	public void onFukidasi(int no, bool flg, int num)
	{
	}

	// Token: 0x06004281 RID: 17025 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600379C")]
	[Address(RVA = "0x218BD30", Offset = "0x218BE31", VA = "0x218BD30")]
	public void setOffIconImage(Sprite spr)
	{
	}

	// Token: 0x06004282 RID: 17026 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600379D")]
	[Address(RVA = "0x218BD80", Offset = "0x218BE81", VA = "0x218BD80")]
	public void setOnIconImage(Sprite spr)
	{
	}

	// Token: 0x06004283 RID: 17027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600379E")]
	[Address(RVA = "0x218BDD0", Offset = "0x218BED1", VA = "0x218BDD0")]
	public BuildIconControl()
	{
	}

	// Token: 0x0400A11D RID: 41245
	[Token(Token = "0x4007997")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image iconOff;

	// Token: 0x0400A11E RID: 41246
	[Token(Token = "0x4007998")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image iconOn;

	// Token: 0x0400A11F RID: 41247
	[Token(Token = "0x4007999")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image iconFukidasi;

	// Token: 0x0400A120 RID: 41248
	[Token(Token = "0x400799A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform rectFukidasi;

	// Token: 0x0400A121 RID: 41249
	[Token(Token = "0x400799B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text textFukidasi;

	// Token: 0x0400A122 RID: 41250
	[Token(Token = "0x400799C")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Vector2[] FukidasiPos;
}
