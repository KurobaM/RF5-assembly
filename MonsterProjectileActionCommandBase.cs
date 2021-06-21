using System;
using Il2CppDummyDll;

// Token: 0x020000AB RID: 171
[Token(Token = "0x2000084")]
public abstract class MonsterProjectileActionCommandBase : ActionCommandBase
{
	// Token: 0x17000091 RID: 145
	// (get) Token: 0x06000356 RID: 854 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000357 RID: 855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700008E")]
	private protected new MonsterProjectileActionScriptsController Controller
	{
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1E6E9C0", Offset = "0x1E6EAC1", VA = "0x1E6E9C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A0C0", Offset = "0x19A1C1")]
		protected get
		{
			return null;
		}
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1E6E9D0", Offset = "0x1E6EAD1", VA = "0x1E6E9D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A0D0", Offset = "0x19A1D1")]
		private set
		{
		}
	}

	// Token: 0x06000358 RID: 856 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029E")]
	[Address(RVA = "0x1E6E9E0", Offset = "0x1E6EAE1", VA = "0x1E6E9E0")]
	public MonsterProjectileActionCommandBase(ActionCommandDataTable actionCommandData, MonsterProjectileActionScriptsController controller)
	{
	}

	// Token: 0x0400022B RID: 555
	[Token(Token = "0x40001BD")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B860", Offset = "0x15B961")]
	private MonsterProjectileActionScriptsController <Controller>k__BackingField;
}
