using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x020012BA RID: 4794
	[Token(Token = "0x2000C87")]
	[Serializable]
	public class SharedVector2Int : SharedVariable<Vector2Int>
	{
		// Token: 0x060071BD RID: 29117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E71")]
		[Address(RVA = "0x220E430", Offset = "0x220E531", VA = "0x220E430")]
		public static implicit operator SharedVector2Int(Vector2Int value)
		{
			return null;
		}

		// Token: 0x060071BE RID: 29118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E72")]
		[Address(RVA = "0x220E4E0", Offset = "0x220E5E1", VA = "0x220E4E0")]
		public SharedVector2Int()
		{
		}
	}
}
