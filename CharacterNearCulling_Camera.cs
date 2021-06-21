using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B4 RID: 692
[Token(Token = "0x2000221")]
public class CharacterNearCulling_Camera : SingletonMonoBehaviour<CharacterNearCulling_Camera>
{
	// Token: 0x06001211 RID: 4625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107A")]
	[Address(RVA = "0x1E95A20", Offset = "0x1E95B21", VA = "0x1E95A20")]
	private void Start()
	{
	}

	// Token: 0x06001212 RID: 4626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107B")]
	[Address(RVA = "0x1E95A90", Offset = "0x1E95B91", VA = "0x1E95A90")]
	private void OnDisable()
	{
	}

	// Token: 0x06001213 RID: 4627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107C")]
	[Address(RVA = "0x1E95C10", Offset = "0x1E95D11", VA = "0x1E95C10")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06001214 RID: 4628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107D")]
	[Address(RVA = "0x1E96310", Offset = "0x1E96411", VA = "0x1E96310")]
	public CharacterNearCulling_Camera()
	{
	}

	// Token: 0x04000A2A RID: 2602
	[Token(Token = "0x4000803")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float m_Radius;

	// Token: 0x04000A2B RID: 2603
	[Token(Token = "0x4000804")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private LayerMask m_LayerMask;

	// Token: 0x04000A2C RID: 2604
	[Token(Token = "0x4000805")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<Collider, CharacterNearCullingController> StayControllers;

	// Token: 0x04000A2D RID: 2605
	[Token(Token = "0x4000806")]
	[FieldOffset(Offset = "0x28")]
	private List<Collider> OnExitList;
}
