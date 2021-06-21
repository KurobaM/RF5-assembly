using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x020012BD RID: 4797
	[Token(Token = "0x2000C8A")]
	[Serializable]
	public class SharedVector4 : SharedVariable<Vector4>
	{
		// Token: 0x060071C3 RID: 29123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E77")]
		[Address(RVA = "0x220E850", Offset = "0x220E951", VA = "0x220E850")]
		public static implicit operator SharedVector4(Vector4 value)
		{
			return null;
		}

		// Token: 0x060071C4 RID: 29124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E78")]
		[Address(RVA = "0x220E910", Offset = "0x220EA11", VA = "0x220E910")]
		public SharedVector4()
		{
		}
	}
}
