using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x020012BB RID: 4795
	[Token(Token = "0x2000C88")]
	[Serializable]
	public class SharedVector3 : SharedVariable<Vector3>
	{
		// Token: 0x060071BF RID: 29119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E73")]
		[Address(RVA = "0x220E530", Offset = "0x220E631", VA = "0x220E530")]
		public static implicit operator SharedVector3(Vector3 value)
		{
			return null;
		}

		// Token: 0x060071C0 RID: 29120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E74")]
		[Address(RVA = "0x220E5F0", Offset = "0x220E6F1", VA = "0x220E5F0")]
		public SharedVector3()
		{
		}
	}
}
