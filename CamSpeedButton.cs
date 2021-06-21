using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A95 RID: 2709
[Token(Token = "0x2000719")]
public class CamSpeedButton : ButtonLinkerSetImage
{
	// Token: 0x17000974 RID: 2420
	// (get) Token: 0x06004675 RID: 18037 RVA: 0x000172B0 File Offset: 0x000154B0
	// (set) Token: 0x06004676 RID: 18038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000796")]
	private float _Value
	{
		[Token(Token = "0x6003AF9")]
		[Address(RVA = "0x1E753A0", Offset = "0x1E754A1", VA = "0x1E753A0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6003AFA")]
		[Address(RVA = "0x1E753E0", Offset = "0x1E754E1", VA = "0x1E753E0")]
		set
		{
		}
	}

	// Token: 0x06004677 RID: 18039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AFB")]
	[Address(RVA = "0x1E75440", Offset = "0x1E75541", VA = "0x1E75440", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x06004678 RID: 18040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AFC")]
	[Address(RVA = "0x1E75450", Offset = "0x1E75551", VA = "0x1E75450", Slot = "8")]
	public override void OnNextFocus(CursorLinker nextObject)
	{
	}

	// Token: 0x06004679 RID: 18041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AFD")]
	[Address(RVA = "0x1E75460", Offset = "0x1E75561", VA = "0x1E75460")]
	private void OnEnable()
	{
	}

	// Token: 0x0600467A RID: 18042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AFE")]
	[Address(RVA = "0x1E755B0", Offset = "0x1E756B1", VA = "0x1E755B0")]
	private void SyncGauge()
	{
	}

	// Token: 0x0600467B RID: 18043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AFF")]
	[Address(RVA = "0x1E75690", Offset = "0x1E75791", VA = "0x1E75690")]
	private void Update()
	{
	}

	// Token: 0x0600467C RID: 18044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B00")]
	[Address(RVA = "0x1E759F0", Offset = "0x1E75AF1", VA = "0x1E759F0")]
	public void OnSliderChange()
	{
	}

	// Token: 0x0600467D RID: 18045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B01")]
	[Address(RVA = "0x1E75A40", Offset = "0x1E75B41", VA = "0x1E75A40")]
	private void Start()
	{
	}

	// Token: 0x0600467E RID: 18046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B02")]
	[Address(RVA = "0x1E75AA0", Offset = "0x1E75BA1", VA = "0x1E75AA0")]
	public CamSpeedButton()
	{
	}

	// Token: 0x0400A579 RID: 42361
	[Token(Token = "0x4007D00")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private Image Gauge;

	// Token: 0x0400A57A RID: 42362
	[Token(Token = "0x4007D01")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private Slider Slider;

	// Token: 0x0400A57B RID: 42363
	[Token(Token = "0x4007D02")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private Text valueText;

	// Token: 0x0400A57C RID: 42364
	[Token(Token = "0x4007D03")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private CamSpeedButton.CamType camType;

	// Token: 0x02000A96 RID: 2710
	[Token(Token = "0x20012FE")]
	public enum CamType
	{
		// Token: 0x0400A57E RID: 42366
		[Token(Token = "0x401B4DD")]
		vertical,
		// Token: 0x0400A57F RID: 42367
		[Token(Token = "0x401B4DE")]
		horizontal
	}
}
