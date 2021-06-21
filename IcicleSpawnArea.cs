using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005F3 RID: 1523
[Token(Token = "0x2000448")]
public class IcicleSpawnArea : MonoBehaviour
{
	// Token: 0x060025A4 RID: 9636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FC0")]
	[Address(RVA = "0x222BE60", Offset = "0x222BF61", VA = "0x222BE60")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x060025A5 RID: 9637 RVA: 0x0000F018 File Offset: 0x0000D218
	[Token(Token = "0x6001FC1")]
	[Address(RVA = "0x222C040", Offset = "0x222C141", VA = "0x222C040")]
	public Vector3 GetSpawnPointWithRandom()
	{
		return default(Vector3);
	}

	// Token: 0x060025A6 RID: 9638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FC2")]
	[Address(RVA = "0x222C210", Offset = "0x222C311", VA = "0x222C210")]
	public IcicleSpawnArea()
	{
	}

	// Token: 0x04006CDE RID: 27870
	[Token(Token = "0x40065FD")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float X;

	// Token: 0x04006CDF RID: 27871
	[Token(Token = "0x40065FE")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float Z;

	// Token: 0x04006CE0 RID: 27872
	[Token(Token = "0x40065FF")]
	[FieldOffset(Offset = "0x20")]
	private Vector3[] Ramdoms;
}
