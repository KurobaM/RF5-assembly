using System;
using Il2CppDummyDll;

// Token: 0x0200031D RID: 797
[Token(Token = "0x2000258")]
public struct TransitionTables
{
	// Token: 0x170003C2 RID: 962
	// (get) Token: 0x06001532 RID: 5426 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001533 RID: 5427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000372")]
	public Enum CurrentState
	{
		[Token(Token = "0x60012F0")]
		[Address(RVA = "0x2DF700", Offset = "0x2DF801", VA = "0x2DF700")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D1F0", Offset = "0x19D2F1")]
		get
		{
			return null;
		}
		[Token(Token = "0x60012F1")]
		[Address(RVA = "0x2DF710", Offset = "0x2DF811", VA = "0x2DF710")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D200", Offset = "0x19D301")]
		private set
		{
		}
	}

	// Token: 0x170003C3 RID: 963
	// (get) Token: 0x06001534 RID: 5428 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001535 RID: 5429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000373")]
	public Enum NextState
	{
		[Token(Token = "0x60012F2")]
		[Address(RVA = "0x2DF720", Offset = "0x2DF821", VA = "0x2DF720")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D210", Offset = "0x19D311")]
		get
		{
			return null;
		}
		[Token(Token = "0x60012F3")]
		[Address(RVA = "0x2DF730", Offset = "0x2DF831", VA = "0x2DF730")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D220", Offset = "0x19D321")]
		private set
		{
		}
	}

	// Token: 0x170003C4 RID: 964
	// (get) Token: 0x06001536 RID: 5430 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001537 RID: 5431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000374")]
	public Enum Command
	{
		[Token(Token = "0x60012F4")]
		[Address(RVA = "0x2DF740", Offset = "0x2DF841", VA = "0x2DF740")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D230", Offset = "0x19D331")]
		get
		{
			return null;
		}
		[Token(Token = "0x60012F5")]
		[Address(RVA = "0x2DF750", Offset = "0x2DF851", VA = "0x2DF750")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D240", Offset = "0x19D341")]
		private set
		{
		}
	}

	// Token: 0x170003C5 RID: 965
	// (get) Token: 0x06001538 RID: 5432 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001539 RID: 5433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000375")]
	public Func<bool> Condition
	{
		[Token(Token = "0x60012F6")]
		[Address(RVA = "0x2DF760", Offset = "0x2DF861", VA = "0x2DF760")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D250", Offset = "0x19D351")]
		get
		{
			return null;
		}
		[Token(Token = "0x60012F7")]
		[Address(RVA = "0x2DF770", Offset = "0x2DF871", VA = "0x2DF770")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D260", Offset = "0x19D361")]
		private set
		{
		}
	}

	// Token: 0x0600153A RID: 5434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012F8")]
	[Address(RVA = "0x2DF780", Offset = "0x2DF881", VA = "0x2DF780")]
	public TransitionTables(Enum CurrentState, Enum NextState, Enum Command, Func<bool> Condition)
	{
	}

	// Token: 0x04000C3C RID: 3132
	[Token(Token = "0x4000951")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F820", Offset = "0x15F921")]
	private Enum <CurrentState>k__BackingField;

	// Token: 0x04000C3D RID: 3133
	[Token(Token = "0x4000952")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F830", Offset = "0x15F931")]
	private Enum <NextState>k__BackingField;

	// Token: 0x04000C3E RID: 3134
	[Token(Token = "0x4000953")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F840", Offset = "0x15F941")]
	private Enum <Command>k__BackingField;

	// Token: 0x04000C3F RID: 3135
	[Token(Token = "0x4000954")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F850", Offset = "0x15F951")]
	private Func<bool> <Condition>k__BackingField;
}
