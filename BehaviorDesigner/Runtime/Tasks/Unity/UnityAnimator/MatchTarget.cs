using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014AF RID: 5295
	[Token(Token = "0x2000E75")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155CF0", Offset = "0x155DF1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155CF0", Offset = "0x155DF1")]
	public class MatchTarget : Action
	{
		// Token: 0x06007906 RID: 30982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065BA")]
		[Address(RVA = "0x28D69A0", Offset = "0x28D6AA1", VA = "0x28D69A0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007907 RID: 30983 RVA: 0x0002A288 File Offset: 0x00028488
		[Token(Token = "0x60065BB")]
		[Address(RVA = "0x28D6AA0", Offset = "0x28D6BA1", VA = "0x28D6AA0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007908 RID: 30984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065BC")]
		[Address(RVA = "0x28D6C50", Offset = "0x28D6D51", VA = "0x28D6C50", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007909 RID: 30985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065BD")]
		[Address(RVA = "0x28D6D40", Offset = "0x28D6E41", VA = "0x28D6D40")]
		public MatchTarget()
		{
		}

		// Token: 0x0401BBC3 RID: 113603
		[Token(Token = "0x40185C1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192F90", Offset = "0x193091")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BBC4 RID: 113604
		[Token(Token = "0x40185C2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192FD0", Offset = "0x1930D1")]
		public SharedVector3 matchPosition;

		// Token: 0x0401BBC5 RID: 113605
		[Token(Token = "0x40185C3")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193010", Offset = "0x193111")]
		public SharedQuaternion matchRotation;

		// Token: 0x0401BBC6 RID: 113606
		[Token(Token = "0x40185C4")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193050", Offset = "0x193151")]
		public AvatarTarget targetBodyPart;

		// Token: 0x0401BBC7 RID: 113607
		[Token(Token = "0x40185C5")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193090", Offset = "0x193191")]
		public Vector3 weightMaskPosition;

		// Token: 0x0401BBC8 RID: 113608
		[Token(Token = "0x40185C6")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1930D0", Offset = "0x1931D1")]
		public float weightMaskRotation;

		// Token: 0x0401BBC9 RID: 113609
		[Token(Token = "0x40185C7")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193110", Offset = "0x193211")]
		public float startNormalizedTime;

		// Token: 0x0401BBCA RID: 113610
		[Token(Token = "0x40185C8")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193150", Offset = "0x193251")]
		public float targetNormalizedTime;

		// Token: 0x0401BBCB RID: 113611
		[Token(Token = "0x40185C9")]
		[FieldOffset(Offset = "0x88")]
		private Animator animator;

		// Token: 0x0401BBCC RID: 113612
		[Token(Token = "0x40185CA")]
		[FieldOffset(Offset = "0x90")]
		private GameObject prevGameObject;
	}
}
