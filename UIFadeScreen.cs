using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000932 RID: 2354
[Token(Token = "0x2000627")]
public class UIFadeScreen : MonoBehaviour
{
	// Token: 0x06003E58 RID: 15960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033CC")]
	[Address(RVA = "0x2010B20", Offset = "0x2010C21", VA = "0x2010B20")]
	public void ScreenFade(float fadeTime, Color fadeColor, int fadeStat, Action<bool> _endCallback)
	{
	}

	// Token: 0x06003E59 RID: 15961 RVA: 0x00015510 File Offset: 0x00013710
	[Token(Token = "0x60033CD")]
	[Address(RVA = "0x2010D10", Offset = "0x2010E11", VA = "0x2010D10")]
	public bool IsToBlack()
	{
		return default(bool);
	}

	// Token: 0x06003E5A RID: 15962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033CE")]
	[Address(RVA = "0x2010D70", Offset = "0x2010E71", VA = "0x2010D70")]
	private void Awake()
	{
	}

	// Token: 0x06003E5B RID: 15963 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033CF")]
	[Address(RVA = "0x2010DE0", Offset = "0x2010EE1", VA = "0x2010DE0")]
	private void Update()
	{
	}

	// Token: 0x06003E5C RID: 15964 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033D0")]
	[Address(RVA = "0x2010F40", Offset = "0x2011041", VA = "0x2010F40")]
	public UIFadeScreen()
	{
	}

	// Token: 0x04008009 RID: 32777
	[Token(Token = "0x400735F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image BlackOutPanel;

	// Token: 0x0400800A RID: 32778
	[Token(Token = "0x4007360")]
	[FieldOffset(Offset = "0x20")]
	private Color PanelColor;

	// Token: 0x0400800B RID: 32779
	[Token(Token = "0x4007361")]
	[FieldOffset(Offset = "0x30")]
	private Color StartFadeColor;

	// Token: 0x0400800C RID: 32780
	[Token(Token = "0x4007362")]
	[FieldOffset(Offset = "0x40")]
	private Color TargetColor;

	// Token: 0x0400800D RID: 32781
	[Token(Token = "0x4007363")]
	[FieldOffset(Offset = "0x50")]
	private float FadeTime;

	// Token: 0x0400800E RID: 32782
	[Token(Token = "0x4007364")]
	[FieldOffset(Offset = "0x54")]
	private float nowFadeTime;

	// Token: 0x0400800F RID: 32783
	[Token(Token = "0x4007365")]
	[FieldOffset(Offset = "0x58")]
	private Action<bool> endCallback;
}
