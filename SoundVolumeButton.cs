using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A9C RID: 2716
[Token(Token = "0x200071E")]
public class SoundVolumeButton : ButtonLinkerSetImage
{
	// Token: 0x17000976 RID: 2422
	// (get) Token: 0x0600469A RID: 18074 RVA: 0x000172E0 File Offset: 0x000154E0
	// (set) Token: 0x0600469B RID: 18075 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000798")]
	private float SoundValue
	{
		[Token(Token = "0x6003B1E")]
		[Address(RVA = "0x225D380", Offset = "0x225D481", VA = "0x225D380")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6003B1F")]
		[Address(RVA = "0x225D440", Offset = "0x225D541", VA = "0x225D440")]
		set
		{
		}
	}

	// Token: 0x0600469C RID: 18076 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B20")]
	[Address(RVA = "0x225D510", Offset = "0x225D611", VA = "0x225D510", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x0600469D RID: 18077 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B21")]
	[Address(RVA = "0x225D520", Offset = "0x225D621", VA = "0x225D520", Slot = "8")]
	public override void OnNextFocus(CursorLinker nextObject)
	{
	}

	// Token: 0x0600469E RID: 18078 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B22")]
	[Address(RVA = "0x225D530", Offset = "0x225D631", VA = "0x225D530")]
	private void OnEnable()
	{
	}

	// Token: 0x0600469F RID: 18079 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B23")]
	[Address(RVA = "0x225D660", Offset = "0x225D761", VA = "0x225D660")]
	private void SyncGauge()
	{
	}

	// Token: 0x060046A0 RID: 18080 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B24")]
	[Address(RVA = "0x225D730", Offset = "0x225D831", VA = "0x225D730")]
	private void Update()
	{
	}

	// Token: 0x060046A1 RID: 18081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B25")]
	[Address(RVA = "0x225D9A0", Offset = "0x225DAA1", VA = "0x225D9A0")]
	public void OnSliderChange()
	{
	}

	// Token: 0x060046A2 RID: 18082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B26")]
	[Address(RVA = "0x225D9F0", Offset = "0x225DAF1", VA = "0x225D9F0")]
	private void Start()
	{
	}

	// Token: 0x060046A3 RID: 18083 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B27")]
	[Address(RVA = "0x225DA50", Offset = "0x225DB51", VA = "0x225DA50")]
	public SoundVolumeButton()
	{
	}

	// Token: 0x0400A599 RID: 42393
	[Token(Token = "0x4007D1A")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private Image Gauge;

	// Token: 0x0400A59A RID: 42394
	[Token(Token = "0x4007D1B")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private Slider Slider;

	// Token: 0x0400A59B RID: 42395
	[Token(Token = "0x4007D1C")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private MixerVolumeGroup MixerGroup;

	// Token: 0x0400A59C RID: 42396
	[Token(Token = "0x4007D1D")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private Text SoundVolumeText;
}
