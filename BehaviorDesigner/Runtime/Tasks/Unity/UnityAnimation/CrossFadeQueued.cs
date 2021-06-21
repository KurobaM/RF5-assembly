using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimation
{
	// Token: 0x020014C4 RID: 5316
	[Token(Token = "0x2000E87")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1563B0", Offset = "0x1564B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1563B0", Offset = "0x1564B1")]
	public class CrossFadeQueued : Action
	{
		// Token: 0x06007966 RID: 31078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006608")]
		[Address(RVA = "0x28D2B70", Offset = "0x28D2C71", VA = "0x28D2B70", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007967 RID: 31079 RVA: 0x0002A480 File Offset: 0x00028680
		[Token(Token = "0x6006609")]
		[Address(RVA = "0x28D2C70", Offset = "0x28D2D71", VA = "0x28D2C70", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007968 RID: 31080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600660A")]
		[Address(RVA = "0x28D2D70", Offset = "0x28D2E71", VA = "0x28D2D70", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007969 RID: 31081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600660B")]
		[Address(RVA = "0x28D2E00", Offset = "0x28D2F01", VA = "0x28D2E00")]
		public CrossFadeQueued()
		{
		}

		// Token: 0x0401BC2F RID: 113711
		[Token(Token = "0x4018621")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193D90", Offset = "0x193E91")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BC30 RID: 113712
		[Token(Token = "0x4018622")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193DD0", Offset = "0x193ED1")]
		public SharedString animationName;

		// Token: 0x0401BC31 RID: 113713
		[Token(Token = "0x4018623")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193E10", Offset = "0x193F11")]
		public float fadeLength;

		// Token: 0x0401BC32 RID: 113714
		[Token(Token = "0x4018624")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193E50", Offset = "0x193F51")]
		public QueueMode queue;

		// Token: 0x0401BC33 RID: 113715
		[Token(Token = "0x4018625")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193E90", Offset = "0x193F91")]
		public PlayMode playMode;

		// Token: 0x0401BC34 RID: 113716
		[Token(Token = "0x4018626")]
		[FieldOffset(Offset = "0x70")]
		private Animation animation;

		// Token: 0x0401BC35 RID: 113717
		[Token(Token = "0x4018627")]
		[FieldOffset(Offset = "0x78")]
		private GameObject prevGameObject;
	}
}
