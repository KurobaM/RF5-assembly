using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000250 RID: 592
[Token(Token = "0x20001DC")]
public class HumanRideSaddle : MonoBehaviour
{
	// Token: 0x06000E69 RID: 3689 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D00")]
	[Address(RVA = "0x2228140", Offset = "0x2228241", VA = "0x2228140")]
	public Transform GetAttachPoint(HumanRideSaddle.RidePointType type)
	{
		return null;
	}

	// Token: 0x06000E6A RID: 3690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D01")]
	[Address(RVA = "0x22281D0", Offset = "0x22282D1", VA = "0x22281D0")]
	public HumanRideSaddle()
	{
	}

	// Token: 0x0400084A RID: 2122
	[Token(Token = "0x40006B1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<Transform> m_AttachPoint;

	// Token: 0x0400084B RID: 2123
	[Token(Token = "0x40006B2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public List<DynamicBoneColliderBase> m_Colliders;

	// Token: 0x02000251 RID: 593
	[Token(Token = "0x2000FFD")]
	public enum RidePointType
	{
		// Token: 0x0400084D RID: 2125
		[Token(Token = "0x4018E0D")]
		Player,
		// Token: 0x0400084E RID: 2126
		[Token(Token = "0x4018E0E")]
		Partner
	}
}
