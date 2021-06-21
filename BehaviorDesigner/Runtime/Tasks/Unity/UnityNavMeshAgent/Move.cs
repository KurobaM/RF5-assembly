using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityNavMeshAgent
{
	// Token: 0x020013FF RID: 5119
	[Token(Token = "0x2000DCA")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151CD0", Offset = "0x151DD1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151CD0", Offset = "0x151DD1")]
	public class Move : Action
	{
		// Token: 0x06007695 RID: 30357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006349")]
		[Address(RVA = "0x29867E0", Offset = "0x29868E1", VA = "0x29867E0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007696 RID: 30358 RVA: 0x00029268 File Offset: 0x00027468
		[Token(Token = "0x600634A")]
		[Address(RVA = "0x29868E0", Offset = "0x29869E1", VA = "0x29868E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007697 RID: 30359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600634B")]
		[Address(RVA = "0x29869D0", Offset = "0x2986AD1", VA = "0x29869D0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007698 RID: 30360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600634C")]
		[Address(RVA = "0x2986A60", Offset = "0x2986B61", VA = "0x2986A60")]
		public Move()
		{
		}

		// Token: 0x0401B95F RID: 112991
		[Token(Token = "0x4018380")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D310", Offset = "0x18D411")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B960 RID: 112992
		[Token(Token = "0x4018381")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D350", Offset = "0x18D451")]
		public SharedVector3 offset;

		// Token: 0x0401B961 RID: 112993
		[Token(Token = "0x4018382")]
		[FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		// Token: 0x0401B962 RID: 112994
		[Token(Token = "0x4018383")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
