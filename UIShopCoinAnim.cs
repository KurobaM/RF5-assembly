using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000AB7 RID: 2743
[Token(Token = "0x2000734")]
public class UIShopCoinAnim : MonoBehaviour
{
	// Token: 0x06004742 RID: 18242 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003BB8")]
	[Address(RVA = "0x1EBA140", Offset = "0x1EBA241", VA = "0x1EBA140")]
	public UIShopCoinAnim CloneUse(Vector2 addPos)
	{
		return null;
	}

	// Token: 0x06004743 RID: 18243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BB9")]
	[Address(RVA = "0x1EBA2F0", Offset = "0x1EBA3F1", VA = "0x1EBA2F0")]
	private void SetCloneInit(UIShopCoinAnim originalObj)
	{
	}

	// Token: 0x06004744 RID: 18244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BBA")]
	[Address(RVA = "0x1EBA4F0", Offset = "0x1EBA5F1", VA = "0x1EBA4F0")]
	private void Update()
	{
	}

	// Token: 0x06004745 RID: 18245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BBB")]
	[Address(RVA = "0x1EBA8C0", Offset = "0x1EBA9C1", VA = "0x1EBA8C0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06004746 RID: 18246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BBC")]
	[Address(RVA = "0x1EBA980", Offset = "0x1EBAA81", VA = "0x1EBA980")]
	public UIShopCoinAnim()
	{
	}

	// Token: 0x0400A664 RID: 42596
	[Token(Token = "0x4007DCC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public RectTransform TargetPoint;

	// Token: 0x0400A665 RID: 42597
	[Token(Token = "0x4007DCD")]
	[FieldOffset(Offset = "0x20")]
	private Vector2 StartPos;

	// Token: 0x0400A666 RID: 42598
	[Token(Token = "0x4007DCE")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 StartSize;

	// Token: 0x0400A667 RID: 42599
	[Token(Token = "0x4007DCF")]
	[FieldOffset(Offset = "0x30")]
	private Image Image;

	// Token: 0x0400A668 RID: 42600
	[Token(Token = "0x4007DD0")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public Sprite[] RandSprites;

	// Token: 0x0400A669 RID: 42601
	[Token(Token = "0x4007DD1")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public float MovTimeMax;

	// Token: 0x0400A66A RID: 42602
	[Token(Token = "0x4007DD2")]
	[FieldOffset(Offset = "0x44")]
	private float MovTime;

	// Token: 0x0400A66B RID: 42603
	[Token(Token = "0x4007DD3")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public AnimationCurve AddXCurve;

	// Token: 0x0400A66C RID: 42604
	[Token(Token = "0x4007DD4")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public AnimationCurve AddYCurve;

	// Token: 0x0400A66D RID: 42605
	[Token(Token = "0x4007DD5")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	public Vector2 AddRange;

	// Token: 0x0400A66E RID: 42606
	[Token(Token = "0x4007DD6")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public int LastCoinMax;

	// Token: 0x0400A66F RID: 42607
	[Token(Token = "0x4007DD7")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	public int LastCoinMin;

	// Token: 0x0400A670 RID: 42608
	[Token(Token = "0x4007DD8")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	public AnimationCurve CurveRotateCoin;

	// Token: 0x0400A671 RID: 42609
	[Token(Token = "0x4007DD9")]
	[FieldOffset(Offset = "0x70")]
	private float RotateTime;

	// Token: 0x0400A672 RID: 42610
	[Token(Token = "0x4007DDA")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	public float rotateScale;

	// Token: 0x0400A673 RID: 42611
	[Token(Token = "0x4007DDB")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public UIShopMoneyEffect UIShopMoneyEffect;

	// Token: 0x0400A674 RID: 42612
	[Token(Token = "0x4007DDC")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	public UIShopMoneyEffect UIShopMoneyEffect2;

	// Token: 0x0400A675 RID: 42613
	[Token(Token = "0x4007DDD")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x1738B0", Offset = "0x1739B1")]
	public float EffectRate;
}
