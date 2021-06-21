using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityNavMeshAgent
{
	// Token: 0x020013FD RID: 5117
	[Token(Token = "0x2000DC8")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151C10", Offset = "0x151D11")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151C10", Offset = "0x151D11")]
	public class GetSpeed : Action
	{
		// Token: 0x0600768D RID: 30349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006341")]
		[Address(RVA = "0x28EA1F0", Offset = "0x28EA2F1", VA = "0x28EA1F0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600768E RID: 30350 RVA: 0x00029238 File Offset: 0x00027438
		[Token(Token = "0x6006342")]
		[Address(RVA = "0x28EA2F0", Offset = "0x28EA3F1", VA = "0x28EA2F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600768F RID: 30351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006343")]
		[Address(RVA = "0x28EA3E0", Offset = "0x28EA4E1", VA = "0x28EA3E0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007690 RID: 30352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006344")]
		[Address(RVA = "0x28EA430", Offset = "0x28EA531", VA = "0x28EA430")]
		public GetSpeed()
		{
		}

		// Token: 0x0401B958 RID: 112984
		[Token(Token = "0x4018379")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D240", Offset = "0x18D341")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B959 RID: 112985
		[Token(Token = "0x401837A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18D280", Offset = "0x18D381")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D280", Offset = "0x18D381")]
		public SharedFloat storeValue;

		// Token: 0x0401B95A RID: 112986
		[Token(Token = "0x401837B")]
		[FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		// Token: 0x0401B95B RID: 112987
		[Token(Token = "0x401837C")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
