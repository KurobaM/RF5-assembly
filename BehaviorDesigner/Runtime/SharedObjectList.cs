using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x020012B2 RID: 4786
	[Token(Token = "0x2000C7F")]
	[Serializable]
	public class SharedObjectList : SharedVariable<List<UnityEngine.Object>>
	{
		// Token: 0x060071AD RID: 29101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E61")]
		[Address(RVA = "0x220DB00", Offset = "0x220DC01", VA = "0x220DB00")]
		public static implicit operator SharedObjectList(List<UnityEngine.Object> value)
		{
			return null;
		}

		// Token: 0x060071AE RID: 29102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E62")]
		[Address(RVA = "0x220DBB0", Offset = "0x220DCB1", VA = "0x220DBB0")]
		public SharedObjectList()
		{
		}
	}
}
