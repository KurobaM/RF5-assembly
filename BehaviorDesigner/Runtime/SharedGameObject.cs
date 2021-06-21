using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x020012AC RID: 4780
	[Token(Token = "0x2000C79")]
	[Serializable]
	public class SharedGameObject : SharedVariable<GameObject>
	{
		// Token: 0x060071A1 RID: 29089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E55")]
		[Address(RVA = "0x220D0B0", Offset = "0x220D1B1", VA = "0x220D0B0")]
		public static implicit operator SharedGameObject(GameObject value)
		{
			return null;
		}

		// Token: 0x060071A2 RID: 29090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E56")]
		[Address(RVA = "0x220D160", Offset = "0x220D261", VA = "0x220D160")]
		public SharedGameObject()
		{
		}
	}
}
