using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013A2 RID: 5026
	[Token(Token = "0x2000D6D")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F9F0", Offset = "0x14FAF1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F9F0", Offset = "0x14FAF1")]
	public class GetCenterOfMass : Action
	{
		// Token: 0x0600753E RID: 30014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F2")]
		[Address(RVA = "0x2991030", Offset = "0x2991131", VA = "0x2991030", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600753F RID: 30015 RVA: 0x000289B0 File Offset: 0x00026BB0
		[Token(Token = "0x60061F3")]
		[Address(RVA = "0x2991130", Offset = "0x2991231", VA = "0x2991130", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007540 RID: 30016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F4")]
		[Address(RVA = "0x2991220", Offset = "0x2991321", VA = "0x2991220", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007541 RID: 30017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F5")]
		[Address(RVA = "0x29912B0", Offset = "0x29913B1", VA = "0x29912B0")]
		public GetCenterOfMass()
		{
		}

		// Token: 0x0401B805 RID: 112645
		[Token(Token = "0x4018226")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189A40", Offset = "0x189B41")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B806 RID: 112646
		[Token(Token = "0x4018227")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189A80", Offset = "0x189B81")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x189A80", Offset = "0x189B81")]
		public SharedVector3 storeValue;

		// Token: 0x0401B807 RID: 112647
		[Token(Token = "0x4018228")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B808 RID: 112648
		[Token(Token = "0x4018229")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
