using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200094F RID: 2383
[Token(Token = "0x200063D")]
public class UIOnOffAnimate : MonoBehaviour
{
	// Token: 0x170008E4 RID: 2276
	// (get) Token: 0x06003F27 RID: 16167 RVA: 0x00015798 File Offset: 0x00013998
	[Token(Token = "0x1700071A")]
	public static bool isAnimateInputBlocking
	{
		[Token(Token = "0x600347E")]
		[Address(RVA = "0x1EA9060", Offset = "0x1EA9161", VA = "0x1EA9060")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170008E5 RID: 2277
	// (get) Token: 0x06003F28 RID: 16168 RVA: 0x000157B0 File Offset: 0x000139B0
	// (set) Token: 0x06003F29 RID: 16169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700071B")]
	public bool isOpen
	{
		[Token(Token = "0x600347F")]
		[Address(RVA = "0x1EA90E0", Offset = "0x1EA91E1", VA = "0x1EA90E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A70A0", Offset = "0x1A71A1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003480")]
		[Address(RVA = "0x1EA90F0", Offset = "0x1EA91F1", VA = "0x1EA90F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A70B0", Offset = "0x1A71B1")]
		private set
		{
		}
	}

	// Token: 0x06003F2A RID: 16170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003481")]
	[Address(RVA = "0x1EA9100", Offset = "0x1EA9201", VA = "0x1EA9100")]
	private void Init()
	{
	}

	// Token: 0x06003F2B RID: 16171 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003482")]
	[Address(RVA = "0x1EA91C0", Offset = "0x1EA92C1", VA = "0x1EA91C0")]
	public void ForceClose()
	{
	}

	// Token: 0x06003F2C RID: 16172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003483")]
	[Address(RVA = "0x1EA93B0", Offset = "0x1EA94B1", VA = "0x1EA93B0")]
	public void DoOpen()
	{
	}

	// Token: 0x06003F2D RID: 16173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003484")]
	[Address(RVA = "0x1EA9560", Offset = "0x1EA9661", VA = "0x1EA9560")]
	public void DoClose()
	{
	}

	// Token: 0x06003F2E RID: 16174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003485")]
	[Address(RVA = "0x1EA96B0", Offset = "0x1EA97B1", VA = "0x1EA96B0")]
	private void OnOpened()
	{
	}

	// Token: 0x06003F2F RID: 16175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003486")]
	[Address(RVA = "0x1EA9200", Offset = "0x1EA9301", VA = "0x1EA9200")]
	private void OnClosed()
	{
	}

	// Token: 0x06003F30 RID: 16176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003487")]
	[Address(RVA = "0x1EA97C0", Offset = "0x1EA98C1", VA = "0x1EA97C0")]
	private void Update()
	{
	}

	// Token: 0x06003F31 RID: 16177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003488")]
	[Address(RVA = "0x1EA9AC0", Offset = "0x1EA9BC1", VA = "0x1EA9AC0")]
	public UIOnOffAnimate()
	{
	}

	// Token: 0x040080A9 RID: 32937
	[Token(Token = "0x40073DA")]
	[FieldOffset(Offset = "0x0")]
	private static List<UIOnOffAnimate> NowUsingList;

	// Token: 0x040080AA RID: 32938
	[Token(Token = "0x40073DB")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x16F6E0", Offset = "0x16F7E1")]
	private float MoveTime;

	// Token: 0x040080AB RID: 32939
	[Token(Token = "0x40073DC")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Vector2 StartPos;

	// Token: 0x040080AC RID: 32940
	[Token(Token = "0x40073DD")]
	[FieldOffset(Offset = "0x24")]
	private Vector2 originPos;

	// Token: 0x040080AD RID: 32941
	[Token(Token = "0x40073DE")]
	[FieldOffset(Offset = "0x2C")]
	private Vector2 targetPos;

	// Token: 0x040080AE RID: 32942
	[Token(Token = "0x40073DF")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private bool BlockInputWhileAnimating;

	// Token: 0x040080AF RID: 32943
	[Token(Token = "0x40073E0")]
	[FieldOffset(Offset = "0x35")]
	[SerializeField]
	private bool DestroyAfterEnded;

	// Token: 0x040080B0 RID: 32944
	[Token(Token = "0x40073E1")]
	[FieldOffset(Offset = "0x36")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F760", Offset = "0x16F861")]
	private bool <isOpen>k__BackingField;

	// Token: 0x040080B1 RID: 32945
	[Token(Token = "0x40073E2")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform TargetRect;

	// Token: 0x040080B2 RID: 32946
	[Token(Token = "0x40073E3")]
	[FieldOffset(Offset = "0x40")]
	private float nTime;

	// Token: 0x040080B3 RID: 32947
	[Token(Token = "0x40073E4")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private CanvasGroup canvasGroup;

	// Token: 0x040080B4 RID: 32948
	[Token(Token = "0x40073E5")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AnimationCurve slideCurve;

	// Token: 0x040080B5 RID: 32949
	[Token(Token = "0x40073E6")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AnimationCurve fadeCurve;

	// Token: 0x040080B6 RID: 32950
	[Token(Token = "0x40073E7")]
	[FieldOffset(Offset = "0x60")]
	private float curveSpeed;

	// Token: 0x040080B7 RID: 32951
	[Token(Token = "0x40073E8")]
	[FieldOffset(Offset = "0x64")]
	private float curveRate;

	// Token: 0x040080B8 RID: 32952
	[Token(Token = "0x40073E9")]
	[FieldOffset(Offset = "0x68")]
	private bool isInit;
}
