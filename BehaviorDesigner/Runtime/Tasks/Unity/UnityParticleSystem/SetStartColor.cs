using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013EF RID: 5103
	[Token(Token = "0x2000DBA")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1516D0", Offset = "0x1517D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1516D0", Offset = "0x1517D1")]
	public class SetStartColor : Action
	{
		// Token: 0x06007655 RID: 30293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006309")]
		[Address(RVA = "0x298AC50", Offset = "0x298AD51", VA = "0x298AC50", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007656 RID: 30294 RVA: 0x000290E8 File Offset: 0x000272E8
		[Token(Token = "0x600630A")]
		[Address(RVA = "0x298AD50", Offset = "0x298AE51", VA = "0x298AD50", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007657 RID: 30295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600630B")]
		[Address(RVA = "0x298AE90", Offset = "0x298AF91", VA = "0x298AE90", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007658 RID: 30296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600630C")]
		[Address(RVA = "0x298AEE0", Offset = "0x298AFE1", VA = "0x298AEE0")]
		public SetStartColor()
		{
		}

		// Token: 0x0401B921 RID: 112929
		[Token(Token = "0x4018342")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CB30", Offset = "0x18CC31")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B922 RID: 112930
		[Token(Token = "0x4018343")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CB70", Offset = "0x18CC71")]
		public SharedColor startColor;

		// Token: 0x0401B923 RID: 112931
		[Token(Token = "0x4018344")]
		[FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B924 RID: 112932
		[Token(Token = "0x4018345")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
