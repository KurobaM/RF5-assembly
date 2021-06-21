using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200045B RID: 1115
[Token(Token = "0x2000358")]
public class ObjectPositions : MonoBehaviour
{
	// Token: 0x06001B00 RID: 6912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600180A")]
	[Address(RVA = "0x1F575B0", Offset = "0x1F576B1", VA = "0x1F575B0")]
	public ObjectPositions()
	{
	}

	// Token: 0x04005DF4 RID: 24052
	[Token(Token = "0x4005A03")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Vector3 enablePosition;

	// Token: 0x04005DF5 RID: 24053
	[Token(Token = "0x4005A04")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public Vector3 enableRotation;

	// Token: 0x04005DF6 RID: 24054
	[Token(Token = "0x4005A05")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public Vector3 enableScale;

	// Token: 0x04005DF7 RID: 24055
	[Token(Token = "0x4005A06")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public Vector3 disablePosition;

	// Token: 0x04005DF8 RID: 24056
	[Token(Token = "0x4005A07")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public string enableSceneName;
}
