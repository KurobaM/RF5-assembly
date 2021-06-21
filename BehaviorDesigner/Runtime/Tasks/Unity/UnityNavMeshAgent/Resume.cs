using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityNavMeshAgent
{
	// Token: 0x02001401 RID: 5121
	[Token(Token = "0x2000DCC")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151D90", Offset = "0x151E91")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151D90", Offset = "0x151E91")]
	public class Resume : Action
	{
		// Token: 0x0600769D RID: 30365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006351")]
		[Address(RVA = "0x2986C70", Offset = "0x2986D71", VA = "0x2986C70", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600769E RID: 30366 RVA: 0x00029298 File Offset: 0x00027498
		[Token(Token = "0x6006352")]
		[Address(RVA = "0x2986D70", Offset = "0x2986E71", VA = "0x2986D70", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600769F RID: 30367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006353")]
		[Address(RVA = "0x2986E50", Offset = "0x2986F51", VA = "0x2986E50", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076A0 RID: 30368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006354")]
		[Address(RVA = "0x2986E60", Offset = "0x2986F61", VA = "0x2986E60")]
		public Resume()
		{
		}

		// Token: 0x0401B966 RID: 112998
		[Token(Token = "0x4018387")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D3D0", Offset = "0x18D4D1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B967 RID: 112999
		[Token(Token = "0x4018388")]
		[FieldOffset(Offset = "0x58")]
		private NavMeshAgent navMeshAgent;

		// Token: 0x0401B968 RID: 113000
		[Token(Token = "0x4018389")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
