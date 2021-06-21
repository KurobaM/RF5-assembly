using System;
using BinaryStream;
using Il2CppDummyDll;

namespace EventScript
{
	// Token: 0x020010E2 RID: 4322
	[Token(Token = "0x2000ADA")]
	public class Wait : CommandBase
	{
		// Token: 0x06006D7A RID: 28026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AC9")]
		[Address(RVA = "0x21BA950", Offset = "0x21BAA51", VA = "0x21BA950", Slot = "4")]
		public override void Start(BinaryReader reader, ScriptPlayer player)
		{
		}

		// Token: 0x06006D7B RID: 28027 RVA: 0x00025B78 File Offset: 0x00023D78
		[Token(Token = "0x6005ACA")]
		[Address(RVA = "0x21BA990", Offset = "0x21BAA91", VA = "0x21BA990", Slot = "5")]
		public override bool Update(BinaryReader reader, ScriptPlayer player)
		{
			return default(bool);
		}

		// Token: 0x06006D7C RID: 28028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ACB")]
		[Address(RVA = "0x21BA560", Offset = "0x21BA661", VA = "0x21BA560")]
		public Wait()
		{
		}
	}
}
