using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UTJ
{
	// Token: 0x02000BD3 RID: 3027
	[Token(Token = "0x20007DF")]
	public class HighLeg : MonoBehaviour
	{
		// Token: 0x06004D4D RID: 19789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040D8")]
		[Address(RVA = "0x212BA20", Offset = "0x212BB21", VA = "0x212BA20")]
		private void LateUpdate()
		{
		}

		// Token: 0x06004D4E RID: 19790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040D9")]
		[Address(RVA = "0x212BE40", Offset = "0x212BF41", VA = "0x212BE40")]
		public HighLeg()
		{
		}

		// Token: 0x0400AEDB RID: 44763
		[Token(Token = "0x40083EA")]
		[FieldOffset(Offset = "0x18")]
		public Transform hipPivot;

		// Token: 0x0400AEDC RID: 44764
		[Token(Token = "0x40083EB")]
		[FieldOffset(Offset = "0x20")]
		public HighLeg.TransformPair[] legs;

		// Token: 0x02000BD4 RID: 3028
		[Token(Token = "0x2001374")]
		[Serializable]
		public class TransformPair
		{
			// Token: 0x06004D4F RID: 19791 RVA: 0x00018A08 File Offset: 0x00016C08
			[Token(Token = "0x6007757")]
			[Address(RVA = "0x212BD40", Offset = "0x212BE41", VA = "0x212BD40")]
			public Vector3 GetDirection()
			{
				return default(Vector3);
			}

			// Token: 0x06004D50 RID: 19792 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007758")]
			[Address(RVA = "0x212BE50", Offset = "0x212BF51", VA = "0x212BE50")]
			public TransformPair()
			{
			}

			// Token: 0x0400AEDD RID: 44765
			[Token(Token = "0x401B74A")]
			[FieldOffset(Offset = "0x10")]
			public Transform start;

			// Token: 0x0400AEDE RID: 44766
			[Token(Token = "0x401B74B")]
			[FieldOffset(Offset = "0x18")]
			public Transform end;
		}
	}
}
