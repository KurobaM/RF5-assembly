using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x020012B7 RID: 4791
	[Token(Token = "0x2000C84")]
	[Serializable]
	public class SharedTransformList : SharedVariable<List<Transform>>
	{
		// Token: 0x060071B7 RID: 29111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E6B")]
		[Address(RVA = "0x220E130", Offset = "0x220E231", VA = "0x220E130")]
		public static implicit operator SharedTransformList(List<Transform> value)
		{
			return null;
		}

		// Token: 0x060071B8 RID: 29112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E6C")]
		[Address(RVA = "0x220E1E0", Offset = "0x220E2E1", VA = "0x220E1E0")]
		public SharedTransformList()
		{
		}
	}
}
