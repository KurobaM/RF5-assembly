using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000B2D RID: 2861
[Token(Token = "0x2000778")]
public class DamageText : MonoBehaviour
{
	// Token: 0x170009C9 RID: 2505
	// (get) Token: 0x060049DB RID: 18907 RVA: 0x00017C10 File Offset: 0x00015E10
	// (set) Token: 0x060049DC RID: 18908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007CB")]
	public bool IsCritical
	{
		[Token(Token = "0x6003DCD")]
		[Address(RVA = "0x1DA25B0", Offset = "0x1DA26B1", VA = "0x1DA25B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8AB0", Offset = "0x1A8BB1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003DCE")]
		[Address(RVA = "0x1DA25C0", Offset = "0x1DA26C1", VA = "0x1DA25C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8AC0", Offset = "0x1A8BC1")]
		set
		{
		}
	}

	// Token: 0x170009CA RID: 2506
	// (get) Token: 0x060049DD RID: 18909 RVA: 0x00017C28 File Offset: 0x00015E28
	// (set) Token: 0x060049DE RID: 18910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007CC")]
	public bool IsWeakAtk
	{
		[Token(Token = "0x6003DCF")]
		[Address(RVA = "0x1DA25D0", Offset = "0x1DA26D1", VA = "0x1DA25D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8AD0", Offset = "0x1A8BD1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003DD0")]
		[Address(RVA = "0x1DA25E0", Offset = "0x1DA26E1", VA = "0x1DA25E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8AE0", Offset = "0x1A8BE1")]
		set
		{
		}
	}

	// Token: 0x170009CB RID: 2507
	// (get) Token: 0x060049DF RID: 18911 RVA: 0x00017C40 File Offset: 0x00015E40
	// (set) Token: 0x060049E0 RID: 18912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007CD")]
	public bool IsResistAtk
	{
		[Token(Token = "0x6003DD1")]
		[Address(RVA = "0x1DA25F0", Offset = "0x1DA26F1", VA = "0x1DA25F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8AF0", Offset = "0x1A8BF1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003DD2")]
		[Address(RVA = "0x1DA2600", Offset = "0x1DA2701", VA = "0x1DA2600")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8B00", Offset = "0x1A8C01")]
		set
		{
		}
	}

	// Token: 0x060049E1 RID: 18913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DD3")]
	[Address(RVA = "0x1DA2610", Offset = "0x1DA2711", VA = "0x1DA2610")]
	public void UseDelay()
	{
	}

	// Token: 0x060049E2 RID: 18914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DD4")]
	[Address(RVA = "0x1DA2620", Offset = "0x1DA2721", VA = "0x1DA2620")]
	private void Start()
	{
	}

	// Token: 0x060049E3 RID: 18915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DD5")]
	[Address(RVA = "0x1DA29E0", Offset = "0x1DA2AE1", VA = "0x1DA29E0")]
	private void SetPos(Vector3 addForce)
	{
	}

	// Token: 0x060049E4 RID: 18916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DD6")]
	[Address(RVA = "0x1DA2C50", Offset = "0x1DA2D51", VA = "0x1DA2C50")]
	private void Update()
	{
	}

	// Token: 0x060049E5 RID: 18917 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DD7")]
	[Address(RVA = "0x1DA3100", Offset = "0x1DA3201", VA = "0x1DA3100")]
	public DamageText()
	{
	}

	// Token: 0x0400A9F7 RID: 43511
	[Token(Token = "0x4008023")]
	[FieldOffset(Offset = "0x0")]
	private static DamageText.MoveType lastMoveType;

	// Token: 0x0400A9F8 RID: 43512
	[Token(Token = "0x4008024")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 position;

	// Token: 0x0400A9F9 RID: 43513
	[Token(Token = "0x4008025")]
	[FieldOffset(Offset = "0x24")]
	public int DamageValue;

	// Token: 0x0400A9FA RID: 43514
	[Token(Token = "0x4008026")]
	[FieldOffset(Offset = "0x28")]
	public Color TextColor;

	// Token: 0x0400A9FB RID: 43515
	[Token(Token = "0x4008027")]
	[FieldOffset(Offset = "0x38")]
	public UIDamageType UIDamageType;

	// Token: 0x0400A9FC RID: 43516
	[Token(Token = "0x4008028")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float dispTime;

	// Token: 0x0400A9FD RID: 43517
	[Token(Token = "0x4008029")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float fadeTime;

	// Token: 0x0400A9FE RID: 43518
	[Token(Token = "0x400802A")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float delayTimeForFriendlyPoint;

	// Token: 0x0400A9FF RID: 43519
	[Token(Token = "0x400802B")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float fadeMoveSpeed;

	// Token: 0x0400AA00 RID: 43520
	[Token(Token = "0x400802C")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AnimationCurve LRAnimationCurve;

	// Token: 0x0400AA01 RID: 43521
	[Token(Token = "0x400802D")]
	[FieldOffset(Offset = "0x58")]
	private DamageText.MoveType moveType;

	// Token: 0x0400AA02 RID: 43522
	[Token(Token = "0x400802E")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private TextMeshProUGUI TextMesh;

	// Token: 0x0400AA03 RID: 43523
	[Token(Token = "0x400802F")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private TMP_SpriteAsset[] TMP_SpriteAsset;

	// Token: 0x0400AA04 RID: 43524
	[Token(Token = "0x4008030")]
	[FieldOffset(Offset = "0x70")]
	private float lifeTime;

	// Token: 0x0400AA05 RID: 43525
	[Token(Token = "0x4008031")]
	[FieldOffset(Offset = "0x74")]
	private float delaytime;

	// Token: 0x0400AA06 RID: 43526
	[Token(Token = "0x4008032")]
	[FieldOffset(Offset = "0x78")]
	private RectTransform rectTransform;

	// Token: 0x0400AA07 RID: 43527
	[Token(Token = "0x4008033")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 addPos;

	// Token: 0x0400AA08 RID: 43528
	[Token(Token = "0x4008034")]
	[FieldOffset(Offset = "0x8C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x174740", Offset = "0x174841")]
	private bool <IsCritical>k__BackingField;

	// Token: 0x0400AA09 RID: 43529
	[Token(Token = "0x4008035")]
	[FieldOffset(Offset = "0x8D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x174750", Offset = "0x174851")]
	private bool <IsWeakAtk>k__BackingField;

	// Token: 0x0400AA0A RID: 43530
	[Token(Token = "0x4008036")]
	[FieldOffset(Offset = "0x8E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x174760", Offset = "0x174861")]
	private bool <IsResistAtk>k__BackingField;

	// Token: 0x0400AA0B RID: 43531
	[Token(Token = "0x4008037")]
	[FieldOffset(Offset = "0x90")]
	private float expandMax;

	// Token: 0x0400AA0C RID: 43532
	[Token(Token = "0x4008038")]
	[FieldOffset(Offset = "0x94")]
	private float animTimeCount;

	// Token: 0x02000B2E RID: 2862
	[Token(Token = "0x2001337")]
	private enum MoveType
	{
		// Token: 0x0400AA0E RID: 43534
		[Token(Token = "0x401B638")]
		Normal,
		// Token: 0x0400AA0F RID: 43535
		[Token(Token = "0x401B639")]
		Left,
		// Token: 0x0400AA10 RID: 43536
		[Token(Token = "0x401B63A")]
		Right,
		// Token: 0x0400AA11 RID: 43537
		[Token(Token = "0x401B63B")]
		LRMax,
		// Token: 0x0400AA12 RID: 43538
		[Token(Token = "0x401B63C")]
		Down
	}
}
