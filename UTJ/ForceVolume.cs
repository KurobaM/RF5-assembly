using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UTJ
{
	// Token: 0x02000BD6 RID: 3030
	[Token(Token = "0x20007E1")]
	public class ForceVolume : ForceProvider
	{
		// Token: 0x06004D53 RID: 19795 RVA: 0x00018A38 File Offset: 0x00016C38
		[Token(Token = "0x60040DC")]
		[Address(RVA = "0x212A9A0", Offset = "0x212AAA1", VA = "0x212A9A0", Slot = "4")]
		public override Vector3 GetForceOnBone(SpringBone springBone)
		{
			return default(Vector3);
		}

		// Token: 0x06004D54 RID: 19796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040DD")]
		[Address(RVA = "0x212AA50", Offset = "0x212AB51", VA = "0x212AA50")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06004D55 RID: 19797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040DE")]
		[Address(RVA = "0x212ADF0", Offset = "0x212AEF1", VA = "0x212ADF0")]
		public ForceVolume()
		{
		}

		// Token: 0x0400AEDF RID: 44767
		[Token(Token = "0x40083EC")]
		[FieldOffset(Offset = "0x18")]
		public float strength;
	}
}
