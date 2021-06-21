using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000525 RID: 1317
[Token(Token = "0x20003BF")]
public class GluttonUI : FestivalUI
{
	// Token: 0x06001FF8 RID: 8184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B38")]
	[Address(RVA = "0x1FF3FB0", Offset = "0x1FF40B1", VA = "0x1FF3FB0", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06001FF9 RID: 8185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B39")]
	[Address(RVA = "0x1FF3FC0", Offset = "0x1FF40C1", VA = "0x1FF3FC0")]
	private void Start()
	{
	}

	// Token: 0x06001FFA RID: 8186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B3A")]
	[Address(RVA = "0x1FF3200", Offset = "0x1FF3301", VA = "0x1FF3200")]
	public void OnBtnImage(GluttonTablePos pos)
	{
	}

	// Token: 0x06001FFB RID: 8187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B3B")]
	[Address(RVA = "0x1FF3470", Offset = "0x1FF3571", VA = "0x1FF3470")]
	public void OnBtnImageOff()
	{
	}

	// Token: 0x06001FFC RID: 8188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B3C")]
	[Address(RVA = "0x1FF3340", Offset = "0x1FF3441", VA = "0x1FF3340")]
	public void OnBtnPush()
	{
	}

	// Token: 0x06001FFD RID: 8189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B3D")]
	[Address(RVA = "0x1FF3070", Offset = "0x1FF3171", VA = "0x1FF3070")]
	public void OnScoreImage(GluttonTablePos pos)
	{
	}

	// Token: 0x06001FFE RID: 8190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B3E")]
	[Address(RVA = "0x1FF33A0", Offset = "0x1FF34A1", VA = "0x1FF33A0")]
	public void OnScorePlay(bool _plus, int _score)
	{
	}

	// Token: 0x06001FFF RID: 8191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B3F")]
	[Address(RVA = "0x1FF3FE0", Offset = "0x1FF40E1", VA = "0x1FF3FE0")]
	public GluttonUI()
	{
	}

	// Token: 0x040066DB RID: 26331
	[Token(Token = "0x4006107")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject ImageBtnBase;

	// Token: 0x040066DC RID: 26332
	[Token(Token = "0x4006108")]
	[FieldOffset(Offset = "0x50")]
	private readonly Vector2 BTN_CENTER;

	// Token: 0x040066DD RID: 26333
	[Token(Token = "0x4006109")]
	[FieldOffset(Offset = "0x58")]
	private readonly Vector2 BTN_LEFT;

	// Token: 0x040066DE RID: 26334
	[Token(Token = "0x400610A")]
	[FieldOffset(Offset = "0x60")]
	private readonly Vector2 BTN_RIGHT;

	// Token: 0x040066DF RID: 26335
	[Token(Token = "0x400610B")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private FestivalNumScore ScorePlus;

	// Token: 0x040066E0 RID: 26336
	[Token(Token = "0x400610C")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private FestivalNumScore ScoreMinus;

	// Token: 0x040066E1 RID: 26337
	[Token(Token = "0x400610D")]
	[FieldOffset(Offset = "0x78")]
	private readonly Vector2 SCORE_CENTER;

	// Token: 0x040066E2 RID: 26338
	[Token(Token = "0x400610E")]
	[FieldOffset(Offset = "0x80")]
	private readonly Vector2 SCORE_LEFT;

	// Token: 0x040066E3 RID: 26339
	[Token(Token = "0x400610F")]
	[FieldOffset(Offset = "0x88")]
	private readonly Vector2 SCORE_RIGHT;
}
