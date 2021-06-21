using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002DB RID: 731
[Token(Token = "0x200023B")]
[Serializable]
public class Restraint
{
	// Token: 0x17000379 RID: 889
	// (get) Token: 0x06001381 RID: 4993 RVA: 0x00008D30 File Offset: 0x00006F30
	[Token(Token = "0x17000341")]
	public bool IsAttached
	{
		[Token(Token = "0x60011B8")]
		[Address(RVA = "0x248C260", Offset = "0x248C361", VA = "0x248C260")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001382 RID: 4994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B9")]
	[Address(RVA = "0x248C2D0", Offset = "0x248C3D1", VA = "0x248C2D0")]
	public void Update()
	{
	}

	// Token: 0x06001383 RID: 4995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BA")]
	[Address(RVA = "0x248C9D0", Offset = "0x248CAD1", VA = "0x248C9D0")]
	public void Attach(Transform target)
	{
	}

	// Token: 0x06001384 RID: 4996 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BB")]
	[Address(RVA = "0x248CA90", Offset = "0x248CB91", VA = "0x248CA90")]
	public void MannequinEquipSetParent()
	{
	}

	// Token: 0x06001385 RID: 4997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BC")]
	[Address(RVA = "0x248CC30", Offset = "0x248CD31", VA = "0x248CC30")]
	public void Detach(Transform target)
	{
	}

	// Token: 0x06001386 RID: 4998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BD")]
	[Address(RVA = "0x248CCA0", Offset = "0x248CDA1", VA = "0x248CCA0")]
	public void Clear()
	{
	}

	// Token: 0x06001387 RID: 4999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BE")]
	[Address(RVA = "0x248CD00", Offset = "0x248CE01", VA = "0x248CD00")]
	public void Release()
	{
	}

	// Token: 0x06001388 RID: 5000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BF")]
	[Address(RVA = "0x248CDB0", Offset = "0x248CEB1", VA = "0x248CDB0")]
	public Restraint([Optional] RestraintSource[] sources)
	{
	}

	// Token: 0x04000AED RID: 2797
	[Token(Token = "0x4000889")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private List<Transform> m_TargetList;

	// Token: 0x04000AEE RID: 2798
	[Token(Token = "0x400088A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x15F4B0", Offset = "0x15F5B1")]
	private float m_Weight;

	// Token: 0x04000AEF RID: 2799
	[Token(Token = "0x400088B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Vector3 m_PositionOffset;

	// Token: 0x04000AF0 RID: 2800
	[Token(Token = "0x400088C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector3 m_RotationOffset;

	// Token: 0x04000AF1 RID: 2801
	[Token(Token = "0x400088D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private Vector3 m_Scale;

	// Token: 0x04000AF2 RID: 2802
	[Token(Token = "0x400088E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RestraintSource[] m_Sources;
}
