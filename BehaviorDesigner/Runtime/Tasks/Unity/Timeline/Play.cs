using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Timeline
{
	// Token: 0x02001348 RID: 4936
	[Token(Token = "0x2000D13")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D7E0", Offset = "0x14D8E1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D7E0", Offset = "0x14D8E1")]
	public class Play : Action
	{
		// Token: 0x06007405 RID: 29701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B9")]
		[Address(RVA = "0x28D1C90", Offset = "0x28D1D91", VA = "0x28D1C90", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007406 RID: 29702 RVA: 0x00028140 File Offset: 0x00026340
		[Token(Token = "0x60060BA")]
		[Address(RVA = "0x28D1D90", Offset = "0x28D1E91", VA = "0x28D1D90", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007407 RID: 29703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060BB")]
		[Address(RVA = "0x28D1F60", Offset = "0x28D2061", VA = "0x28D1F60", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007408 RID: 29704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060BC")]
		[Address(RVA = "0x28D1FB0", Offset = "0x28D20B1", VA = "0x28D1FB0")]
		public Play()
		{
		}

		// Token: 0x0401B6F6 RID: 112374
		[Token(Token = "0x4018117")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1868B0", Offset = "0x1869B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6F7 RID: 112375
		[Token(Token = "0x4018118")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1868F0", Offset = "0x1869F1")]
		public PlayableAsset playableAsset;

		// Token: 0x0401B6F8 RID: 112376
		[Token(Token = "0x4018119")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186930", Offset = "0x186A31")]
		public SharedBool stopWhenComplete;

		// Token: 0x0401B6F9 RID: 112377
		[Token(Token = "0x401811A")]
		[FieldOffset(Offset = "0x68")]
		private PlayableDirector playableDirector;

		// Token: 0x0401B6FA RID: 112378
		[Token(Token = "0x401811B")]
		[FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		// Token: 0x0401B6FB RID: 112379
		[Token(Token = "0x401811C")]
		[FieldOffset(Offset = "0x78")]
		private bool playbackStarted;
	}
}
