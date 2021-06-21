using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x020012A3 RID: 4771
	[Token(Token = "0x2000C70")]
	[Serializable]
	public class SharedVector3List : SharedVariable<List<Vector3>>
	{
		// Token: 0x06007191 RID: 29073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E45")]
		[Address(RVA = "0x220E740", Offset = "0x220E841", VA = "0x220E740")]
		public static implicit operator SharedVector3List(List<Vector3> value)
		{
			return null;
		}

		// Token: 0x06007192 RID: 29074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E46")]
		[Address(RVA = "0x220E800", Offset = "0x220E901", VA = "0x220E800")]
		public SharedVector3List()
		{
		}
	}
}
