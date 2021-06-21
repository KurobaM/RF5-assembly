using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000712 RID: 1810
[Token(Token = "0x20004F4")]
public class InosisiController : BossMonsterContoroller
{
	// Token: 0x06002DAC RID: 11692 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002682")]
	[Address(RVA = "0x222EB00", Offset = "0x222EC01", VA = "0x222EB00")]
	private void SetupThorns()
	{
	}

	// Token: 0x06002DAD RID: 11693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002683")]
	[Address(RVA = "0x222ED80", Offset = "0x222EE81", VA = "0x222ED80")]
	private void PressThorns(int idx)
	{
	}

	// Token: 0x06002DAE RID: 11694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002684")]
	[Address(RVA = "0x222EE10", Offset = "0x222EF11", VA = "0x222EE10")]
	private void UpdateThorns()
	{
	}

	// Token: 0x06002DAF RID: 11695 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002685")]
	[Address(RVA = "0x222F0A0", Offset = "0x222F1A1", VA = "0x222F0A0")]
	public void SetIsHitCharacter(bool isHitCharacter)
	{
	}

	// Token: 0x06002DB0 RID: 11696 RVA: 0x00010B48 File Offset: 0x0000ED48
	[Token(Token = "0x6002686")]
	[Address(RVA = "0x222F0B0", Offset = "0x222F1B1", VA = "0x222F0B0")]
	private bool WallRayCast(Vector3 direction)
	{
		return default(bool);
	}

	// Token: 0x06002DB1 RID: 11697 RVA: 0x00010B60 File Offset: 0x0000ED60
	[Token(Token = "0x6002687")]
	[Address(RVA = "0x222F280", Offset = "0x222F381", VA = "0x222F280")]
	private bool CharaRayCast(Vector3 direction)
	{
		return default(bool);
	}

	// Token: 0x06002DB2 RID: 11698 RVA: 0x00010B78 File Offset: 0x0000ED78
	[Token(Token = "0x6002688")]
	[Address(RVA = "0x222F4C0", Offset = "0x222F5C1", VA = "0x222F4C0")]
	private bool FloorRayCast()
	{
		return default(bool);
	}

	// Token: 0x06002DB3 RID: 11699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002689")]
	[Address(RVA = "0x222F600", Offset = "0x222F701", VA = "0x222F600", Slot = "12")]
	protected override void Start()
	{
	}

