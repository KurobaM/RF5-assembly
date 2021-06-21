using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000950 RID: 2384
[Token(Token = "0x200063E")]
public class UIOnRectSizeAnimate : MonoBehaviour
{
	// Token: 0x170008E6 RID: 2278
	// (get) Token: 0x06003F33 RID: 16179 RVA: 0x000157C8 File Offset: 0x000139C8
	// (set) Token: 0x06003F34 RID: 16180 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700071C")]
	public bool isOpen
	{
		[Token(Token = "0x600348A")]
		[Address(RVA = "0x1EA9BD0", Offset = "0x1EA9CD1", VA = "0x1EA9BD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A70C0", Offset = "0x1A71C1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600348B")]
		[Address(RVA = "0x1EA9BE0", Offset = "0x1EA9CE1", VA = "0x1EA9BE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A70D0", Offset = "0x1A71D1")]
		private set
		{
		}
	}

	// Token: 0x06003F35 RID: 16181 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600348C")]
	[Address(RVA = "0x1EA9BF0", Offset = "0x1EA9CF1", VA = "0x1EA9BF0")]
	private void InitStart()
	{
	}

	// Token: 0x06003F36 RID: 16182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600348D")]
	[Address(RVA = "0x1EA9CC0", Offset = "0x1EA9DC1", VA = "0x1EA9CC0")]
	private void StartAnim()
	{
	}

	// Token: 0x06003F37 RID: 16183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600348E")]
	[Address(RVA = "0x1EA9D20", Offset = "0x1EA9E21", VA = "0x1EA9D20")]
	private void Start()
	{
	}

	// Token: 0x06003F38 RID: 16184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600348F")]
	[Address(RVA = "0x1EA9D80", Offset = "0x1EA9E81", VA = "0x1EA9D80")]
	private void OnEnable()
	{
	}

	// Token: 0x06003F39 RID: 16185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003490")]
	[Address(RVA = "0x1EA9DE0", Offset = "0x1EA9EE1", VA = "0x1EA9DE0")]
	private void OnDisable()
	{
	}

	// Token: 0x06003F3A RID: 16186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003491")]
	[Address(RVA = "0x1EA9E10", Offset = "0x1EA9F11", VA = "0x1EA9E10")]
	private void Update()
	{
	}

	// Token: 0x06003F3B RID: 16187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003492")]
	[Address(RVA = "0x1EA9F90", Offset = "0x1EAA091", VA = "0x1EA9F90")]
	public UIOnRectSizeAnimate()
	{
	}

	// Token: 0x040080B9 RID: 32953
	[Token(Token = "0x40073EA")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x16F7B0", Offset = "0x16F8B1")]
	private float MoveTimeX;

	// Token: 0x040080BA RID: 32954
	[Token(Token = "0x40073EB")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x16F800", Offset = "0x16F901")]
	private float MoveTimeY;

	// Token: 0x040080BB RID: 32955
	[Token(Token = "0x40073EC")]
	[FieldOffset(Offset = "0x20")]
	private Vector2 StartSize;

	// Token: 0x040080BC RID: 32956
	[Token(Token = "0x40073ED")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 TargetSize;

	// Token: 0x040080BD RID: 32957
	[Token(Token = "0x40073EE")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F850", Offset = "0x16F951")]
	private bool <isOpen>k__BackingField;

	// Token: 0x040080BE RID: 32958
	[Token(Token = "0x40073EF")]
	[FieldOffset(Offset = "0x38")]
	private RectTransform TargetRect;

	// Token: 0x040080BF RID: 32959
	[Token(Token = "0x40073F0")]
	[FieldOffset(Offset = "0x40")]
	private bool initedPos;

	// Token: 0x040080C0 RID: 32960
	[Token(Token = "0x40073F1")]
	[FieldOffset(Offset = "0x41")]
	private bool slided;

	// Token: 0x040080C1 RID: 32961
	[Token(Token = "0x40073F2")]
	[FieldOffset(Offset = "0x44")]
	private float nTime;
}
