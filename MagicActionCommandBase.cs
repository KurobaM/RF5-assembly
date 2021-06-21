using System;
using Il2CppDummyDll;

// Token: 0x02000097 RID: 151
[Token(Token = "0x2000074")]
public abstract class MagicActionCommandBase : ActionCommandBase
{
	// Token: 0x17000074 RID: 116
	// (get) Token: 0x060002EB RID: 747 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060002EC RID: 748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000071")]
	private protected new AS_MagicController Controller
	{
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1F119E0", Offset = "0x1F11AE1", VA = "0x1F119E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A040", Offset = "0x19A141")]
		protected get
		{
			return null;
		}
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1F119F0", Offset = "0x1F11AF1", VA = "0x1F119F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A050", Offset = "0x19A151")]
		private set
		{
		}
	}

	// Token: 0x060002ED RID: 749 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600023C")]
	[Address(RVA = "0x1F11A00", Offset = "0x1F11B01", VA = "0x1F11A00")]
	public MagicActionCommandBase(ActionCommandDataTable actionCommandData, AS_MagicController controller)
	{
	}

	// Token: 0x04000214 RID: 532
	[Token(Token = "0x40001A8")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B810", Offset = "0x15B911")]
	private AS_MagicController <Controller>k__BackingField;
}
