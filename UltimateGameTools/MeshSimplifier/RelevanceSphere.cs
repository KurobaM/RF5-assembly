using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UltimateGameTools.MeshSimplifier
{
	// Token: 0x02000C2E RID: 3118
	[Token(Token = "0x20007F9")]
	[Serializable]
	public class RelevanceSphere
	{
		// Token: 0x06004F22 RID: 20258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041B2")]
		[Address(RVA = "0x20FE810", Offset = "0x20FE911", VA = "0x20FE810")]
		public RelevanceSphere()
		{
		}

		// Token: 0x06004F23 RID: 20259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041B3")]
		[Address(RVA = "0x20FE890", Offset = "0x20FE991", VA = "0x20FE890")]
		public void SetDefault(Transform target, float fRelevance)
		{
		}

		// Token: 0x0400AFEC RID: 45036
		[Token(Token = "0x4008436")]
		[FieldOffset(Offset = "0x10")]
		public bool m_bExpanded;

		// Token: 0x0400AFED RID: 45037
		[Token(Token = "0x4008437")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 m_v3Position;

		// Token: 0x0400AFEE RID: 45038
		[Token(Token = "0x4008438")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 m_v3Rotation;

		// Token: 0x0400AFEF RID: 45039
		[Token(Token = "0x4008439")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 m_v3Scale;

		// Token: 0x0400AFF0 RID: 45040
		[Token(Token = "0x400843A")]
		[FieldOffset(Offset = "0x38")]
		public float m_fRelevance;
	}
}
