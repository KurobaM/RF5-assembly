using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009CA RID: 2506
[Token(Token = "0x2000690")]
public class OrderHUDBlock : MonoBehaviour
{
	// Token: 0x17000914 RID: 2324
	// (get) Token: 0x06004194 RID: 16788 RVA: 0x00016200 File Offset: 0x00014400
	// (set) Token: 0x06004195 RID: 16789 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000744")]
	public bool isEnd
	{
		[Token(Token = "0x60036BF")]
		[Address(RVA = "0x20CB460", Offset = "0x20CB561", VA = "0x20CB460")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7520", Offset = "0x1A7621")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60036C0")]
		[Address(RVA = "0x20CB470", Offset = "0x20CB571", VA = "0x20CB470")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7530", Offset = "0x1A7631")]
		private set
		{
		}
	}

	// Token: 0x06004196 RID: 16790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036C1")]
	[Address(RVA = "0x20CB480", Offset = "0x20CB581", VA = "0x20CB480")]
	private void SetActive(bool value, float posX = 0f)
	{
	}

	// Token: 0x06004197 RID: 16791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036C2")]
	[Address(RVA = "0x20CB5C0", Offset = "0x20CB6C1", VA = "0x20CB5C0")]
	public void InstantiatedInit(OrderPopControl orderPopControl, int BlockNo, OrderData orderData, Sprite IconImage, float addShowTime)
	{
	}

	// Token: 0x06004198 RID: 16792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036C3")]
	[Address(RVA = "0x20CB7C0", Offset = "0x20CB8C1", VA = "0x20CB7C0")]
	public void OnStopInstantiatedInit(OrderPopControl orderPopControl)
	{
	}

	// Token: 0x06004199 RID: 16793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036C4")]
	[Address(RVA = "0x20CB830", Offset = "0x20CB931", VA = "0x20CB830")]
	public void OnUpdate(OrderData orderData)
	{
	}

	// Token: 0x0600419A RID: 16794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036C5")]
	[Address(RVA = "0x20CBA10", Offset = "0x20CBB11", VA = "0x20CBA10")]
	public void OnFinish(OrderData orderData)
	{
	}

	// Token: 0x0600419B RID: 16795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036C6")]
	[Address(RVA = "0x20CBD00", Offset = "0x20CBE01", VA = "0x20CBD00")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600419C RID: 16796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036C7")]
	[Address(RVA = "0x20CAE90", Offset = "0x20CAF91", VA = "0x20CAE90")]
	public void OnEnd(OrderData orderData)
	{
	}

	// Token: 0x0600419D RID: 16797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036C8")]
	[Address(RVA = "0x20CBDE0", Offset = "0x20CBEE1", VA = "0x20CBDE0")]
	public void OnFail(OrderData orderData)
	{
	}

	// Token: 0x0600419E RID: 16798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036C9")]
	[Address(RVA = "0x20CC030", Offset = "0x20CC131", VA = "0x20CC030")]
	public void SetRedisp(float plusTime)
	{
	}

	// Token: 0x0600419F RID: 16799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036CA")]
	[Address(RVA = "0x20CC0C0", Offset = "0x20CC1C1", VA = "0x20CC0C0")]
	public void SetStay(float plusTime)
	{
	}

	// Token: 0x060041A0 RID: 16800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036CB")]
	[Address(RVA = "0x20CB520", Offset = "0x20CB621", VA = "0x20CB520")]
	public void SetPosOnAppear(float posX)
	{
	}

	// Token: 0x060041A1 RID: 16801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036CC")]
	[Address(RVA = "0x20CC2B0", Offset = "0x20CC3B1", VA = "0x20CC2B0")]
	private void LateUpdate()
	{
	}

	// Token: 0x060041A2 RID: 16802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036CD")]
	[Address(RVA = "0x20CC690", Offset = "0x20CC791", VA = "0x20CC690")]
	public OrderHUDBlock()
	{
	}

	// Token: 0x0400A074 RID: 41076
	[Token(Token = "0x4007911")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform rect;

	// Token: 0x0400A075 RID: 41077
	[Token(Token = "0x4007912")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text DetailText;

	// Token: 0x0400A076 RID: 41078
	[Token(Token = "0x4007913")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text NumText;

	// Token: 0x0400A077 RID: 41079
	[Token(Token = "0x4007914")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image CompleteImg;

	// Token: 0x0400A078 RID: 41080
	[Token(Token = "0x4007915")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image FailImg;

	// Token: 0x0400A079 RID: 41081
	[Token(Token = "0x4007916")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Image IconImg;

	// Token: 0x0400A07A RID: 41082
	[Token(Token = "0x4007917")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float BlockPadding;

	// Token: 0x0400A07B RID: 41083
	[Token(Token = "0x4007918")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float StartX;

	// Token: 0x0400A07C RID: 41084
	[Token(Token = "0x4007919")]
	[FieldOffset(Offset = "0x50")]
	private int oldBlockNo;

	// Token: 0x0400A07D RID: 41085
	[Token(Token = "0x400791A")]
	[FieldOffset(Offset = "0x54")]
	public int blockNo;

	// Token: 0x0400A07E RID: 41086
	[Token(Token = "0x400791B")]
	[FieldOffset(Offset = "0x58")]
	private OrderPopControl Controller;

	// Token: 0x0400A07F RID: 41087
	[Token(Token = "0x400791C")]
	private const float ShowTimeOnStart = 5f;

	// Token: 0x0400A080 RID: 41088
	[Token(Token = "0x400791D")]
	private const float ShowTimeOnUpdate = 5f;

	// Token: 0x0400A081 RID: 41089
	[Token(Token = "0x400791E")]
	[FieldOffset(Offset = "0x60")]
	private float ShowTime;

	// Token: 0x0400A082 RID: 41090
	[Token(Token = "0x400791F")]
	[FieldOffset(Offset = "0x64")]
	private bool isFadeIn;

	// Token: 0x0400A083 RID: 41091
	[Token(Token = "0x4007920")]
	private const float fadeTimeMax = 0.2f;

	// Token: 0x0400A084 RID: 41092
	[Token(Token = "0x4007921")]
	[FieldOffset(Offset = "0x68")]
	private float fadeTime;

	// Token: 0x0400A085 RID: 41093
	[Token(Token = "0x4007922")]
	private const float updownFadeTimeMax = 0.2f;

	// Token: 0x0400A086 RID: 41094
	[Token(Token = "0x4007923")]
	[FieldOffset(Offset = "0x6C")]
	private float updownFadeTime;

	// Token: 0x0400A087 RID: 41095
	[Token(Token = "0x4007924")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x170910", Offset = "0x170A11")]
	private bool <isEnd>k__BackingField;

	// Token: 0x0400A088 RID: 41096
	[Token(Token = "0x4007925")]
	[FieldOffset(Offset = "0x71")]
	private bool onStopCreate;
}
