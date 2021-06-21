using System;
using BinaryStream;
using Il2CppDummyDll;

namespace EventScript
{
	// Token: 0x020010D0 RID: 4304
	[Token(Token = "0x2000AC9")]
	public class CommandBase
	{
		// Token: 0x06006D53 RID: 27987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA4")]
		[Address(RVA = "0x21B7660", Offset = "0x21B7761", VA = "0x21B7660", Slot = "4")]
		public virtual void Start(BinaryReader reader, ScriptPlayer player)
		{
		}

		// Token: 0x06006D54 RID: 27988 RVA: 0x00025B30 File Offset: 0x00023D30
		[Token(Token = "0x6005AA5")]
		[Address(RVA = "0x21B7670", Offset = "0x21B7771", VA = "0x21B7670", Slot = "5")]
		public virtual bool Update(BinaryReader reader, ScriptPlayer player)
		{
			return default(bool);
		}

		// Token: 0x06006D55 RID: 27989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA6")]
		[Address(RVA = "0x21B7680", Offset = "0x21B7781", VA = "0x21B7680")]
		public CommandBase()
		{
		}
	}
}
