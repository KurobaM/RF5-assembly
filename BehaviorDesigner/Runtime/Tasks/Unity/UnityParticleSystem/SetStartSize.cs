using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013F3 RID: 5107
	[Token(Token = "0x2000DBE")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151850", Offset = "0x151951")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151850", Offset = "0x151951")]
	public class SetStartSize : Action
	{
		// Token: 0x06007665 RID: 30309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006319")]
		[Address(RVA = "0x298B6A0", Offset = "0x298B7A1", VA = "0x298B6A0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007666 RID: 30310 RVA: 0x00029148 File Offset: 0x00027348
		[Token(Token = "0x600631A")]
		[Address(RVA = "0x298B7A0", Offset = "0x298B8A1", VA = "0x298B7A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007667 RID: 30311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600631B")]
		[Address(RVA = "0x298B8D0", Offset = "0x298B9D1", VA = "0x298B8D0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007668 RID: 30312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600631C")]
		[Address(RVA = "0x298B920", Offset = "0x298BA21", VA = "0x298B920")]
		public SetStartSize()
		{
		}

		// Token: 0x0401B931 RID: 112945
		[Token(Token = "0x4018352")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CD30", Offset = "0x18CE31")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B932 RID: 112946
		[Token(Token = "0x4018353")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CD70", Offset = "0x18CE71")]
		public SharedFloat startSize;

		// Token: 0x0401B933 RID: 112947
		[Token(Token = "0x4018354")]
		[FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B934 RID: 112948
		[Token(Token = "0x4018355")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
