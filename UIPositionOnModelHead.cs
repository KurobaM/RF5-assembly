using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020009D3 RID: 2515
[Token(Token = "0x2000694")]
public class UIPositionOnModelHead : MonoBehaviour
{
	// Token: 0x17000915 RID: 2325
	// (get) Token: 0x060041C8 RID: 16840 RVA: 0x000162D8 File Offset: 0x000144D8
	// (set) Token: 0x060041C9 RID: 16841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000745")]
	public float AddHeight
	{
		[Token(Token = "0x60036EC")]
		[Address(RVA = "0x1EAC8D0", Offset = "0x1EAC9D1", VA = "0x1EAC8D0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60036ED")]
		[Address(RVA = "0x1EAC8E0", Offset = "0x1EAC9E1", VA = "0x1EAC8E0")]
		set
		{
		}
	}

	// Token: 0x17000916 RID: 2326
	// (get) Token: 0x060041CA RID: 16842 RVA: 0x000162F0 File Offset: 0x000144F0
	// (set) Token: 0x060041CB RID: 16843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000746")]
	public bool AutoAdjustPositionInScreen
	{
		[Token(Token = "0x60036EE")]
		[Address(RVA = "0x1EAC8F0", Offset = "0x1EAC9F1", VA = "0x1EAC8F0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60036EF")]
		[Address(RVA = "0x1EAC900", Offset = "0x1EACA01", VA = "0x1EAC900")]
		set
		{
		}
	}

	// Token: 0x17000917 RID: 2327
	// (get) Token: 0x060041CC RID: 16844 RVA: 0x00016308 File Offset: 0x00014508
	// (set) Token: 0x060041CD RID: 16845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000747")]
	public Vector2 BorderSize
	{
		[Token(Token = "0x60036F0")]
		[Address(RVA = "0x1EAC910", Offset = "0x1EACA11", VA = "0x1EAC910")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x60036F1")]
		[Address(RVA = "0x1EAC920", Offset = "0x1EACA21", VA = "0x1EAC920")]
		set
		{
		}
	}

	// Token: 0x060041CE RID: 16846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036F2")]
	[Address(RVA = "0x1EAC930", Offset = "0x1EACA31", VA = "0x1EAC930")]
	public void Start()
	{
	}

	// Token: 0x060041CF RID: 16847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036F3")]
	[Address(RVA = "0x1EACA50", Offset = "0x1EACB51", VA = "0x1EACA50")]
	public void SetTarget(GameObject targetObj)
	{
	}

	// Token: 0x060041D0 RID: 16848 RVA: 0x00016320 File Offset: 0x00014520
	[Token(Token = "0x60036F4")]
	[Address(RVA = "0x1EACB10", Offset = "0x1EACC11", VA = "0x1EACB10")]
	private bool SetBounds(GameObject targetObj)
	{
		return default(bool);
	}

	// Token: 0x060041D1 RID: 16849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036F5")]
	[Address(RVA = "0x1EACCB0", Offset = "0x1EACDB1", VA = "0x1EACCB0")]
	private void Update()
	{
	}

	// Token: 0x060041D2 RID: 16850 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036F6")]
	[Address(RVA = "0x1EACFE0", Offset = "0x1EAD0E1", VA = "0x1EACFE0")]
	public UIPositionOnModelHead()
	{
	}

	// Token: 0x0400A0AF RID: 41135
	[Token(Token = "0x4007938")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject TargetObject;

	// Token: 0x0400A0B0 RID: 41136
	[Token(Token = "0x4007939")]
	[FieldOffset(Offset = "0x20")]
	private bool BoundSetFlag;

	// Token: 0x0400A0B1 RID: 41137
	[Token(Token = "0x400793A")]
	[FieldOffset(Offset = "0x24")]
	private Bounds TargetBounds;

	// Token: 0x0400A0B2 RID: 41138
	[Token(Token = "0x400793B")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _AddHeight;

	// Token: 0x0400A0B3 RID: 41139
	[Token(Token = "0x400793C")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool _AutoAdjustPositionInScreen;

	// Token: 0x0400A0B4 RID: 41140
	[Token(Token = "0x400793D")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private Vector2 _BorderSize;

	// Token: 0x0400A0B5 RID: 41141
	[Token(Token = "0x400793E")]
	private const float defaultPlusY = 1f;
}
