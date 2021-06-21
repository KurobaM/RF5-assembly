using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013EB RID: 5099
	[Token(Token = "0x2000DB6")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151550", Offset = "0x151651")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151550", Offset = "0x151651")]
	public class SetEnableEmission : Action
	{
		// Token: 0x06007645 RID: 30277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062F9")]
		[Address(RVA = "0x298A260", Offset = "0x298A361", VA = "0x298A260", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007646 RID: 30278 RVA: 0x00029088 File Offset: 0x00027288
		[Token(Token = "0x60062FA")]
		[Address(RVA = "0x298A360", Offset = "0x298A461", VA = "0x298A360", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007647 RID: 30279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062FB")]
		[Address(RVA = "0x298A470", Offset = "0x298A571", VA = "0x298A470", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007648 RID: 30280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062FC")]
		[Address(RVA = "0x298A4C0", Offset = "0x298A5C1", VA = "0x298A4C0")]
		public SetEnableEmission()
		{
		}

		// Token: 0x0401B911 RID: 112913
		[Token(Token = "0x4018332")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C930", Offset = "0x18CA31")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B912 RID: 112914
		[Token(Token = "0x4018333")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C970", Offset = "0x18CA71")]
		public SharedBool enable;

		// Token: 0x0401B913 RID: 112915
		[Token(Token = "0x4018334")]
		[FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B914 RID: 112916
		[Token(Token = "0x4018335")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
