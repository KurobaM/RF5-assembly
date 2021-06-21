using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x0200129B RID: 4763
	[Token(Token = "0x2000C68")]
	[Serializable]
	public class SharedAIInput : SharedVariable<AIInput>
	{
		// Token: 0x06007181 RID: 29057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E35")]
		[Address(RVA = "0x220C760", Offset = "0x220C861", VA = "0x220C760")]
		public static implicit operator SharedAIInput(AIInput value)
		{
			return null;
		}

		// Token: 0x06007182 RID: 29058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E36")]
		[Address(RVA = "0x220C820", Offset = "0x220C921", VA = "0x220C820")]
		public SharedAIInput()
		{
		}
	}
}
