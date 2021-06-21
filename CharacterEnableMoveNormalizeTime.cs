using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C2 RID: 450
[Token(Token = "0x2000162")]
public class CharacterEnableMoveNormalizeTime : CharaMotionBehaviour
{
	// Token: 0x0600096D RID: 2413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000820")]
	[Address(RVA = "0x1E8DA30", Offset = "0x1E8DB31", VA = "0x1E8DA30", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x0600096E RID: 2414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000821")]
	[Address(RVA = "0x1E8DB10", Offset = "0x1E8DC11", VA = "0x1E8DB10", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x0600096F RID: 2415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000822")]
	[Address(RVA = "0x1E8DC70", Offset = "0x1E8DD71", VA = "0x1E8DC70", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000970 RID: 2416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000823")]
	[Address(RVA = "0x1E8DCA0", Offset = "0x1E8DDA1", VA = "0x1E8DCA0")]
	public CharacterEnableMoveNormalizeTime()
	{
	}

	// Token: 0x040005F4 RID: 1524
	[Token(Token = "0x40004A1")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<CharacterEnableMoveNormalizeTime.EnableSettingNormalizeTime> EnableSettingNormalizeTimeList;

	// Token: 0x040005F5 RID: 1525
	[Token(Token = "0x40004A2")]
	[FieldOffset(Offset = "0x30")]
	private float OffsetNormalize;

	// Token: 0x040005F6 RID: 1526
	[Token(Token = "0x40004A3")]
	[FieldOffset(Offset = "0x34")]
	private int CurrentIndex;

	// Token: 0x020001C3 RID: 451
	[Token(Token = "0x2000FE9")]
	[Serializable]
	public class EnableSettingNormalizeTime
	{
		// Token: 0x06000971 RID: 2417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C38")]
		[Address(RVA = "0x1E8DCB0", Offset = "0x1E8DDB1", VA = "0x1E8DCB0")]
		public EnableSettingNormalizeTime()
		{
		}

		// Token: 0x040005F7 RID: 1527
		[Token(Token = "0x4018DC6")]
		[FieldOffset(Offset = "0x10")]
		public float normalizeTime;

		// Token: 0x040005F8 RID: 1528
		[Token(Token = "0x4018DC7")]
		[FieldOffset(Offset = "0x14")]
		public bool Enable;
	}
}
