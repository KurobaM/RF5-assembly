using System;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A7 RID: 423
[Token(Token = "0x200014C")]
public class LandscapeVcam : MonoBehaviour
{
	// Token: 0x060008C7 RID: 2247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078C")]
	[Address(RVA = "0x2301460", Offset = "0x2301561", VA = "0x2301460")]
	private void Start()
	{
	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078D")]
	[Address(RVA = "0x2301230", Offset = "0x2301331", VA = "0x2301230")]
	public void Enable(Transform follow, Transform lookAt, Transform dofTarget)
	{
	}

	// Token: 0x060008C9 RID: 2249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078E")]
	[Address(RVA = "0x23013A0", Offset = "0x23014A1", VA = "0x23013A0")]
	public void Disable()
	{
	}

	// Token: 0x060008CA RID: 2250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600078F")]
	[Address(RVA = "0x23014E0", Offset = "0x23015E1", VA = "0x23014E0")]
	public LandscapeVcam()
	{
	}

	// Token: 0x0400052E RID: 1326
	[Token(Token = "0x40003FB")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected CinemachineVirtualCameraBase CinemachineVirtualCameraBase;
}
