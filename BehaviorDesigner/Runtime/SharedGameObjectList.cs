using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x020012AD RID: 4781
	[Token(Token = "0x2000C7A")]
	[Serializable]
	public class SharedGameObjectList : SharedVariable<List<GameObject>>
	{
		// Token: 0x060071A3 RID: 29091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E57")]
		[Address(RVA = "0x220D1B0", Offset = "0x220D2B1", VA = "0x220D1B0")]
		public static implicit operator SharedGameObjectList(List<GameObject> value)
		{
			return null;
		}

		// Token: 0x060071A4 RID: 29092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E58")]
		[Address(RVA = "0x220D260", Offset = "0x220D361", VA = "0x220D260")]
		public SharedGameObjectList()
		{
		}
	}
}
