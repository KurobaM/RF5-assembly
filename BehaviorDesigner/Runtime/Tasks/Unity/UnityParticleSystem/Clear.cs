using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013DB RID: 5083
	[Token(Token = "0x2000DA6")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150F50", Offset = "0x151051")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150F50", Offset = "0x151051")]
	public class Clear : Action
	{
		// Token: 0x06007605 RID: 30213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B9")]
		[Address(RVA = "0x2987EB0", Offset = "0x2987FB1", VA = "0x2987EB0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007606 RID: 30214 RVA: 0x00028F08 File Offset: 0x00027108
		[Token(Token = "0x60062BA")]
		[Address(RVA = "0x2987FB0", Offset = "0x29880B1", VA = "0x2987FB0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007607 RID: 30215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062BB")]
		[Address(RVA = "0x2988090", Offset = "0x2988191", VA = "0x2988090", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007608 RID: 30216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062BC")]
		[Address(RVA = "0x29880A0", Offset = "0x29881A1", VA = "0x29880A0")]
		public Clear()
		{
		}

		// Token: 0x0401B8D8 RID: 112856
		[Token(Token = "0x40182F9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C270", Offset = "0x18C371")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B8D9 RID: 112857
		[Token(Token = "0x40182FA")]
		[FieldOffset(Offset = "0x58")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B8DA RID: 112858
		[Token(Token = "0x40182FB")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
