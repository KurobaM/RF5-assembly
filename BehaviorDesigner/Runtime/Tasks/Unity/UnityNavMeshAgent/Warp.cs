using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityNavMeshAgent
{
	// Token: 0x02001408 RID: 5128
	[Token(Token = "0x2000DD3")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152030", Offset = "0x152131")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152030", Offset = "0x152131")]
	public class Warp : Action
	{
		// Token: 0x060076B9 RID: 30393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600636D")]
		[Address(RVA = "0x2987C20", Offset = "0x2987D21", VA = "0x2987C20", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060076BA RID: 30394 RVA: 0x00029340 File Offset: 0x00027540
		[Token(Token = "0x600636E")]
		[Address(RVA = "0x2987D20", Offset = "0x2987E21", VA = "0x2987D20", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076BB RID: 30395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600636F")]
		[Address(RVA = "0x2987E10", Offset = "0x2987F11", VA = "0x2987E10", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076BC RID: 30396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006370")]
		[Address(RVA = "0x2987EA0", Offset = "0x2987FA1", VA = "0x2987EA0")]
		public Warp()
		{
		}

		// Token: 0x0401B980 RID: 113024
		[Token(Token = "0x40183A1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D6E0", Offset = "0x18D7E1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B981 RID: 113025
		[Token(Token = "0x40183A2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D720", Offset = "0x18D821")]
		public SharedVector3 newPosition;

		// Token: 0x0401B982 RID: 113026
		[Token(Token = "0x40183A3")]
		[FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		// Token: 0x0401B983 RID: 113027
		[Token(Token = "0x40183A4")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
