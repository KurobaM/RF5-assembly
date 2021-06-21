using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Timeline
{
	// Token: 0x0200134A RID: 4938
	[Token(Token = "0x2000D15")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D8A0", Offset = "0x14D9A1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D8A0", Offset = "0x14D9A1")]
	public class Stop : Action
	{
		// Token: 0x0600740D RID: 29709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C1")]
		[Address(RVA = "0x28D2280", Offset = "0x28D2381", VA = "0x28D2280", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600740E RID: 29710 RVA: 0x00028170 File Offset: 0x00026370
		[Token(Token = "0x60060C2")]
		[Address(RVA = "0x28D2380", Offset = "0x28D2481", VA = "0x28D2380", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600740F RID: 29711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C3")]
		[Address(RVA = "0x28D2460", Offset = "0x28D2561", VA = "0x28D2460", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007410 RID: 29712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C4")]
		[Address(RVA = "0x28D2470", Offset = "0x28D2571", VA = "0x28D2470")]
		public Stop()
		{
		}

		// Token: 0x0401B701 RID: 112385
		[Token(Token = "0x4018122")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1869F0", Offset = "0x186AF1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B702 RID: 112386
		[Token(Token = "0x4018123")]
		[FieldOffset(Offset = "0x58")]
		private PlayableDirector playableDirector;

		// Token: 0x0401B703 RID: 112387
		[Token(Token = "0x4018124")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
