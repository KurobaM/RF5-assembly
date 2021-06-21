using System;
using Il2CppDummyDll;

// Token: 0x020000E3 RID: 227
[Token(Token = "0x20000B8")]
public abstract class ToolActionCommandBase : ActionCommandBase
{
	// Token: 0x170000FB RID: 251
	// (get) Token: 0x0600044D RID: 1101 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600044E RID: 1102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000F8")]
	private protected new AS_ToolController Controller
	{
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x2074C50", Offset = "0x2074D51", VA = "0x2074C50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A190", Offset = "0x19A291")]
		protected get
		{
			return null;
		}
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x2074C60", Offset = "0x2074D61", VA = "0x2074C60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A1A0", Offset = "0x19A2A1")]
		private set
		{
		}
	}

	// Token: 0x0600044F RID: 1103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038E")]
	[Address(RVA = "0x2074C70", Offset = "0x2074D71", VA = "0x2074C70")]
	public ToolActionCommandBase(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x04000269 RID: 617
	[Token(Token = "0x40001E2")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B890", Offset = "0x15B991")]
	private AS_ToolController <Controller>k__BackingField;
}
