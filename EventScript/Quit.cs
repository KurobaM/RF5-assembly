using System;
using BinaryStream;
using Il2CppDummyDll;

namespace EventScript
{
	// Token: 0x020010DE RID: 4318
	[Token(Token = "0x2000AD6")]
	public class Quit : CommandBase
	{
		// Token: 0x06006D72 RID: 28018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AC1")]
		[Address(RVA = "0x21B9EB0", Offset = "0x21B9FB1", VA = "0x21B9EB0", Slot = "4")]
		public override void Start(BinaryReader reader, ScriptPlayer player)
		{
		}

		// Token: 0x06006D73 RID: 28019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AC2")]
		[Address(RVA = "0x21B9ED0", Offset = "0x21B9FD1", VA = "0x21B9ED0")]
		public Quit()
		{
		}
	}
}
