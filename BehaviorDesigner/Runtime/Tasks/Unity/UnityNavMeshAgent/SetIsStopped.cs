using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityNavMeshAgent
{
	// Token: 0x02001405 RID: 5125
	[Token(Token = "0x2000DD0")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151F10", Offset = "0x152011")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151F10", Offset = "0x152011")]
	public class SetIsStopped : Action
	{
		// Token: 0x060076AD RID: 30381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006361")]
		[Address(RVA = "0x29875B0", Offset = "0x29876B1", VA = "0x29875B0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060076AE RID: 30382 RVA: 0x000292F8 File Offset: 0x000274F8
		[Token(Token = "0x6006362")]
		[Address(RVA = "0x29876B0", Offset = "0x29877B1", VA = "0x29876B0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076AF RID: 30383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006363")]
		[Address(RVA = "0x29877B0", Offset = "0x29878B1", VA = "0x29877B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076B0 RID: 30384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006364")]
		[Address(RVA = "0x29877C0", Offset = "0x29878C1", VA = "0x29877C0")]
		public SetIsStopped()
		{
		}

		// Token: 0x0401B975 RID: 113013
		[Token(Token = "0x4018396")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D5A0", Offset = "0x18D6A1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B976 RID: 113014
		[Token(Token = "0x4018397")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D5E0", Offset = "0x18D6E1")]
		public SharedBool isStopped;

		// Token: 0x0401B977 RID: 113015
		[Token(Token = "0x4018398")]
		[FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		// Token: 0x0401B978 RID: 113016
		[Token(Token = "0x4018399")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
