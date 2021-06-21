using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200031E RID: 798
[Token(Token = "0x2000259")]
public class StateElement
{
	// Token: 0x170003C6 RID: 966
	// (get) Token: 0x0600153B RID: 5435 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600153C RID: 5436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000376")]
	public object State
	{
		[Token(Token = "0x60012F9")]
		[Address(RVA = "0x2388A10", Offset = "0x2388B11", VA = "0x2388A10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D270", Offset = "0x19D371")]
		get
		{
			return null;
		}
		[Token(Token = "0x60012FA")]
		[Address(RVA = "0x2388A20", Offset = "0x2388B21", VA = "0x2388A20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D280", Offset = "0x19D381")]
		private set
		{
		}
	}

	// Token: 0x170003C7 RID: 967
	// (get) Token: 0x0600153D RID: 5437 RVA: 0x00009480 File Offset: 0x00007680
	[Token(Token = "0x17000377")]
	public bool hasEnterRoutine
	{
		[Token(Token = "0x60012FB")]
		[Address(RVA = "0x2388A30", Offset = "0x2388B31", VA = "0x2388A30")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170003C8 RID: 968
	// (get) Token: 0x0600153E RID: 5438 RVA: 0x00009498 File Offset: 0x00007698
	[Token(Token = "0x17000378")]
	public bool hasExitRoutine
	{
		[Token(Token = "0x60012FC")]
		[Address(RVA = "0x2388AC0", Offset = "0x2388BC1", VA = "0x2388AC0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600153F RID: 5439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012FD")]
	[Address(RVA = "0x2388B50", Offset = "0x2388C51", VA = "0x2388B50")]
	public StateElement(object state)
	{
	}

	// Token: 0x04000C40 RID: 3136
	[Token(Token = "0x4000955")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F860", Offset = "0x15F961")]
	private object <State>k__BackingField;

	// Token: 0x04000C41 RID: 3137
	[Token(Token = "0x4000956")]
	[FieldOffset(Offset = "0x18")]
	public Action EnterCall;

	// Token: 0x04000C42 RID: 3138
	[Token(Token = "0x4000957")]
	[FieldOffset(Offset = "0x20")]
	public Func<IEnumerator> EnterRoutine;

	// Token: 0x04000C43 RID: 3139
	[Token(Token = "0x4000958")]
	[FieldOffset(Offset = "0x28")]
	public Action ExitCall;

	// Token: 0x04000C44 RID: 3140
	[Token(Token = "0x4000959")]
	[FieldOffset(Offset = "0x30")]
	public Func<IEnumerator> ExitRoutine;

	// Token: 0x04000C45 RID: 3141
	[Token(Token = "0x400095A")]
	[FieldOffset(Offset = "0x38")]
	public Action Finally;

	// Token: 0x04000C46 RID: 3142
	[Token(Token = "0x400095B")]
	[FieldOffset(Offset = "0x40")]
	public Action Update;

	// Token: 0x04000C47 RID: 3143
	[Token(Token = "0x400095C")]
	[FieldOffset(Offset = "0x48")]
	public Action LateUpdate;

	// Token: 0x04000C48 RID: 3144
	[Token(Token = "0x400095D")]
	[FieldOffset(Offset = "0x50")]
	public Action FixedUpdate;

	// Token: 0x04000C49 RID: 3145
	[Token(Token = "0x400095E")]
	[FieldOffset(Offset = "0x58")]
	public Action<Collision> OnCollisionEnter;

	// Token: 0x04000C4A RID: 3146
	[Token(Token = "0x400095F")]
	[FieldOffset(Offset = "0x60")]
	public Dictionary<Enum, TransitionTables> TransitionMapping;
}
