using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x020012AB RID: 4779
	[Token(Token = "0x2000C78")]
	[Serializable]
	public class SharedFloat : SharedVariable<float>
	{
		// Token: 0x0600719F RID: 29087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E53")]
		[Address(RVA = "0x220CFA0", Offset = "0x220D0A1", VA = "0x220CFA0")]
		public static implicit operator SharedFloat(float value)
		{
			return null;
		}

		// Token: 0x060071A0 RID: 29088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E54")]
		[Address(RVA = "0x220D060", Offset = "0x220D161", VA = "0x220D060")]
		public SharedFloat()
		{
		}
	}
}
