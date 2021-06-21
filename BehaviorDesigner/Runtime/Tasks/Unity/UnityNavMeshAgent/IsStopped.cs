using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityNavMeshAgent
{
	// Token: 0x020013FE RID: 5118
	[Token(Token = "0x2000DC9")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151C70", Offset = "0x151D71")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151C70", Offset = "0x151D71")]
	public class IsStopped : Conditional
	{
		// Token: 0x06007691 RID: 30353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006345")]
		[Address(RVA = "0x29865E0", Offset = "0x29866E1", VA = "0x29865E0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007692 RID: 30354 RVA: 0x00029250 File Offset: 0x00027450
		[Token(Token = "0x6006346")]
		[Address(RVA = "0x29866E0", Offset = "0x29867E1", VA = "0x29866E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007693 RID: 30355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006347")]
		[Address(RVA = "0x29867C0", Offset = "0x29868C1", VA = "0x29867C0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007694 RID: 30356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006348")]
		[Address(RVA = "0x29867D0", Offset = "0x29868D1", VA = "0x29867D0")]
		public IsStopped()
		{
		}

		// Token: 0x0401B95C RID: 112988
		[Token(Token = "0x401837D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D2D0", Offset = "0x18D3D1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B95D RID: 112989
		[Token(Token = "0x401837E")]
		[FieldOffset(Offset = "0x58")]
		private NavMeshAgent navMeshAgent;

		// Token: 0x0401B95E RID: 112990
		[Token(Token = "0x401837F")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
