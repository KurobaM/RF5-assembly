using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityNavMeshAgent
{
	// Token: 0x02001400 RID: 5120
	[Token(Token = "0x2000DCB")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151D30", Offset = "0x151E31")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151D30", Offset = "0x151E31")]
	public class ResetPath : Action
	{
		// Token: 0x06007699 RID: 30361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600634D")]
		[Address(RVA = "0x2986A70", Offset = "0x2986B71", VA = "0x2986A70", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600769A RID: 30362 RVA: 0x00029280 File Offset: 0x00027480
		[Token(Token = "0x600634E")]
		[Address(RVA = "0x2986B70", Offset = "0x2986C71", VA = "0x2986B70", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600769B RID: 30363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600634F")]
		[Address(RVA = "0x2986C50", Offset = "0x2986D51", VA = "0x2986C50", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600769C RID: 30364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006350")]
		[Address(RVA = "0x2986C60", Offset = "0x2986D61", VA = "0x2986C60")]
		public ResetPath()
		{
		}

		// Token: 0x0401B963 RID: 112995
		[Token(Token = "0x4018384")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D390", Offset = "0x18D491")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B964 RID: 112996
		[Token(Token = "0x4018385")]
		[FieldOffset(Offset = "0x58")]
		private NavMeshAgent navMeshAgent;

		// Token: 0x0401B965 RID: 112997
		[Token(Token = "0x4018386")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
