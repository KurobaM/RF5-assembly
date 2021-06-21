using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013DC RID: 5084
	[Token(Token = "0x2000DA7")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150FB0", Offset = "0x1510B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150FB0", Offset = "0x1510B1")]
	public class GetDuration : Action
	{
		// Token: 0x06007609 RID: 30217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062BD")]
		[Address(RVA = "0x29880B0", Offset = "0x29881B1", VA = "0x29880B0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600760A RID: 30218 RVA: 0x00028F20 File Offset: 0x00027120
		[Token(Token = "0x60062BE")]
		[Address(RVA = "0x29881B0", Offset = "0x29882B1", VA = "0x29881B0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600760B RID: 30219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062BF")]
		[Address(RVA = "0x29882C0", Offset = "0x29883C1", VA = "0x29882C0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600760C RID: 30220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062C0")]
		[Address(RVA = "0x2988310", Offset = "0x2988411", VA = "0x2988310")]
		public GetDuration()
		{
		}

		// Token: 0x0401B8DB RID: 112859
		[Token(Token = "0x40182FC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C2B0", Offset = "0x18C3B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B8DC RID: 112860
		[Token(Token = "0x40182FD")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C2F0", Offset = "0x18C3F1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18C2F0", Offset = "0x18C3F1")]
		public SharedFloat storeResult;

		// Token: 0x0401B8DD RID: 112861
		[Token(Token = "0x40182FE")]
		[FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B8DE RID: 112862
		[Token(Token = "0x40182FF")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
