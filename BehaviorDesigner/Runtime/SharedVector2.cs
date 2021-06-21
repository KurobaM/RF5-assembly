using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x020012B9 RID: 4793
	[Token(Token = "0x2000C86")]
	[Serializable]
	public class SharedVector2 : SharedVariable<Vector2>
	{
		// Token: 0x060071BB RID: 29115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E6F")]
		[Address(RVA = "0x220E330", Offset = "0x220E431", VA = "0x220E330")]
		public static implicit operator SharedVector2(Vector2 value)
		{
			return null;
		}

		// Token: 0x060071BC RID: 29116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E70")]
		[Address(RVA = "0x220E3E0", Offset = "0x220E4E1", VA = "0x220E3E0")]
		public SharedVector2()
		{
		}
	}
}
