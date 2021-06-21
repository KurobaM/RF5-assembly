using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Timeline
{
	// Token: 0x02001347 RID: 4935
	[Token(Token = "0x2000D12")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D780", Offset = "0x14D881")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D780", Offset = "0x14D881")]
	public class Pause : Action
	{
		// Token: 0x06007401 RID: 29697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B5")]
		[Address(RVA = "0x28D1A90", Offset = "0x28D1B91", VA = "0x28D1A90", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007402 RID: 29698 RVA: 0x00028128 File Offset: 0x00026328
		[Token(Token = "0x60060B6")]
		[Address(RVA = "0x28D1B90", Offset = "0x28D1C91", VA = "0x28D1B90", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007403 RID: 29699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B7")]
		[Address(RVA = "0x28D1C70", Offset = "0x28D1D71", VA = "0x28D1C70", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007404 RID: 29700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B8")]
		[Address(RVA = "0x28D1C80", Offset = "0x28D1D81", VA = "0x28D1C80")]
		public Pause()
		{
		}

		// Token: 0x0401B6F3 RID: 112371
		[Token(Token = "0x4018114")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186870", Offset = "0x186971")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6F4 RID: 112372
		[Token(Token = "0x4018115")]
		[FieldOffset(Offset = "0x58")]
		private PlayableDirector playableDirector;

		// Token: 0x0401B6F5 RID: 112373
		[Token(Token = "0x4018116")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
