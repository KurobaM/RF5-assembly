using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityNavMeshAgent
{
	// Token: 0x020013FB RID: 5115
	[Token(Token = "0x2000DC6")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151B50", Offset = "0x151C51")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151B50", Offset = "0x151C51")]
	public class GetIsStopped : Action
	{
		// Token: 0x06007685 RID: 30341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006339")]
		[Address(RVA = "0x28E9D50", Offset = "0x28E9E51", VA = "0x28E9D50", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007686 RID: 30342 RVA: 0x00029208 File Offset: 0x00027408
		[Token(Token = "0x600633A")]
		[Address(RVA = "0x28E9E50", Offset = "0x28E9F51", VA = "0x28E9E50", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007687 RID: 30343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600633B")]
		[Address(RVA = "0x28E9F50", Offset = "0x28EA051", VA = "0x28E9F50", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007688 RID: 30344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600633C")]
		[Address(RVA = "0x28E9F90", Offset = "0x28EA091", VA = "0x28E9F90")]
		public GetIsStopped()
		{
		}

		// Token: 0x0401B950 RID: 112976
		[Token(Token = "0x4018371")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D120", Offset = "0x18D221")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B951 RID: 112977
		[Token(Token = "0x4018372")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18D160", Offset = "0x18D261")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D160", Offset = "0x18D261")]
		public SharedBool storeValue;

		// Token: 0x0401B952 RID: 112978
		[Token(Token = "0x4018373")]
		[FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		// Token: 0x0401B953 RID: 112979
		[Token(Token = "0x4018374")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
