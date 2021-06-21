using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C4 RID: 452
[Token(Token = "0x2000163")]
public class CharacterEnableRotateNormalizeTime : CharaMotionBehaviour
{
	// Token: 0x06000972 RID: 2418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000824")]
	[Address(RVA = "0x1E8DCC0", Offset = "0x1E8DDC1", VA = "0x1E8DCC0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000973 RID: 2419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000825")]
	[Address(RVA = "0x1E8DDA0", Offset = "0x1E8DEA1", VA = "0x1E8DDA0", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000974 RID: 2420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000826")]
	[Address(RVA = "0x1E8DF00", Offset = "0x1E8E001", VA = "0x1E8DF00", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000975 RID: 2421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000827")]
	[Address(RVA = "0x1E8DF30", Offset = "0x1E8E031", VA = "0x1E8DF30")]
	public CharacterEnableRotateNormalizeTime()
	{
	}

	// Token: 0x040005F9 RID: 1529
	[Token(Token = "0x40004A4")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<CharacterEnableRotateNormalizeTime.EnableSettingNormalizeTime> EnableSettingNormalizeTimeList;

	// Token: 0x040005FA RID: 1530
	[Token(Token = "0x40004A5")]
	[FieldOffset(Offset = "0x30")]
	private float OffsetNormalize;

	// Token: 0x040005FB RID: 1531
	[Token(Token = "0x40004A6")]
	[FieldOffset(Offset = "0x34")]
	private int CurrentIndex;

	// Token: 0x020001C5 RID: 453
	[Token(Token = "0x2000FEA")]
	[Serializable]
	public class EnableSettingNormalizeTime
	{
		// Token: 0x06000976 RID: 2422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C39")]
		[Address(RVA = "0x1E8DF40", Offset = "0x1E8E041", VA = "0x1E8DF40")]
		public EnableSettingNormalizeTime()
		{
		}

		// Token: 0x040005FC RID: 1532
		[Token(Token = "0x4018DC8")]
		[FieldOffset(Offset = "0x10")]
		public float normalizeTime;

		// Token: 0x040005FD RID: 1533
		[Token(Token = "0x4018DC9")]
		[FieldOffset(Offset = "0x14")]
		public bool Enable;
	}
}
