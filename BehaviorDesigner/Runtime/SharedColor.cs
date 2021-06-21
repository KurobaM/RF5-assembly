using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x020012AA RID: 4778
	[Token(Token = "0x2000C77")]
	[Serializable]
	public class SharedColor : SharedVariable<Color>
	{
		// Token: 0x0600719D RID: 29085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E51")]
		[Address(RVA = "0x220CD80", Offset = "0x220CE81", VA = "0x220CD80")]
		public static implicit operator SharedColor(Color value)
		{
			return null;
		}

		// Token: 0x0600719E RID: 29086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E52")]
		[Address(RVA = "0x220CE40", Offset = "0x220CF41", VA = "0x220CE40")]
		public SharedColor()
		{
		}
	}
}
