using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityNavMeshAgent
{
	// Token: 0x02001404 RID: 5124
	[Token(Token = "0x2000DCF")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151EB0", Offset = "0x151FB1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151EB0", Offset = "0x151FB1")]
	public class SetDestination : Action
	{
		// Token: 0x060076A9 RID: 30377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600635D")]
		[Address(RVA = "0x2987310", Offset = "0x2987411", VA = "0x2987310", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060076AA RID: 30378 RVA: 0x000292E0 File Offset: 0x000274E0
		[Token(Token = "0x600635E")]
		[Address(RVA = "0x2987410", Offset = "0x2987511", VA = "0x2987410", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076AB RID: 30379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600635F")]
		[Address(RVA = "0x2987510", Offset = "0x2987611", VA = "0x2987510", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076AC RID: 30380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006360")]
		[Address(RVA = "0x29875A0", Offset = "0x29876A1", VA = "0x29875A0")]
		public SetDestination()
		{
		}

		// Token: 0x0401B971 RID: 113009
		[Token(Token = "0x4018392")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D510", Offset = "0x18D611")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B972 RID: 113010
		[Token(Token = "0x4018393")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18D550", Offset = "0x18D651")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D550", Offset = "0x18D651")]
		public SharedVector3 destination;

		// Token: 0x0401B973 RID: 113011
		[Token(Token = "0x4018394")]
		[FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		// Token: 0x0401B974 RID: 113012
		[Token(Token = "0x4018395")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
