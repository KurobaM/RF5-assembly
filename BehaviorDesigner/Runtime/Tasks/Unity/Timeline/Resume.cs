using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Timeline
{
	// Token: 0x02001349 RID: 4937
	[Token(Token = "0x2000D14")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D840", Offset = "0x14D941")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D840", Offset = "0x14D941")]
	public class Resume : Action
	{
		// Token: 0x06007409 RID: 29705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060BD")]
		[Address(RVA = "0x28D1FC0", Offset = "0x28D20C1", VA = "0x28D1FC0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600740A RID: 29706 RVA: 0x00028158 File Offset: 0x00026358
		[Token(Token = "0x60060BE")]
		[Address(RVA = "0x28D20C0", Offset = "0x28D21C1", VA = "0x28D20C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600740B RID: 29707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060BF")]
		[Address(RVA = "0x28D2220", Offset = "0x28D2321", VA = "0x28D2220", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600740C RID: 29708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C0")]
		[Address(RVA = "0x28D2270", Offset = "0x28D2371", VA = "0x28D2270")]
		public Resume()
		{
		}

		// Token: 0x0401B6FC RID: 112380
		[Token(Token = "0x401811D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186970", Offset = "0x186A71")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6FD RID: 112381
		[Token(Token = "0x401811E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1869B0", Offset = "0x186AB1")]
		public SharedBool stopWhenComplete;

		// Token: 0x0401B6FE RID: 112382
		[Token(Token = "0x401811F")]
		[FieldOffset(Offset = "0x60")]
		private PlayableDirector playableDirector;

		// Token: 0x0401B6FF RID: 112383
		[Token(Token = "0x4018120")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;

		// Token: 0x0401B700 RID: 112384
		[Token(Token = "0x4018121")]
		[FieldOffset(Offset = "0x70")]
		private bool playbackStarted;
	}
}
