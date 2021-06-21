using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002C3 RID: 707
[Token(Token = "0x2000229")]
public class RideChair : MonoBehaviour
{
	// Token: 0x1700034F RID: 847
	// (get) Token: 0x060012A3 RID: 4771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000325")]
	public Transform AttachPoint
	{
		[Token(Token = "0x6001104")]
		[Address(RVA = "0x2492CF0", Offset = "0x2492DF1", VA = "0x2492CF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000350 RID: 848
	// (get) Token: 0x060012A4 RID: 4772 RVA: 0x00008820 File Offset: 0x00006A20
	[Token(Token = "0x17000326")]
	public float FadeAlpha
	{
		[Token(Token = "0x6001105")]
		[Address(RVA = "0x2492D00", Offset = "0x2492E01", VA = "0x2492D00")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060012A5 RID: 4773 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001106")]
	[Address(RVA = "0x2492DB0", Offset = "0x2492EB1", VA = "0x2492DB0", Slot = "4")]
	public virtual void SetFadeAlpha(float alpha)
	{
	}

	// Token: 0x060012A6 RID: 4774 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001107")]
	[Address(RVA = "0x2492E70", Offset = "0x2492F71", VA = "0x2492E70")]
	public RideChair()
	{
	}

	// Token: 0x04000A7D RID: 2685
	[Token(Token = "0x4000831")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform m_attachPoint;

	// Token: 0x04000A7E RID: 2686
	[Token(Token = "0x4000832")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected MeshFadeController m_FadeController;
}
