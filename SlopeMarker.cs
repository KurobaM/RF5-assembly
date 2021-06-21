using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200087B RID: 2171
[Token(Token = "0x200059F")]
public class SlopeMarker : MonoBehaviour
{
	// Token: 0x170007F5 RID: 2037
	// (get) Token: 0x06003940 RID: 14656 RVA: 0x00013D58 File Offset: 0x00011F58
	// (set) Token: 0x06003941 RID: 14657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700063A")]
	public Color Color
	{
		[Token(Token = "0x6002FC4")]
		[Address(RVA = "0x2251F80", Offset = "0x2252081", VA = "0x2251F80")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6002FC5")]
		[Address(RVA = "0x2251F90", Offset = "0x2252091", VA = "0x2251F90")]
		set
		{
		}
	}

	// Token: 0x06003942 RID: 14658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FC6")]
	[Address(RVA = "0x2251FB0", Offset = "0x22520B1", VA = "0x2251FB0")]
	private void Start()
	{
	}

	// Token: 0x06003943 RID: 14659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FC7")]
	[Address(RVA = "0x2252030", Offset = "0x2252131", VA = "0x2252030")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x06003944 RID: 14660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FC8")]
	[Address(RVA = "0x2252090", Offset = "0x2252191", VA = "0x2252090")]
	public SlopeMarker()
	{
	}

	// Token: 0x04007C9B RID: 31899
	[Token(Token = "0x40070AE")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "HideInInspector", RVA = "0x16DFD0", Offset = "0x16E0D1")]
	private Color m_Color;

	// Token: 0x04007C9C RID: 31900
	[Token(Token = "0x40070AF")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 Sjze;
}
