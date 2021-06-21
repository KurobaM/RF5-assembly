using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000242 RID: 578
[Token(Token = "0x20001D0")]
[Serializable]
public class HumanJoint
{
	// Token: 0x06000E03 RID: 3587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA2")]
	[Address(RVA = "0x2221E20", Offset = "0x2221F21", VA = "0x2221E20")]
	public HumanJoint(HumanJointIDEnum id)
	{
	}

	// Token: 0x04000802 RID: 2050
	[Token(Token = "0x4000670")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public HumanJointIDEnum JointId;

	// Token: 0x04000803 RID: 2051
	[Token(Token = "0x4000671")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Transform JointPosition;

	// Token: 0x04000804 RID: 2052
	[Token(Token = "0x4000672")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public bool Active;
}
