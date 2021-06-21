using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000552 RID: 1362
[Token(Token = "0x20003DC")]
public class ObjectCullingGroup : MonoBehaviour
{
	// Token: 0x06002109 RID: 8457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C0E")]
	[Address(RVA = "0x1F559D0", Offset = "0x1F55AD1", VA = "0x1F559D0")]
	private void Awake()
	{
	}

	// Token: 0x0600210A RID: 8458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C0F")]
	[Address(RVA = "0x1F55A30", Offset = "0x1F55B31", VA = "0x1F55A30")]
	private void Start()
	{
	}

	// Token: 0x0600210B RID: 8459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C10")]
	[Address(RVA = "0x1F55C60", Offset = "0x1F55D61", VA = "0x1F55C60")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600210C RID: 8460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C11")]
	[Address(RVA = "0x1F55D70", Offset = "0x1F55E71", VA = "0x1F55D70")]
	private void OnChange(CullingGroupEvent ev)
	{
	}

	// Token: 0x0600210D RID: 8461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C12")]
	[Address(RVA = "0x1F55E80", Offset = "0x1F55F81", VA = "0x1F55E80")]
	public ObjectCullingGroup()
	{
	}

	// Token: 0x040067C9 RID: 26569
	[Token(Token = "0x40061B1")]
	[FieldOffset(Offset = "0x18")]
	private CullingGroup CullingGroup;

	// Token: 0x040067CA RID: 26570
	[Token(Token = "0x40061B2")]
	[FieldOffset(Offset = "0x20")]
	private BoundingSphere[] Bounds;

	// Token: 0x040067CB RID: 26571
	[Token(Token = "0x40061B3")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform[] Targets;

	// Token: 0x040067CC RID: 26572
	[Token(Token = "0x40061B4")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float[] BoundingDistances;

	// Token: 0x040067CD RID: 26573
	[Token(Token = "0x40061B5")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float BoundingRadius;

	// Token: 0x040067CE RID: 26574
	[Token(Token = "0x40061B6")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private bool UseIsVisible;
}
