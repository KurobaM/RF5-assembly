using System;
using Il2CppDummyDll;

// Token: 0x020000A0 RID: 160
[Token(Token = "0x200007A")]
public abstract class MonsterActionCommandBase : ActionCommandBase
{
	// Token: 0x17000084 RID: 132
	// (get) Token: 0x0600031C RID: 796 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600031D RID: 797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000081")]
	private protected new MonsterActionScriptsController Controller
	{
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1D833D0", Offset = "0x1D834D1", VA = "0x1D833D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A0A0", Offset = "0x19A1A1")]
		protected get
		{
			return null;
		}
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1D833E0", Offset = "0x1D834E1", VA = "0x1D833E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A0B0", Offset = "0x19A1B1")]
		private set
		{
		}
	}

	// Token: 0x0600031E RID: 798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000266")]
	[Address(RVA = "0x1D833F0", Offset = "0x1D834F1", VA = "0x1D833F0")]
	public MonsterActionCommandBase(ActionCommandDataTable actionCommandData, MonsterActionScriptsController controller)
	{
	}

	// Token: 0x04000224 RID: 548
	[Token(Token = "0x40001B7")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B840", Offset = "0x15B941")]
	private MonsterActionScriptsController <Controller>k__BackingField;
}
