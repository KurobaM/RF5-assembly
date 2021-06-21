using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityNavMeshAgent
{
	// Token: 0x02001403 RID: 5123
	[Token(Token = "0x2000DCE")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151E50", Offset = "0x151F51")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151E50", Offset = "0x151F51")]
	public class SetAngularSpeed : Action
	{
		// Token: 0x060076A5 RID: 30373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006359")]
		[Address(RVA = "0x29870C0", Offset = "0x29871C1", VA = "0x29870C0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060076A6 RID: 30374 RVA: 0x000292C8 File Offset: 0x000274C8
		[Token(Token = "0x600635A")]
		[Address(RVA = "0x29871C0", Offset = "0x29872C1", VA = "0x29871C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076A7 RID: 30375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600635B")]
		[Address(RVA = "0x29872B0", Offset = "0x29873B1", VA = "0x29872B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076A8 RID: 30376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600635C")]
		[Address(RVA = "0x2987300", Offset = "0x2987401", VA = "0x2987300")]
		public SetAngularSpeed()
		{
		}

		// Token: 0x0401B96D RID: 113005
		[Token(Token = "0x401838E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D490", Offset = "0x18D591")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B96E RID: 113006
		[Token(Token = "0x401838F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D4D0", Offset = "0x18D5D1")]
		public SharedFloat angularSpeed;

		// Token: 0x0401B96F RID: 113007
		[Token(Token = "0x4018390")]
		[FieldOffset(Offset = "0x60")]
		private NavMeshAgent navMeshAgent;

		// Token: 0x0401B970 RID: 113008
		[Token(Token = "0x4018391")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
