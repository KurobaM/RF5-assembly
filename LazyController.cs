using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000206 RID: 518
[Token(Token = "0x20001A2")]
public abstract class LazyController : MonoBehaviour
{
	// Token: 0x170001EB RID: 491
	// (get) Token: 0x06000ABA RID: 2746 RVA: 0x000054C0 File Offset: 0x000036C0
	[Token(Token = "0x170001CE")]
	public bool IsLazy
	{
		[Token(Token = "0x600096A")]
		[Address(RVA = "0x230BA40", Offset = "0x230BB41", VA = "0x230BA40")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000ABB RID: 2747 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600096B")]
	[Address(RVA = "0x230BA50", Offset = "0x230BB51", VA = "0x230BA50", Slot = "4")]
	public virtual void Setup()
	{
	}

	// Token: 0x06000ABC RID: 2748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600096C")]
	[Address(RVA = "0x230BA70", Offset = "0x230BB71", VA = "0x230BA70", Slot = "5")]
	public virtual void Cleanup()
	{
	}

	// Token: 0x06000ABD RID: 2749 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600096D")]
	[Address(RVA = "0x230BA80", Offset = "0x230BB81", VA = "0x230BA80", Slot = "6")]
	public virtual void SetLazy(bool isLazy)
	{
	}

	// Token: 0x06000ABE RID: 2750 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600096E")]
	[Address(RVA = "0x230BAA0", Offset = "0x230BBA1", VA = "0x230BAA0", Slot = "7")]
	public virtual void DoUpdateEmotion()
	{
	}

	// Token: 0x06000ABF RID: 2751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600096F")]
	[Address(RVA = "0x230BAB0", Offset = "0x230BBB1", VA = "0x230BAB0")]
	protected LazyController()
	{
	}

	// Token: 0x040006AC RID: 1708
	[Token(Token = "0x4000551")]
	[FieldOffset(Offset = "0x18")]
	protected bool m_isLazy;

	// Token: 0x040006AD RID: 1709
	[Token(Token = "0x4000552")]
	[FieldOffset(Offset = "0x19")]
	protected bool m_isSetuped;
}
