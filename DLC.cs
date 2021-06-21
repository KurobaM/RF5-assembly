using System;
using System.Collections;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000332 RID: 818
[Token(Token = "0x2000265")]
public abstract class DLC
{
	// Token: 0x170003FB RID: 1019
	// (get) Token: 0x0600160C RID: 5644 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600160D RID: 5645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000395")]
	public List<DLCID> OnFlags
	{
		[Token(Token = "0x600138E")]
		[Address(RVA = "0x1D9D390", Offset = "0x1D9D491", VA = "0x1D9D390")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D2B0", Offset = "0x19D3B1")]
		get
		{
			return null;
		}
		[Token(Token = "0x600138F")]
		[Address(RVA = "0x1D9D3A0", Offset = "0x1D9D4A1", VA = "0x1D9D3A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D2C0", Offset = "0x19D3C1")]
		protected set
		{
		}
	}

	// Token: 0x170003FC RID: 1020
	// (get) Token: 0x0600160E RID: 5646 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600160F RID: 5647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000396")]
	protected Action<DLCID[]> OnComplete
	{
		[Token(Token = "0x6001390")]
		[Address(RVA = "0x1D9D3B0", Offset = "0x1D9D4B1", VA = "0x1D9D3B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D2D0", Offset = "0x19D3D1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001391")]
		[Address(RVA = "0x1D9D3C0", Offset = "0x1D9D4C1", VA = "0x1D9D3C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D2E0", Offset = "0x19D3E1")]
		set
		{
		}
	}

	// Token: 0x170003FD RID: 1021
	// (get) Token: 0x06001610 RID: 5648 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001611 RID: 5649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000397")]
	protected static DLCDataTable DLCDataTable
	{
		[Token(Token = "0x6001392")]
		[Address(RVA = "0x1D9D3D0", Offset = "0x1D9D4D1", VA = "0x1D9D3D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D2F0", Offset = "0x19D3F1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001393")]
		[Address(RVA = "0x1D9D440", Offset = "0x1D9D541", VA = "0x1D9D440")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D300", Offset = "0x19D401")]
		set
		{
		}
	}

	// Token: 0x06001612 RID: 5650 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001394")]
	[Address(RVA = "0x1D9D4B0", Offset = "0x1D9D5B1", VA = "0x1D9D4B0")]
	public static DLC Create()
	{
		return null;
	}

	// Token: 0x06001613 RID: 5651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001395")]
	[Address(RVA = "0x1D9D9D0", Offset = "0x1D9DAD1", VA = "0x1D9D9D0")]
	protected DLC()
	{
	}

	// Token: 0x06001614 RID: 5652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001396")]
	[Address(RVA = "0x1D9DA70", Offset = "0x1D9DB71", VA = "0x1D9DA70", Slot = "4")]
	public virtual void Destroy()
	{
	}

	// Token: 0x06001615 RID: 5653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001397")]
	[Address(RVA = "0x1D9DB20", Offset = "0x1D9DC21", VA = "0x1D9DB20", Slot = "5")]
	public virtual void CheckContents(Action<DLCID[]> onComplete)
	{
	}

	// Token: 0x06001616 RID: 5654
	[Token(Token = "0x6001398")]
	public abstract IEnumerator Update();

	// Token: 0x04000CB7 RID: 3255
	[Token(Token = "0x40009A3")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F8A0", Offset = "0x15F9A1")]
	private List<DLCID> <OnFlags>k__BackingField;

	// Token: 0x04000CB8 RID: 3256
	[Token(Token = "0x40009A4")]
	[FieldOffset(Offset = "0x18")]
	protected Coroutine UpdateCoroutine;

	// Token: 0x04000CB9 RID: 3257
	[Token(Token = "0x40009A5")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F8B0", Offset = "0x15F9B1")]
	private Action<DLCID[]> <OnComplete>k__BackingField;

	// Token: 0x04000CBA RID: 3258
	[Token(Token = "0x40009A6")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F8C0", Offset = "0x15F9C1")]
	private static DLCDataTable <DLCDataTable>k__BackingField;
}
