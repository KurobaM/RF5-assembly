using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000B1E RID: 2846
[Token(Token = "0x200076A")]
public class UIAutoMoveImage : MonoBehaviour
{
	// Token: 0x06004998 RID: 18840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D8A")]
	[Address(RVA = "0x1FFD8F0", Offset = "0x1FFD9F1", VA = "0x1FFD8F0")]
	private void InitPos()
	{
	}

	// Token: 0x06004999 RID: 18841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D8B")]
	[Address(RVA = "0x1FFD9C0", Offset = "0x1FFDAC1", VA = "0x1FFD9C0")]
	private void Start()
	{
	}

	// Token: 0x0600499A RID: 18842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D8C")]
	[Address(RVA = "0x1FFD9D0", Offset = "0x1FFDAD1", VA = "0x1FFD9D0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600499B RID: 18843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D8D")]
	[Address(RVA = "0x1FFDA40", Offset = "0x1FFDB41", VA = "0x1FFDA40")]
	private void Update()
	{
	}

	// Token: 0x0600499C RID: 18844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D8E")]
	[Address(RVA = "0x1FFDC40", Offset = "0x1FFDD41", VA = "0x1FFDC40")]
	public UIAutoMoveImage()
	{
	}

	// Token: 0x0400A961 RID: 43361
	[Token(Token = "0x4007F96")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Vector2 MoveRange;

	// Token: 0x0400A962 RID: 43362
	[Token(Token = "0x4007F97")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float MoveSpeed;

	// Token: 0x0400A963 RID: 43363
	[Token(Token = "0x4007F98")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Vector3 RotateSpeed;

	// Token: 0x0400A964 RID: 43364
	[Token(Token = "0x4007F99")]
	[FieldOffset(Offset = "0x30")]
	private Image Image;

	// Token: 0x0400A965 RID: 43365
	[Token(Token = "0x4007F9A")]
	[FieldOffset(Offset = "0x38")]
	private float movTime;

	// Token: 0x0400A966 RID: 43366
	[Token(Token = "0x4007F9B")]
	[FieldOffset(Offset = "0x3C")]
	private float rotateTime;

	// Token: 0x0400A967 RID: 43367
	[Token(Token = "0x4007F9C")]
	[FieldOffset(Offset = "0x40")]
	private Vector2 StartPos;

	// Token: 0x0400A968 RID: 43368
	[Token(Token = "0x4007F9D")]
	[FieldOffset(Offset = "0x48")]
	private Quaternion StartRot;

	// Token: 0x0400A969 RID: 43369
	[Token(Token = "0x4007F9E")]
	[FieldOffset(Offset = "0x58")]
	private bool Inited;
}
