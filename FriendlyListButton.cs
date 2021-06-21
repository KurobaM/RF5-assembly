using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A0D RID: 2573
[Token(Token = "0x20006BF")]
public class FriendlyListButton : UIButtonLinkerInScrollBox
{
	// Token: 0x0600436B RID: 17259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600386A")]
	[Address(RVA = "0x23D07F0", Offset = "0x23D08F1", VA = "0x23D07F0", Slot = "16")]
	public override void Init()
	{
	}

	// Token: 0x0600436C RID: 17260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600386B")]
	[Address(RVA = "0x23D0800", Offset = "0x23D0901", VA = "0x23D0800")]
	public void Setup(ActorID actor_id)
	{
	}

	// Token: 0x0600436D RID: 17261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600386C")]
	[Address(RVA = "0x23D0B20", Offset = "0x23D0C21", VA = "0x23D0B20")]
	public void Setup(FriendMonsterStatusData data)
	{
	}

	// Token: 0x0600436E RID: 17262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600386D")]
	[Address(RVA = "0x23D0CD0", Offset = "0x23D0DD1", VA = "0x23D0CD0")]
	private void SetOnOff(bool val)
	{
	}

	// Token: 0x0600436F RID: 17263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600386E")]
	[Address(RVA = "0x23D0D20", Offset = "0x23D0E21", VA = "0x23D0D20", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x06004370 RID: 17264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600386F")]
	[Address(RVA = "0x23D0D70", Offset = "0x23D0E71", VA = "0x23D0D70", Slot = "11")]
	public override void EndFocus()
	{
	}

	// Token: 0x06004371 RID: 17265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003870")]
	[Address(RVA = "0x23D0DC0", Offset = "0x23D0EC1", VA = "0x23D0DC0")]
	public FriendlyListButton()
	{
	}

	// Token: 0x0400A246 RID: 41542
	[Token(Token = "0x4007A9D")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Text NameText;

	// Token: 0x0400A247 RID: 41543
	[Token(Token = "0x4007A9E")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Image LoveIcon;

	// Token: 0x0400A248 RID: 41544
	[Token(Token = "0x4007A9F")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Sprite LoverIconSprite;

	// Token: 0x0400A249 RID: 41545
	[Token(Token = "0x4007AA0")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Sprite FriendIconSprite;

	// Token: 0x0400A24A RID: 41546
	[Token(Token = "0x4007AA1")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Text LoveNumText;

	// Token: 0x0400A24B RID: 41547
	[Token(Token = "0x4007AA2")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Text LoveNumPercentText;

	// Token: 0x0400A24C RID: 41548
	[Token(Token = "0x4007AA3")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Image LoveGauge;

	// Token: 0x0400A24D RID: 41549
	[Token(Token = "0x4007AA4")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Image OnImage;

	// Token: 0x0400A24E RID: 41550
	[Token(Token = "0x4007AA5")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private Image OffImage;

	// Token: 0x0400A24F RID: 41551
	[Token(Token = "0x4007AA6")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private Sprite RingSprite;

	// Token: 0x0400A250 RID: 41552
	[Token(Token = "0x4007AA7")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private UIFaceIconLoader UIFaceIconLoader;
}
