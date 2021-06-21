using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	// Token: 0x020012A6 RID: 4774
	[Token(Token = "0x2000C73")]
	[Serializable]
	public class SharedAnimationCurve : SharedVariable<AnimationCurve>
	{
		// Token: 0x06007195 RID: 29077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E49")]
		[Address(RVA = "0x220C870", Offset = "0x220C971", VA = "0x220C870")]
		public static implicit operator SharedAnimationCurve(AnimationCurve value)
		{
			return null;
		}

		// Token: 0x06007196 RID: 29078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E4A")]
		[Address(RVA = "0x220C920", Offset = "0x220CA21", VA = "0x220C920")]
		public SharedAnimationCurve()
		{
		}
	}
}
