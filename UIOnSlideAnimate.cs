using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000951 RID: 2385
[Token(Token = "0x200063F")]
public class UIOnSlideAnimate : MonoBehaviour
{
	// Token: 0x170008E7 RID: 2279
	// (get) Token: 0x06003F3C RID: 16188 RVA: 0x000157E0 File Offset: 0x000139E0
	// (set) Token: 0x06003F3D RID: 16189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700071D")]
	public bool isOpen
	{
		[Token(Token = "0x6003493")]
		[Address(RVA = "0x1EA9FB0", Offset = "0x1EAA0B1", VA = "0x1EA9FB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A70E0", Offset = "0x1A71E1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003494")]
		[Address(RVA = "0x1EA9FC0", Offset = "0x1EAA0C1", VA = "0x1EA9FC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A70F0", Offset = "0x1A71F1")]
		private set
		{
		}
	}

	// Token: 0x06003F3E RID: 16190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003495")]
	[Address(RVA = "0x1EA9FD0", Offset = "0x1EAA0D1", VA = "0x1EA9FD0")]
	private void InitStartPos()
	{
	}

	// Token: 0x06003F3F RID: 16191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003496")]
	[Address(RVA = "0x1EAA0E0", Offset = "0x1EAA1E1", VA = "0x1EAA0E0")]
	private void StartSlide()
	{
	}

	// Token: 0x06003F40 RID: 16192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003497")]
	[Address(RVA = "0x1EAA140", Offset = "0x1EAA241", VA = "0x1EAA140")]
	private void Start()
	{
	}

	// Token: 0x06003F41 RID: 16193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003498")]
	[Address(RVA = "0x1EAA1A0", Offset = "0x1EAA2A1", VA = "0x1EAA1A0")]
	private void OnEnable()
	{
	}

	// Token: 0x06003F42 RID: 16194 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003499")]
	[Address(RVA = "0x1EAA200", Offset = "0x1EAA301", VA = "0x1EAA200")]
	private void OnDisable()
	{
	}

	// Token: 0x06003F43 RID: 16195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600349A")]
	[Address(RVA = "0x1EAA230", Offset = "0x1EAA331", VA = "0x1EAA230")]
	private void Update()
	{
	}

	// Token: 0x06003F44 RID: 16196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600349B")]
	[Address(RVA = "0x1EAA330", Offset = "0x1EAA431", VA = "0x1EAA330")]
	public UIOnSlideAnimate()
	{
	}

	// Token: 0x040080C2 RID: 32962
	[Token(Token = "0x40073F3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x16F860", Offset = "0x16F961")]
	private float MoveTime;

	// Token: 0x040080C3 RID: 32963
	[Token(Token = "0x40073F4")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Vector2 OnPosRange;

	// Token: 0x040080C4 RID: 32964
	[Token(Token = "0x40073F5")]
	[FieldOffset(Offset = "0x24")]
	private Vector2 StartPos;

	// Token: 0x040080C5 RID: 32965
	[Token(Token = "0x40073F6")]
	[FieldOffset(Offset = "0x2C")]
	private Vector2 TargetPos;

	// Token: 0x040080C6 RID: 32966
	[Token(Token = "0x40073F7")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F8C0", Offset = "0x16F9C1")]
	private bool <isOpen>k__BackingField;

	// Token: 0x040080C7 RID: 32967
	[Token(Token = "0x40073F8")]
	[FieldOffset(Offset = "0x38")]
	private RectTransform TargetRect;

	// Token: 0x040080C8 RID: 32968
	[Token(Token = "0x40073F9")]
	[FieldOffset(Offset = "0x40")]
	private Vector2 objectPos;

	// Token: 0x040080C9 RID: 32969
	[Token(Token = "0x40073FA")]
	[FieldOffset(Offset = "0x48")]
	private bool initedPos;

	// Token: 0x040080CA RID: 32970
	[Token(Token = "0x40073FB")]
	[FieldOffset(Offset = "0x49")]
	private bool slided;

	// Token: 0x040080CB RID: 32971
	[Token(Token = "0x40073FC")]
	[FieldOffset(Offset = "0x4C")]
	private float nTime;
}
