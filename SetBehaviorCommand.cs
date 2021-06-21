using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000AE RID: 174
[Token(Token = "0x2000087")]
public class SetBehaviorCommand : MonsterProjectileActionCommandBase
{
	// Token: 0x17000094 RID: 148
	// (get) Token: 0x0600035F RID: 863 RVA: 0x000030D8 File Offset: 0x000012D8
	[Token(Token = "0x17000091")]
	public SetBehaviorCommand.BehaviorType Behavior
	{
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1E31F40", Offset = "0x1E32041", VA = "0x1E31F40")]
		get
		{
			return SetBehaviorCommand.BehaviorType.Straight;
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x06000360 RID: 864 RVA: 0x000030F0 File Offset: 0x000012F0
	[Token(Token = "0x17000092")]
	private EffectID LaunchPointEffectID
	{
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1E31FA0", Offset = "0x1E320A1", VA = "0x1E31FA0")]
		get
		{
			return EffectID.EFFECT_EMPTY;
		}
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x06000361 RID: 865 RVA: 0x00003108 File Offset: 0x00001308
	[Token(Token = "0x17000093")]
	private EffectID EffectID
	{
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1E32020", Offset = "0x1E32121", VA = "0x1E32020")]
		get
		{
			return EffectID.EFFECT_EMPTY;
		}
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x06000362 RID: 866 RVA: 0x00003120 File Offset: 0x00001320
	[Token(Token = "0x17000094")]
	private EffectID HitEffectID
	{
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1E320A0", Offset = "0x1E321A1", VA = "0x1E320A0")]
		get
		{
			return EffectID.EFFECT_EMPTY;
		}
	}

	// Token: 0x06000363 RID: 867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x1E32120", Offset = "0x1E32221", VA = "0x1E32120")]
	public SetBehaviorCommand(ActionCommandDataTable actionCommandData, MonsterProjectileActionScriptsController controller)
	{
	}

	// Token: 0x06000364 RID: 868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x1E32180", Offset = "0x1E32281", VA = "0x1E32180", Slot = "8")]
	public override void DoAction()
	{
	}

	// Token: 0x06000365 RID: 869 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x1E32F20", Offset = "0x1E33021", VA = "0x1E32F20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A0E0", Offset = "0x19A1E1")]
	private void <DoAction>b__14_0(Collider collider)
	{
	}

	// Token: 0x06000366 RID: 870 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x1E32F80", Offset = "0x1E33081", VA = "0x1E32F80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A0F0", Offset = "0x19A1F1")]
	private void <DoAction>b__14_1(Collider collider)
	{
	}

	// Token: 0x0400022C RID: 556
	[Token(Token = "0x40001BE")]
	private const string Path = "prefabs/";

	// Token: 0x0400022D RID: 557
	[Token(Token = "0x40001BF")]
	[FieldOffset(Offset = "0x88")]
	private EffectID _LaunchPointEffectID;

	// Token: 0x0400022E RID: 558
	[Token(Token = "0x40001C0")]
	[FieldOffset(Offset = "0x8C")]
	private EffectID _EffectID;

	// Token: 0x0400022F RID: 559
	[Token(Token = "0x40001C1")]
	[FieldOffset(Offset = "0x90")]
	private EffectID _HitEffectID;

	// Token: 0x020000AF RID: 175
	[Token(Token = "0x2000FB1")]
	public enum BehaviorType
	{
		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4018CE7")]
		Straight,
		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4018CE8")]
		Homing,
		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4018CE9")]
		Circle,
		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4018CEA")]
		Laser,
		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4018CEB")]
		Straight_GroundStop,
		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4018CEC")]
		Straight_Target_Blaking,
		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4018CED")]
		Homing_Target_Blaking,
		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4018CEE")]
		Rise_Straight,
		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4018CEF")]
		AroundMove,
		// Token: 0x0400023A RID: 570
		[Token(Token = "0x4018CF0")]
		Bound,
		// Token: 0x0400023B RID: 571
		[Token(Token = "0x4018CF1")]
		TargetTransform,
		// Token: 0x0400023C RID: 572
		[Token(Token = "0x4018CF2")]
		MoveTransform_Straight,
		// Token: 0x0400023D RID: 573
		[Token(Token = "0x4018CF3")]
		Straight_NoRotate,
		// Token: 0x0400023E RID: 574
		[Token(Token = "0x4018CF4")]
		Straight_NoRotate_GroundStop,
		// Token: 0x0400023F RID: 575
		[Token(Token = "0x4018CF5")]
		TargetJump,
		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4018CF6")]
		Curve
	}
}
