using System;
using Il2CppDummyDll;

// Token: 0x02000098 RID: 152
[Token(Token = "0x2000075")]
public abstract class MonsterActionBaseCommandBase : ActionCommandBase
{
	// Token: 0x17000075 RID: 117
	// (get) Token: 0x060002EE RID: 750 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060002EF RID: 751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000072")]
	private protected new MonsterActionScriptsControllerBase Controller
	{
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1D80AD0", Offset = "0x1D80BD1", VA = "0x1D80AD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A060", Offset = "0x19A161")]
		protected get
		{
			return null;
		}
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1D80AE0", Offset = "0x1D80BE1", VA = "0x1D80AE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A070", Offset = "0x19A171")]
		private set
		{
		}
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600023F")]
	[Address(RVA = "0x1D80AF0", Offset = "0x1D80BF1", VA = "0x1D80AF0")]
	public MonsterActionBaseCommandBase(ActionCommandDataTable actionCommandData, MonsterActionScriptsControllerBase controller)
	{
	}

	// Token: 0x04000215 RID: 533
	[Token(Token = "0x40001A9")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B820", Offset = "0x15B921")]
	private MonsterActionScriptsControllerBase <Controller>k__BackingField;
}
