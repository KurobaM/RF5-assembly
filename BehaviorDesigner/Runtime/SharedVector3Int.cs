using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x020012BC RID: 4796
	[Token(Token = "0x2000C89")]
	[Serializable]
	public class SharedVector3Int : SharedVariable<Vector3Int>
	{
		// Token: 0x060071C1 RID: 29121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E75")]
		[Address(RVA = "0x220E640", Offset = "0x220E741", VA = "0x220E640")]
		public static implicit operator SharedVector3Int(Vector3Int value)
		{
			return null;
		}

		// Token: 0x060071C2 RID: 29122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E76")]
		[Address(RVA = "0x220E6F0", Offset = "0x220E7F1", VA = "0x220E6F0")]
		public SharedVector3Int()
		{
		}
	}
}
