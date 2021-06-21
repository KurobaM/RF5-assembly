using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B7B RID: 2939
[Token(Token = "0x20007A6")]
public class ExplosionSource : MonoBehaviour
{
	// Token: 0x06004B6C RID: 19308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F37")]
	[Address(RVA = "0x21BDC90", Offset = "0x21BDD91", VA = "0x21BDC90")]
	private void Start()
	{
	}

	// Token: 0x06004B6D RID: 19309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F38")]
	[Address(RVA = "0x21BDD70", Offset = "0x21BDE71", VA = "0x21BDD70")]
	private void Update()
	{
	}

	// Token: 0x06004B6E RID: 19310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F39")]
	[Address(RVA = "0x21BDF30", Offset = "0x21BE031", VA = "0x21BDF30")]
	public ExplosionSource()
	{
	}

	// Token: 0x0400AC15 RID: 44053
	[Token(Token = "0x40081D1")]
	[FieldOffset(Offset = "0x18")]
	public float InfluenceRadius;

	// Token: 0x0400AC16 RID: 44054
	[Token(Token = "0x40081D2")]
	[FieldOffset(Offset = "0x1C")]
	public float Force;

	// Token: 0x0400AC17 RID: 44055
	[Token(Token = "0x40081D3")]
	[FieldOffset(Offset = "0x20")]
	public bool CheckStructureIntegrity;

	// Token: 0x0400AC18 RID: 44056
	[Token(Token = "0x40081D4")]
	[FieldOffset(Offset = "0x21")]
	public bool MoveManually;

	// Token: 0x0400AC19 RID: 44057
	[Token(Token = "0x40081D5")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 PosStart;

	// Token: 0x0400AC1A RID: 44058
	[Token(Token = "0x40081D6")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 PosEnd;

	// Token: 0x0400AC1B RID: 44059
	[Token(Token = "0x40081D7")]
	[FieldOffset(Offset = "0x3C")]
	public float MoveDuration;

	// Token: 0x0400AC1C RID: 44060
	[Token(Token = "0x40081D8")]
	[FieldOffset(Offset = "0x40")]
	private FracturedObject[] m_aFracturedObjects;

	// Token: 0x0400AC1D RID: 44061
	[Token(Token = "0x40081D9")]
	[FieldOffset(Offset = "0x48")]
	private float m_fStartTime;
}
