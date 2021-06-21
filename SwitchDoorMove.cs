using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005FD RID: 1533
[Token(Token = "0x200044F")]
[Attribute(Name = "ExecuteInEditMode", RVA = "0x1461D0", Offset = "0x1462D1")]
public class SwitchDoorMove : MonoBehaviour
{
	// Token: 0x060025EF RID: 9711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FF9")]
	[Address(RVA = "0x1FABD90", Offset = "0x1FABE91", VA = "0x1FABD90")]
	private void Awake()
	{
	}

	// Token: 0x060025F0 RID: 9712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FFA")]
	[Address(RVA = "0x1FABF60", Offset = "0x1FAC061", VA = "0x1FABF60")]
	private void SetElapsedTimeAndUpdatePoint()
	{
	}

	// Token: 0x060025F1 RID: 9713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FFB")]
	[Address(RVA = "0x1FAC0E0", Offset = "0x1FAC1E1", VA = "0x1FAC0E0")]
	private void Update()
	{
	}

	// Token: 0x060025F2 RID: 9714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FFC")]
	[Address(RVA = "0x1FAC140", Offset = "0x1FAC241", VA = "0x1FAC140")]
	private void OnChangeSwitchState(bool newState, bool immediate)
	{
	}

	// Token: 0x060025F3 RID: 9715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FFD")]
	[Address(RVA = "0x1FAC2A0", Offset = "0x1FAC3A1", VA = "0x1FAC2A0")]
	public SwitchDoorMove()
	{
	}

	// Token: 0x04006D3B RID: 27963
	[Token(Token = "0x4006647")]
	protected const string EffectRootName = "EffectRoot";

	// Token: 0x04006D3C RID: 27964
	[Token(Token = "0x4006648")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float DoorMoveDuration;

	// Token: 0x04006D3D RID: 27965
	[Token(Token = "0x4006649")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform ActivePoint;

	// Token: 0x04006D3E RID: 27966
	[Token(Token = "0x400664A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform DeActivePoint;

	// Token: 0x04006D3F RID: 27967
	[Token(Token = "0x400664B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public EffectID EffectId;

	// Token: 0x04006D40 RID: 27968
	[Token(Token = "0x400664C")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform EffectRoot;

	// Token: 0x04006D41 RID: 27969
	[Token(Token = "0x400664D")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float MoveDelay;

	// Token: 0x04006D42 RID: 27970
	[Token(Token = "0x400664E")]
	[FieldOffset(Offset = "0x44")]
	private bool MoveDirection;

	// Token: 0x04006D43 RID: 27971
	[Token(Token = "0x400664F")]
	[FieldOffset(Offset = "0x45")]
	private bool MoveDone;

	// Token: 0x04006D44 RID: 27972
	[Token(Token = "0x4006650")]
	[FieldOffset(Offset = "0x48")]
	private float ElapsedTime;

	// Token: 0x020005FE RID: 1534
	[Token(Token = "0x2001137")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1580D0", Offset = "0x1581D1")]
	private sealed class <>c__DisplayClass13_0
	{
		// Token: 0x060025F4 RID: 9716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070E1")]
		[Address(RVA = "0x1FAC290", Offset = "0x1FAC391", VA = "0x1FAC290")]
		public <>c__DisplayClass13_0()
		{
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070E2")]
		[Address(RVA = "0x1FAC2B0", Offset = "0x1FAC3B1", VA = "0x1FAC2B0")]
		internal void <OnChangeSwitchState>b__0()
		{
		}

		// Token: 0x04006D45 RID: 27973
		[Token(Token = "0x4019367")]
		[FieldOffset(Offset = "0x10")]
		public SwitchDoorMove <>4__this;

		// Token: 0x04006D46 RID: 27974
		[Token(Token = "0x4019368")]
		[FieldOffset(Offset = "0x18")]
		public bool newState;
	}
}
