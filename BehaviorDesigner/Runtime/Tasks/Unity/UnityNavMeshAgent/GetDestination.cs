using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityNavMeshAgent
{
	// Token: 0x020013FA RID: 5114
	[Token(Token = "0x2000DC5")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151AF0", Offset = "0x151BF1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151AF0", Offset = "0x151BF1")]
	public class GetDestination : Action
	{
		// Token: 0x06007681 RID: 30337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006335")]
		[Address(RVA = "0x28E9AC0", Offset = "0x28E9BC1", VA = "0x28E9AC0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007682 RID: 30338 RVA: 0x000291F0 File Offset: 0x000273F0
		[Token(Token = "0x6006336")]
		[Address(RVA = "0x28E9BC0", Offset = "0x28E9CC1", VA = "0x28E9BC0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007683 RID: 30339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006337")]
		[Address(RVA = "0x28E9CB0", Offset = "0x28E9DB1", VA = "0x28E9CB0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007684 RID: 30340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006338")]
		[Address(RVA = "0x28E9D40", Offset = "0x28E9E41", VA = "0x28E9D40")]
		public GetDestination()
		{
		}

		// Token: 0x0401B94C RID: 112972
		[Token(Token = "0x401836D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D090", Offset = "0x18D191")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B94D RID: 112973
		[Token(Token = "0x401836E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18D0D0", Offset = "0x18D1D1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D0D0", Offset = "0x18D1D1")]
		public SharedVector3 storeValue;

		// Token: 0x0401B94E RID: 112974
		[Token(Token = "0x401836F")]
		[FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		// Token: 0x0401B94F RID: 112975
		[Token(Token = "0x4018370")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
