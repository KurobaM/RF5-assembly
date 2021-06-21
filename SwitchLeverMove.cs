using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005FF RID: 1535
[Token(Token = "0x2000450")]
[Attribute(Name = "ExecuteInEditMode", RVA = "0x1461E0", Offset = "0x1462E1")]
public class SwitchLeverMove : MonoBehaviour
{
	// Token: 0x060025F6 RID: 9718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FFE")]
	[Address(RVA = "0x1FAC3D0", Offset = "0x1FAC4D1", VA = "0x1FAC3D0")]
	private void Awake()
	{
	}

	// Token: 0x060025F7 RID: 9719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FFF")]
	[Address(RVA = "0x1FAC600", Offset = "0x1FAC701", VA = "0x1FAC600")]
	private void SetElapsedTimeAndUpdatePoint()
	{
	}

	// Token: 0x060025F8 RID: 9720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002000")]
	[Address(RVA = "0x1FAC740", Offset = "0x1FAC841", VA = "0x1FAC740")]
	private void Update()
	{
	}

	// Token: 0x060025F9 RID: 9721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002001")]
	[Address(RVA = "0x1FAC7A0", Offset = "0x1FAC8A1", VA = "0x1FAC7A0")]
	private void OnChangeSwitchState(bool newState, bool immediate)
	{
	}

	// Token: 0x060025FA RID: 9722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002002")]
	[Address(RVA = "0x1FAC4F0", Offset = "0x1FAC5F1", VA = "0x1FAC4F0")]
	private void ChangeRendererMaterial(bool newState)
	{
	}

	// Token: 0x060025FB RID: 9723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002003")]
	[Address(RVA = "0x1FAC7F0", Offset = "0x1FAC8F1", VA = "0x1FAC7F0")]
	public SwitchLeverMove()
	{
	}

	// Token: 0x04006D47 RID: 27975
	[Token(Token = "0x4006651")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform MoveTargetTransform;

	// Token: 0x04006D48 RID: 27976
	[Token(Token = "0x4006652")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float MoveDuration;

	// Token: 0x04006D49 RID: 27977
	[Token(Token = "0x4006653")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Vector3 OffPosition;

	// Token: 0x04006D4A RID: 27978
	[Token(Token = "0x4006654")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector3 OnPosition;

	// Token: 0x04006D4B RID: 27979
	[Token(Token = "0x4006655")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Renderer[] Renderers;

	// Token: 0x04006D4C RID: 27980
	[Token(Token = "0x4006656")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Material[] Materials;

	// Token: 0x04006D4D RID: 27981
	[Token(Token = "0x4006657")]
	[FieldOffset(Offset = "0x50")]
	private bool MoveDirection;

	// Token: 0x04006D4E RID: 27982
	[Token(Token = "0x4006658")]
	[FieldOffset(Offset = "0x51")]
	private bool MoveDone;

	// Token: 0x04006D4F RID: 27983
	[Token(Token = "0x4006659")]
	[FieldOffset(Offset = "0x54")]
	private float ElapsedTime;
}
