using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200080F RID: 2063
[Token(Token = "0x2000550")]
public class NpcMoveTest : MonoBehaviour
{
	// Token: 0x06003732 RID: 14130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DEC")]
	[Address(RVA = "0x1F52F30", Offset = "0x1F53031", VA = "0x1F52F30")]
	private void Start()
	{
	}

	// Token: 0x06003733 RID: 14131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DED")]
	[Address(RVA = "0x1F52FF0", Offset = "0x1F530F1", VA = "0x1F52FF0")]
	private void Update()
	{
	}

	// Token: 0x06003734 RID: 14132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DEE")]
	[Address(RVA = "0x1F53000", Offset = "0x1F53101", VA = "0x1F53000")]
	public void MoveStart()
	{
	}

	// Token: 0x06003735 RID: 14133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DEF")]
	[Address(RVA = "0x1F53100", Offset = "0x1F53201", VA = "0x1F53100")]
	public void MoveRestart()
	{
	}

	// Token: 0x06003736 RID: 14134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DF0")]
	[Address(RVA = "0x1F53200", Offset = "0x1F53301", VA = "0x1F53200")]
	public void MovePause()
	{
	}

	// Token: 0x06003737 RID: 14135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DF1")]
	[Address(RVA = "0x1F53230", Offset = "0x1F53331", VA = "0x1F53230")]
	public NpcMoveTest()
	{
	}

	// Token: 0x04007A46 RID: 31302
	[Token(Token = "0x4006EBB")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private NpcMoveControl.MOVE_TYPE MoveType;

	// Token: 0x04007A47 RID: 31303
	[Token(Token = "0x4006EBC")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private NpcMoveControl TargetActor;

	// Token: 0x04007A48 RID: 31304
	[Token(Token = "0x4006EBD")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector3 TargetStart;

	// Token: 0x04007A49 RID: 31305
	[Token(Token = "0x4006EBE")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<GameObject> TargetGoal;

	// Token: 0x04007A4A RID: 31306
	[Token(Token = "0x4006EBF")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private int GoalSet;

	// Token: 0x04007A4B RID: 31307
	[Token(Token = "0x4006EC0")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private NpcMoveTest.SpeedData[] MoveSpeedTable;

	// Token: 0x04007A4C RID: 31308
	[Token(Token = "0x4006EC1")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private NpcMoveTest.SPEED MoveSpeed;

	// Token: 0x02000810 RID: 2064
	[Token(Token = "0x2001244")]
	public enum SPEED
	{
		// Token: 0x04007A4E RID: 31310
		[Token(Token = "0x40197F1")]
		WALK,
		// Token: 0x04007A4F RID: 31311
		[Token(Token = "0x40197F2")]
		RUN,
		// Token: 0x04007A50 RID: 31312
		[Token(Token = "0x40197F3")]
		DASH,
		// Token: 0x04007A51 RID: 31313
		[Token(Token = "0x40197F4")]
		MAX
	}

	// Token: 0x02000811 RID: 2065
	[Token(Token = "0x2001245")]
	[Serializable]
	public class SpeedData
	{
		// Token: 0x06003738 RID: 14136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600742F")]
		[Address(RVA = "0x1F533D0", Offset = "0x1F534D1", VA = "0x1F533D0")]
		public SpeedData()
		{
		}

		// Token: 0x04007A52 RID: 31314
		[Token(Token = "0x40197F5")]
		[FieldOffset(Offset = "0x10")]
		public NpcMoveTest.SPEED type;

		// Token: 0x04007A53 RID: 31315
		[Token(Token = "0x40197F6")]
		[FieldOffset(Offset = "0x14")]
		public float speed;
	}
}
