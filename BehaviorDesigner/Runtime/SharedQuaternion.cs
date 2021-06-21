using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x020012B3 RID: 4787
	[Token(Token = "0x2000C80")]
	[Serializable]
	public class SharedQuaternion : SharedVariable<Quaternion>
	{
		// Token: 0x060071AF RID: 29103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E63")]
		[Address(RVA = "0x220DD10", Offset = "0x220DE11", VA = "0x220DD10")]
		public static implicit operator SharedQuaternion(Quaternion value)
		{
			return null;
		}

		// Token: 0x060071B0 RID: 29104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E64")]
		[Address(RVA = "0x220DDD0", Offset = "0x220DED1", VA = "0x220DDD0")]
		public SharedQuaternion()
		{
		}
	}
}
