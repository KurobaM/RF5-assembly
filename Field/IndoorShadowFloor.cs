using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x020010FE RID: 4350
	[Token(Token = "0x2000AF3")]
	public class IndoorShadowFloor : MonoBehaviour
	{
		// Token: 0x06006DF4 RID: 28148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B3D")]
		[Address(RVA = "0x20286D0", Offset = "0x20287D1", VA = "0x20286D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006DF5 RID: 28149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B3E")]
		[Address(RVA = "0x20288B0", Offset = "0x20289B1", VA = "0x20288B0")]
		private void Awake()
		{
		}

		// Token: 0x06006DF6 RID: 28150 RVA: 0x00025E00 File Offset: 0x00024000
		[Token(Token = "0x6005B3F")]
		[Address(RVA = "0x20289F0", Offset = "0x2028AF1", VA = "0x20289F0")]
		public int GetFloorIndex(float height)
		{
			return 0;
		}

		// Token: 0x06006DF7 RID: 28151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B40")]
		[Address(RVA = "0x2028A60", Offset = "0x2028B61", VA = "0x2028A60")]
		public IndoorShadowFloor()
		{
		}

		// Token: 0x040180C1 RID: 98497
		[Token(Token = "0x4014BA1")]
		[FieldOffset(Offset = "0x18")]
		public float[] FloorHeight;

		// Token: 0x040180C2 RID: 98498
		[Token(Token = "0x4014BA2")]
		[FieldOffset(Offset = "0x20")]
		public FieldSceneId SceneId;

		// Token: 0x040180C3 RID: 98499
		[Token(Token = "0x4014BA3")]
		private const float HeightTolerance = 0.05f;
	}
}
