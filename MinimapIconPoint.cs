using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009C9 RID: 2505
[Token(Token = "0x200068F")]
public class MinimapIconPoint : MonoBehaviour
{
	// Token: 0x17000913 RID: 2323
	// (get) Token: 0x0600418E RID: 16782 RVA: 0x000161E8 File Offset: 0x000143E8
	// (set) Token: 0x0600418F RID: 16783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000743")]
	public int ID
	{
		[Token(Token = "0x60036B9")]
		[Address(RVA = "0x22F6810", Offset = "0x22F6911", VA = "0x22F6810")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7500", Offset = "0x1A7601")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60036BA")]
		[Address(RVA = "0x22F6820", Offset = "0x22F6921", VA = "0x22F6820")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7510", Offset = "0x1A7611")]
		set
		{
		}
	}

	// Token: 0x06004190 RID: 16784 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60036BB")]
	[Address(RVA = "0x22F6830", Offset = "0x22F6931", VA = "0x22F6830")]
	public RectTransform getRectTrans()
	{
		return null;
	}

	// Token: 0x06004191 RID: 16785 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60036BC")]
	[Address(RVA = "0x22F6840", Offset = "0x22F6941", VA = "0x22F6840")]
	public Image getImage()
	{
		return null;
	}

	// Token: 0x06004192 RID: 16786 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036BD")]
	[Address(RVA = "0x22F6850", Offset = "0x22F6951", VA = "0x22F6850")]
	public void setScale(float scale)
	{
	}

	// Token: 0x06004193 RID: 16787 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036BE")]
	[Address(RVA = "0x22F6860", Offset = "0x22F6961", VA = "0x22F6860")]
	public MinimapIconPoint()
	{
	}

	// Token: 0x0400A071 RID: 41073
	[Token(Token = "0x400790E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform rectTransform;

	// Token: 0x0400A072 RID: 41074
	[Token(Token = "0x400790F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image image;

	// Token: 0x0400A073 RID: 41075
	[Token(Token = "0x4007910")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x170880", Offset = "0x170981")]
	private int <ID>k__BackingField;
}
