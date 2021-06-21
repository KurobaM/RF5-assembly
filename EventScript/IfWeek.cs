using System;
using BinaryStream;
using Define;
using Il2CppDummyDll;

namespace EventScript
{
	// Token: 0x020010D9 RID: 4313
	[Token(Token = "0x2000AD2")]
	public class IfWeek : CommandBase
	{
		// Token: 0x06006D66 RID: 28006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AB7")]
		[Address(RVA = "0x21B7DE0", Offset = "0x21B7EE1", VA = "0x21B7DE0", Slot = "4")]
		public override void Start(BinaryReader reader, ScriptPlayer player)
		{
		}

		// Token: 0x06006D67 RID: 28007 RVA: 0x00025B48 File Offset: 0x00023D48
		[Token(Token = "0x6005AB8")]
		[Address(RVA = "0x21B7E90", Offset = "0x21B7F91", VA = "0x21B7E90")]
		private Define.DayOfWeek DayOfWeek()
		{
			return Define.DayOfWeek.HOLIDAY;
		}

		// Token: 0x06006D68 RID: 28008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AB9")]
		[Address(RVA = "0x21B7EF0", Offset = "0x21B7FF1", VA = "0x21B7EF0")]
		public IfWeek()
		{
		}
	}
}