	// Token: 0x06002DB4 RID: 11700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600268A")]
	[Address(RVA = "0x222F690", Offset = "0x222F791", VA = "0x222F690", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x06002DB5 RID: 11701 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600268B")]
	[Address(RVA = "0x222FD60", Offset = "0x222FE61", VA = "0x222FD60")]
	private void CreateProjectileRock(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex)
	{
	}

	// Token: 0x06002DB6 RID: 11702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600268C")]
	[Address(RVA = "0x22301D0", Offset = "0x22302D1", VA = "0x22301D0", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002DB7 RID: 11703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600268D")]
	[Address(RVA = "0x22302D0", Offset = "0x22303D1", VA = "0x22302D0", Slot = "116")]
	protected override void OnResetActionScriptAction()
	{
	}

	// Token: 0x06002DB8 RID: 11704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600268E")]
	[Address(RVA = "0x2230300", Offset = "0x2230401", VA = "0x2230300", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002DB9 RID: 11705 RVA: 0x00010B90 File Offset: 0x0000ED90
	[Token(Token = "0x600268F")]
	[Address(RVA = "0x2230060", Offset = "0x2230161", VA = "0x2230060")]
	private float GetGroundPos(Vector3 pos)
	{
		return 0f;
	}

	// Token: 0x06002DBA RID: 11706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002690")]
	[Address(RVA = "0x2230620", Offset = "0x2230721", VA = "0x2230620")]
	public InosisiController()
	{
	}

	// Token: 0x040073FF RID: 29695
	[Token(Token = "0x4006AEA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector3 RAY_ORIGIN_POS_OFFSET;

	// Token: 0x04007400 RID: 29696
	[Token(Token = "0x4006AEB")]
	[FieldOffset(Offset = "0x508")]
	private float rayPow;

	// Token: 0x04007401 RID: 29697
	[Token(Token = "0x4006AEC")]
	[FieldOffset(Offset = "0x50C")]
	public bool IsVariation;

	// Token: 0x04007402 RID: 29698
	[Token(Token = "0x4006AED")]
	[FieldOffset(Offset = "0x510")]
	private readonly List<string> ThornsNameList;

	// Token: 0x04007403 RID: 29699
	[Token(Token = "0x4006AEE")]
	private const string SearchPointName = "SearchPoint";

	// Token: 0x04007404 RID: 29700
	[Token(Token = "0x4006AEF")]
	[FieldOffset(Offset = "0x518")]
	private List<InosisiController.ThornsController> ThornsControllerList;

	// Token: 0x04007405 RID: 29701
	[Token(Token = "0x4006AF0")]
	[FieldOffset(Offset = "0x520")]
	private InosisiController.Dash dashState;

	// Token: 0x04007406 RID: 29702
	[Token(Token = "0x4006AF1")]
	[FieldOffset(Offset = "0x524")]
	private bool IsHitCharacter;

	// Token: 0x04007407 RID: 29703
	[Token(Token = "0x4006AF2")]
	[FieldOffset(Offset = "0x525")]
	private bool IsRotate;

	// Token: 0x04007408 RID: 29704
	[Token(Token = "0x4006AF3")]
	[FieldOffset(Offset = "0x528")]
	private Vector3 RotateDirection;

	// Token: 0x04007409 RID: 29705
	[Token(Token = "0x4006AF4")]
	[FieldOffset(Offset = "0x534")]
	private bool IsRolling;

	// Token: 0x0400740A RID: 29706
	[Token(Token = "0x4006AF5")]
	[FieldOffset(Offset = "0x538")]
	private float RollingAngle;

	// Token: 0x0400740B RID: 29707
	[Token(Token = "0x4006AF6")]
	[FieldOffset(Offset = "0x53C")]
	private bool IsRayCheck;

	// Token: 0x0400740C RID: 29708
	[Token(Token = "0x4006AF7")]
	[FieldOffset(Offset = "0x540")]
	private Transform SearchPos;

	// Token: 0x0400740D RID: 29709
	[Token(Token = "0x4006AF8")]
	[FieldOffset(Offset = "0x548")]
	private Vector3 MeteorPos;

	// Token: 0x0400740E RID: 29710
	[Token(Token = "0x4006AF9")]
	[FieldOffset(Offset = "0x558")]
	[SerializeField]
	private GameObject RockObject;

	// Token: 0x0400740F RID: 29711
	[Token(Token = "0x4006AFA")]
	[FieldOffset(Offset = "0x560")]
	[SerializeField]
	private GameObject Thorn1Object;

	// Token: 0x04007410 RID: 29712
	[Token(Token = "0x4006AFB")]
	[FieldOffset(Offset = "0x568")]
	[SerializeField]
	private GameObject Thorn2Object;

	// Token: 0x04007411 RID: 29713
	[Token(Token = "0x4006AFC")]
	[FieldOffset(Offset = "0x570")]
	[SerializeField]
	private GameObject MeteorObject;

	// Token: 0x02000713 RID: 1811
	[Token(Token = "0x20011A5")]
	private class ThornsController
	{
		// Token: 0x06002DBC RID: 11708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007215")]
		[Address(RVA = "0x222ED70", Offset = "0x222EE71", VA = "0x222ED70")]
		public ThornsController()
		{
		}

		// Token: 0x04007412 RID: 29714
		[Token(Token = "0x401957E")]
		[FieldOffset(Offset = "0x10")]
		public Transform Transform;

		// Token: 0x04007413 RID: 29715
		[Token(Token = "0x401957F")]
		[FieldOffset(Offset = "0x18")]
		public bool Press;
	}

	// Token: 0x02000714 RID: 1812
	[Token(Token = "0x20011A6")]
	private enum CreateProjectileType
	{
		// Token: 0x04007415 RID: 29717
		[Token(Token = "0x4019581")]
		None,
		// Token: 0x04007416 RID: 29718
		[Token(Token = "0x4019582")]
		Thorn1,
		// Token: 0x04007417 RID: 29719
		[Token(Token = "0x4019583")]
		Thorn2
	}

	// Token: 0x02000715 RID: 1813
	[Token(Token = "0x20011A7")]
	private enum Dash
	{
		// Token: 0x04007419 RID: 29721
		[Token(Token = "0x4019585")]
		None,
		// Token: 0x0400741A RID: 29722
		[Token(Token = "0x4019586")]
		Normal,
		// Token: 0x0400741B RID: 29723
		[Token(Token = "0x4019587")]
		Turn,
		// Token: 0x0400741C RID: 29724
		[Token(Token = "0x4019588")]
		Dash,
		// Token: 0x0400741D RID: 29725
		[Token(Token = "0x4019589")]
		SuperDash
	}
}
