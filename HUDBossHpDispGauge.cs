using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000997 RID: 2455
[Token(Token = "0x2000672")]
public class HUDBossHpDispGauge : MonoBehaviour
{
	// Token: 0x0600403B RID: 16443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600358C")]
	[Address(RVA = "0x20424A0", Offset = "0x20425A1", VA = "0x20424A0")]
	public void SetHpPercent(float var)
	{
	}

	// Token: 0x0600403C RID: 16444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600358D")]
	[Address(RVA = "0x20426E0", Offset = "0x20427E1", VA = "0x20426E0")]
	private void Update()
	{
	}

	// Token: 0x0600403D RID: 16445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600358E")]
	[Address(RVA = "0x20427B0", Offset = "0x20428B1", VA = "0x20427B0")]
	public HUDBossHpDispGauge()
	{
	}

	// Token: 0x04009E9F RID: 40607
	[Token(Token = "0x400779D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image image;

	// Token: 0x04009EA0 RID: 40608
	[Token(Token = "0x400779E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float minPercent;

	// Token: 0x04009EA1 RID: 40609
	[Token(Token = "0x400779F")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float maxPercent;

	// Token: 0x04009EA2 RID: 40610
	[Token(Token = "0x40077A0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float fadeTime;

	// Token: 0x04009EA3 RID: 40611
	[Token(Token = "0x40077A1")]
	[FieldOffset(Offset = "0x2C")]
	private float nTime;

	// Token: 0x04009EA4 RID: 40612
	[Token(Token = "0x40077A2")]
	[FieldOffset(Offset = "0x30")]
	private bool onDisp;
}
