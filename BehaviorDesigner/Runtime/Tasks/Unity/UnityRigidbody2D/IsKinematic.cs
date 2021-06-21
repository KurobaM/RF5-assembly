using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x0200138D RID: 5005
	[Token(Token = "0x2000D58")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F1C0", Offset = "0x14F2C1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F1C0", Offset = "0x14F2C1")]
	public class IsKinematic : Conditional
	{
		// Token: 0x060074EA RID: 29930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600619E")]
		[Address(RVA = "0x2996F70", Offset = "0x2997071", VA = "0x2996F70", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060074EB RID: 29931 RVA: 0x000287B8 File Offset: 0x000269B8
		[Token(Token = "0x600619F")]
		[Address(RVA = "0x2997070", Offset = "0x2997171", VA = "0x2997070", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074EC RID: 29932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061A0")]
		[Address(RVA = "0x2997150", Offset = "0x2997251", VA = "0x2997150", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074ED RID: 29933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061A1")]
		[Address(RVA = "0x2997160", Offset = "0x2997261", VA = "0x2997160")]
		public IsKinematic()
		{
		}

		// Token: 0x0401B7AB RID: 112555
		[Token(Token = "0x40181CC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188E20", Offset = "0x188F21")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7AC RID: 112556
		[Token(Token = "0x40181CD")]
		[FieldOffset(Offset = "0x58")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B7AD RID: 112557
		[Token(Token = "0x40181CE")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
