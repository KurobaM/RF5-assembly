using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000266 RID: 614
[Token(Token = "0x20001E8")]
public abstract class InteractionColliderBase : MonoBehaviour
{
	// Token: 0x170002D9 RID: 729
	// (get) Token: 0x06000F29 RID: 3881 RVA: 0x00006C30 File Offset: 0x00004E30
	[Token(Token = "0x170002AF")]
	public Vector3 Center
	{
		[Token(Token = "0x6000DA4")]
		[Address(RVA = "0x22333D0", Offset = "0x22334D1", VA = "0x22333D0")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x06000F2A RID: 3882 RVA: 0x00006C48 File Offset: 0x00004E48
	[Token(Token = "0x6000DA5")]
	[Address(RVA = "0x22334A0", Offset = "0x22335A1", VA = "0x22334A0")]
	protected bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return default(bool);
	}

	// Token: 0x06000F2B RID: 3883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DA6")]
	[Address(RVA = "0x2234840", Offset = "0x2234941", VA = "0x2234840")]
	protected InteractionColliderBase()
	{
	}

	// Token: 0x040008C0 RID: 2240
	[Token(Token = "0x40006EE")]
	protected const int ResultMaxCount = 512;

	// Token: 0x040008C1 RID: 2241
	[Token(Token = "0x40006EF")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected LayerMask m_LayerMask;

	// Token: 0x040008C2 RID: 2242
	[Token(Token = "0x40006F0")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	protected float m_Radius;

	// Token: 0x040008C3 RID: 2243
	[Token(Token = "0x40006F1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected Vector3 m_Center;

	// Token: 0x040008C4 RID: 2244
	[Token(Token = "0x40006F2")]
	[FieldOffset(Offset = "0x0")]
	protected static Collider[] m_Results;

	// Token: 0x040008C5 RID: 2245
	[Token(Token = "0x40006F3")]
	[FieldOffset(Offset = "0x8")]
	protected static List<Collider> m_DeleteList;

	// Token: 0x040008C6 RID: 2246
	[Token(Token = "0x40006F4")]
	[FieldOffset(Offset = "0x30")]
	protected List<Collider> m_EntryList;
}
