using System;
using Il2CppDummyDll;
using RF5Input;
using UnityEngine;

// Token: 0x0200093B RID: 2363
[Token(Token = "0x200062F")]
public class ButtonWorkBase : MonoBehaviour
{
	// Token: 0x170008C8 RID: 2248
	// (get) Token: 0x06003E78 RID: 15992 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003E79 RID: 15993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000707")]
	private protected CursorLinker CursorLinker
	{
		[Token(Token = "0x60033EB")]
		[Address(RVA = "0x219BE50", Offset = "0x219BF51", VA = "0x219BE50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6D00", Offset = "0x1A6E01")]
		protected get
		{
			return null;
		}
		[Token(Token = "0x60033EC")]
		[Address(RVA = "0x219BE60", Offset = "0x219BF61", VA = "0x219BE60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6D10", Offset = "0x1A6E11")]
		private set
		{
		}
	}

	// Token: 0x06003E7A RID: 15994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033ED")]
	[Address(RVA = "0x219BE70", Offset = "0x219BF71", VA = "0x219BE70")]
	private void Awake()
	{
	}

	// Token: 0x06003E7B RID: 15995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033EE")]
	[Address(RVA = "0x219BF40", Offset = "0x219C041", VA = "0x219BF40")]
	private void Start()
	{
	}

	// Token: 0x170008C9 RID: 2249
	// (get) Token: 0x06003E7C RID: 15996 RVA: 0x00015528 File Offset: 0x00013728
	[Token(Token = "0x17000708")]
	public virtual bool UseCANCEL
	{
		[Token(Token = "0x60033EF")]
		[Address(RVA = "0x219BFB0", Offset = "0x219C0B1", VA = "0x219BFB0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06003E7D RID: 15997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033F0")]
	[Address(RVA = "0x219BFC0", Offset = "0x219C0C1", VA = "0x219BFC0", Slot = "5")]
	public virtual void ButtonWork(Key btnType)
	{
	}

	// Token: 0x06003E7E RID: 15998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033F1")]
	[Address(RVA = "0x219BFD0", Offset = "0x219C0D1", VA = "0x219BFD0", Slot = "6")]
	public virtual void OnFocusingUpdate()
	{
	}

	// Token: 0x06003E7F RID: 15999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033F2")]
	[Address(RVA = "0x219BFE0", Offset = "0x219C0E1", VA = "0x219BFE0", Slot = "7")]
	public virtual void OnFocus()
	{
	}

	// Token: 0x06003E80 RID: 16000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033F3")]
	[Address(RVA = "0x219BFF0", Offset = "0x219C0F1", VA = "0x219BFF0", Slot = "8")]
	public virtual void EndFocus()
	{
	}

	// Token: 0x06003E81 RID: 16001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033F4")]
	[Address(RVA = "0x219C000", Offset = "0x219C101", VA = "0x219C000")]
	public ButtonWorkBase()
	{
	}

	// Token: 0x04008038 RID: 32824
	[Token(Token = "0x400738C")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F420", Offset = "0x16F521")]
	private CursorLinker <CursorLinker>k__BackingField;
}
