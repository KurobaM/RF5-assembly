using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013DE RID: 5086
	[Token(Token = "0x2000DA9")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151070", Offset = "0x151171")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151070", Offset = "0x151171")]
	public class GetEnableEmission : Action
	{
		// Token: 0x06007611 RID: 30225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062C5")]
		[Address(RVA = "0x2988570", Offset = "0x2988671", VA = "0x2988570", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007612 RID: 30226 RVA: 0x00028F50 File Offset: 0x00027150
		[Token(Token = "0x60062C6")]
		[Address(RVA = "0x2988670", Offset = "0x2988771", VA = "0x2988670", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007613 RID: 30227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062C7")]
		[Address(RVA = "0x2988790", Offset = "0x2988891", VA = "0x2988790", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007614 RID: 30228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062C8")]
		[Address(RVA = "0x29887E0", Offset = "0x29888E1", VA = "0x29887E0")]
		public GetEnableEmission()
		{
		}

		// Token: 0x0401B8E3 RID: 112867
		[Token(Token = "0x4018304")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C3D0", Offset = "0x18C4D1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B8E4 RID: 112868
		[Token(Token = "0x4018305")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C410", Offset = "0x18C511")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18C410", Offset = "0x18C511")]
		public SharedBool storeResult;

		// Token: 0x0401B8E5 RID: 112869
		[Token(Token = "0x4018306")]
		[FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B8E6 RID: 112870
		[Token(Token = "0x4018307")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
