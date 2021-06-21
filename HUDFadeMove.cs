using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020009AE RID: 2478
[Token(Token = "0x200067D")]
public class HUDFadeMove : MonoBehaviour
{
	// Token: 0x060040AA RID: 16554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035E5")]
	[Address(RVA = "0x204B610", Offset = "0x204B711", VA = "0x204B610")]
	private void DnStartUp()
	{
	}

	// Token: 0x060040AB RID: 16555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035E6")]
	[Address(RVA = "0x204B750", Offset = "0x204B851", VA = "0x204B750")]
	private void Awake()
	{
	}

	// Token: 0x060040AC RID: 16556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035E7")]
	[Address(RVA = "0x204B760", Offset = "0x204B861", VA = "0x204B760")]
	private void LateUpdate()
	{
	}

	// Token: 0x060040AD RID: 16557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035E8")]
	[Address(RVA = "0x204BAF0", Offset = "0x204BBF1", VA = "0x204BAF0")]
	private void OnDisable()
	{
	}

	// Token: 0x060040AE RID: 16558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035E9")]
	[Address(RVA = "0x2045E50", Offset = "0x2045F51", VA = "0x2045E50")]
	public void ForceOut()
	{
	}

	// Token: 0x060040AF RID: 16559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035EA")]
	[Address(RVA = "0x20469F0", Offset = "0x2046AF1", VA = "0x20469F0")]
	public void SetFadeOut()
	{
	}

	// Token: 0x060040B0 RID: 16560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035EB")]
	[Address(RVA = "0x20469B0", Offset = "0x2046AB1", VA = "0x20469B0")]
	public void SetFadeIn()
	{
	}

	// Token: 0x060040B1 RID: 16561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035EC")]
	[Address(RVA = "0x204BBB0", Offset = "0x204BCB1", VA = "0x204BBB0")]
	private void SetFade(float fadeDelayTime, Vector2 nextPos)
	{
	}

	// Token: 0x060040B2 RID: 16562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035ED")]
	[Address(RVA = "0x204BAA0", Offset = "0x204BBA1", VA = "0x204BAA0")]
	private void OnFadeEnd()
	{
	}

	// Token: 0x060040B3 RID: 16563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035EE")]
	[Address(RVA = "0x204BDA0", Offset = "0x204BEA1", VA = "0x204BDA0")]
	public HUDFadeMove()
	{
	}

	// Token: 0x04009F51 RID: 40785
	[Token(Token = "0x4007813")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Vector2 MoveRange;

	// Token: 0x04009F52 RID: 40786
	[Token(Token = "0x4007814")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool fadeScaleX;

	// Token: 0x04009F53 RID: 40787
	[Token(Token = "0x4007815")]
	[FieldOffset(Offset = "0x21")]
	[SerializeField]
	private bool fadeAlpha;

	// Token: 0x04009F54 RID: 40788
	[Token(Token = "0x4007816")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float fadeOutMax;

	// Token: 0x04009F55 RID: 40789
	[Token(Token = "0x4007817")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float fadeInMax;

	// Token: 0x04009F56 RID: 40790
	[Token(Token = "0x4007818")]
	[FieldOffset(Offset = "0x30")]
	private CanvasGroup canvasGroup;

	// Token: 0x04009F57 RID: 40791
	[Token(Token = "0x4007819")]
	[FieldOffset(Offset = "0x38")]
	private AnimationCurve slideCurve;

	// Token: 0x04009F58 RID: 40792
	[Token(Token = "0x400781A")]
	[FieldOffset(Offset = "0x40")]
	private AnimationCurve fadeCurve;

	// Token: 0x04009F59 RID: 40793
	[Token(Token = "0x400781B")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 startPos;

	// Token: 0x04009F5A RID: 40794
	[Token(Token = "0x400781C")]
	[FieldOffset(Offset = "0x50")]
	private Vector2 nowPos;

	// Token: 0x04009F5B RID: 40795
	[Token(Token = "0x400781D")]
	[FieldOffset(Offset = "0x58")]
	private Vector2 fadePos;

	// Token: 0x04009F5C RID: 40796
	[Token(Token = "0x400781E")]
	[FieldOffset(Offset = "0x60")]
	private Vector2 InstantPos;

	// Token: 0x04009F5D RID: 40797
	[Token(Token = "0x400781F")]
	[FieldOffset(Offset = "0x68")]
	private RectTransform RectTransform;

	// Token: 0x04009F5E RID: 40798
	[Token(Token = "0x4007820")]
	[FieldOffset(Offset = "0x70")]
	private HUDFadeMove.FadeStatus status;

	// Token: 0x04009F5F RID: 40799
	[Token(Token = "0x4007821")]
	[FieldOffset(Offset = "0x74")]
	private float fadeTimeCount;

	// Token: 0x04009F60 RID: 40800
	[Token(Token = "0x4007822")]
	[FieldOffset(Offset = "0x78")]
	private float nowFadeDelay;

	// Token: 0x04009F61 RID: 40801
	[Token(Token = "0x4007823")]
	[FieldOffset(Offset = "0x7C")]
	private float forceFadeTime;

	// Token: 0x04009F62 RID: 40802
	[Token(Token = "0x4007824")]
	[FieldOffset(Offset = "0x80")]
	private bool isForceFadeIn;

	// Token: 0x04009F63 RID: 40803
	[Token(Token = "0x4007825")]
	[FieldOffset(Offset = "0x84")]
	private float curveSpeed;

	// Token: 0x04009F64 RID: 40804
	[Token(Token = "0x4007826")]
	[FieldOffset(Offset = "0x88")]
	private float curveRate;

	// Token: 0x04009F65 RID: 40805
	[Token(Token = "0x4007827")]
	[FieldOffset(Offset = "0x8C")]
	private bool isStartUp;

	// Token: 0x020009AF RID: 2479
	[Token(Token = "0x20012B3")]
	private enum FadeStatus
	{
		// Token: 0x04009F67 RID: 40807
		[Token(Token = "0x401B3A2")]
		In,
		// Token: 0x04009F68 RID: 40808
		[Token(Token = "0x401B3A3")]
		Out
	}
}
