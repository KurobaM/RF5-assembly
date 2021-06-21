using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013DF RID: 5087
	[Token(Token = "0x2000DAA")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1510D0", Offset = "0x1511D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1510D0", Offset = "0x1511D1")]
	public class GetLoop : Action
	{
		// Token: 0x06007615 RID: 30229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062C9")]
		[Address(RVA = "0x29887F0", Offset = "0x29888F1", VA = "0x29887F0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007616 RID: 30230 RVA: 0x00028F68 File Offset: 0x00027168
		[Token(Token = "0x60062CA")]
		[Address(RVA = "0x29888F0", Offset = "0x29889F1", VA = "0x29888F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007617 RID: 30231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062CB")]
		[Address(RVA = "0x2988A10", Offset = "0x2988B11", VA = "0x2988A10", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007618 RID: 30232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062CC")]
		[Address(RVA = "0x2988A60", Offset = "0x2988B61", VA = "0x2988A60")]
		public GetLoop()
		{
		}

		// Token: 0x0401B8E7 RID: 112871
		[Token(Token = "0x4018308")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C460", Offset = "0x18C561")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B8E8 RID: 112872
		[Token(Token = "0x4018309")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C4A0", Offset = "0x18C5A1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18C4A0", Offset = "0x18C5A1")]
		public SharedBool storeResult;

		// Token: 0x0401B8E9 RID: 112873
		[Token(Token = "0x401830A")]
		[FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B8EA RID: 112874
		[Token(Token = "0x401830B")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
