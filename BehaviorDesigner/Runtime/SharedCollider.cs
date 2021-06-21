using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x020012A9 RID: 4777
	[Token(Token = "0x2000C76")]
	[Serializable]
	public class SharedCollider : SharedVariable<Collider>
	{
		// Token: 0x0600719B RID: 29083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E4F")]
		[Address(RVA = "0x220CC80", Offset = "0x220CD81", VA = "0x220CC80")]
		public static implicit operator SharedCollider(Collider value)
		{
			return null;
		}

		// Token: 0x0600719C RID: 29084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E50")]
		[Address(RVA = "0x220CD30", Offset = "0x220CE31", VA = "0x220CD30")]
		public SharedCollider()
		{
		}
	}
}
