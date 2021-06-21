using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B20 RID: 2848
[Token(Token = "0x200076C")]
public class UIImageMove : MonoBehaviour
{
	// Token: 0x060049A0 RID: 18848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D92")]
	[Address(RVA = "0x2011220", Offset = "0x2011321", VA = "0x2011220")]
	private void InitParameter()
	{
	}

	// Token: 0x060049A1 RID: 18849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D93")]
	[Address(RVA = "0x2011310", Offset = "0x2011411", VA = "0x2011310")]
	public void StartMove()
	{
	}

	// Token: 0x060049A2 RID: 18850 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D94")]
	[Address(RVA = "0x2011360", Offset = "0x2011461", VA = "0x2011360")]
	private void Update()
	{
	}

	// Token: 0x060049A3 RID: 18851 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D95")]
	[Address(RVA = "0x2011450", Offset = "0x2011551", VA = "0x2011450")]
	public UIImageMove()
	{
	}

	// Token: 0x0400A96F RID: 43375
	[Token(Token = "0x4007FA4")]
	[FieldOffset(Offset = "0x18")]
	private RectTransform RectTransform;

	// Token: 0x0400A970 RID: 43376
	[Token(Token = "0x4007FA5")]
	[FieldOffset(Offset = "0x20")]
	private Vector2 startPos;

	// Token: 0x0400A971 RID: 43377
	[Token(Token = "0x4007FA6")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 endPos;

	// Token: 0x0400A972 RID: 43378
	[Token(Token = "0x4007FA7")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector2 movePos;

	// Token: 0x0400A973 RID: 43379
	[Token(Token = "0x4007FA8")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float moveTime;

	// Token: 0x0400A974 RID: 43380
	[Token(Token = "0x4007FA9")]
	[FieldOffset(Offset = "0x3C")]
	private float nowTime;

	// Token: 0x0400A975 RID: 43381
	[Token(Token = "0x4007FAA")]
	[FieldOffset(Offset = "0x40")]
	private bool IsInitedParameter;
}
