using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x020012B6 RID: 4790
	[Token(Token = "0x2000C83")]
	[Serializable]
	public class SharedTransform : SharedVariable<Transform>
	{
		// Token: 0x060071B5 RID: 29109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E69")]
		[Address(RVA = "0x220E030", Offset = "0x220E131", VA = "0x220E030")]
		public static implicit operator SharedTransform(Transform value)
		{
			return null;
		}

		// Token: 0x060071B6 RID: 29110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E6A")]
		[Address(RVA = "0x220E0E0", Offset = "0x220E1E1", VA = "0x220E0E0")]
		public SharedTransform()
		{
		}
	}
}
