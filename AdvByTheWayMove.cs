using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000910 RID: 2320
[Token(Token = "0x2000616")]
public class AdvByTheWayMove : MonoBehaviour
{
	// Token: 0x06003CC8 RID: 15560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003319")]
	[Address(RVA = "0x1D58E70", Offset = "0x1D58F71", VA = "0x1D58E70")]
	private void OnEnable()
	{
	}

	// Token: 0x06003CC9 RID: 15561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600331A")]
	[Address(RVA = "0x1D58F70", Offset = "0x1D59071", VA = "0x1D58F70")]
	private void OnDisable()
	{
	}

	// Token: 0x06003CCA RID: 15562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600331B")]
	[Address(RVA = "0x1D58F80", Offset = "0x1D59081", VA = "0x1D58F80")]
	public void StartMove()
	{
	}

	// Token: 0x06003CCB RID: 15563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600331C")]
	[Address(RVA = "0x1D58E80", Offset = "0x1D58F81", VA = "0x1D58E80")]
	public void StopMove()
	{
	}

	// Token: 0x06003CCC RID: 15564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600331D")]
	[Address(RVA = "0x1D59080", Offset = "0x1D59181", VA = "0x1D59080")]
	private void Update()
	{
	}

	// Token: 0x06003CCD RID: 15565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600331E")]
	[Address(RVA = "0x1D591A0", Offset = "0x1D592A1", VA = "0x1D591A0")]
	public AdvByTheWayMove()
	{
	}

	// Token: 0x04007F27 RID: 32551
	[Token(Token = "0x40072C9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float MoveRange;

	// Token: 0x04007F28 RID: 32552
	[Token(Token = "0x40072CA")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float MoveSpeed;

	// Token: 0x04007F29 RID: 32553
	[Token(Token = "0x40072CB")]
	[FieldOffset(Offset = "0x20")]
	private bool isMove;

	// Token: 0x04007F2A RID: 32554
	[Token(Token = "0x40072CC")]
	[FieldOffset(Offset = "0x28")]
	private RectTransform RectTransform;

	// Token: 0x04007F2B RID: 32555
	[Token(Token = "0x40072CD")]
	[FieldOffset(Offset = "0x30")]
	private float nTime;
}
