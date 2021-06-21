using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x020012B4 RID: 4788
	[Token(Token = "0x2000C81")]
	[Serializable]
	public class SharedRect : SharedVariable<Rect>
	{
		// Token: 0x060071B1 RID: 29105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E65")]
		[Address(RVA = "0x220DE20", Offset = "0x220DF21", VA = "0x220DE20")]
		public static implicit operator SharedRect(Rect value)
		{
			return null;
		}

		// Token: 0x060071B2 RID: 29106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E66")]
		[Address(RVA = "0x220DEE0", Offset = "0x220DFE1", VA = "0x220DEE0")]
		public SharedRect()
		{
		}
	}
}
