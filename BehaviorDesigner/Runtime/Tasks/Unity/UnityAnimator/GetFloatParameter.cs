using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014A5 RID: 5285
	[Token(Token = "0x2000E6B")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155930", Offset = "0x155A31")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155930", Offset = "0x155A31")]
	public class GetFloatParameter : Action
	{
		// Token: 0x060078DF RID: 30943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006593")]
		[Address(RVA = "0x28D51F0", Offset = "0x28D52F1", VA = "0x28D51F0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078E0 RID: 30944 RVA: 0x0002A198 File Offset: 0x00028398
		[Token(Token = "0x6006594")]
		[Address(RVA = "0x28D52F0", Offset = "0x28D53F1", VA = "0x28D52F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078E1 RID: 30945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006595")]
		[Address(RVA = "0x28D5400", Offset = "0x28D5501", VA = "0x28D5400", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078E2 RID: 30946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006596")]
		[Address(RVA = "0x28D5490", Offset = "0x28D5591", VA = "0x28D5490")]
		public GetFloatParameter()
		{
		}

		// Token: 0x0401BB99 RID: 113561
		[Token(Token = "0x4018597")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192930", Offset = "0x192A31")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB9A RID: 113562
		[Token(Token = "0x4018598")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192970", Offset = "0x192A71")]
		public SharedString paramaterName;

		// Token: 0x0401BB9B RID: 113563
		[Token(Token = "0x4018599")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1929B0", Offset = "0x192AB1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1929B0", Offset = "0x192AB1")]
		public SharedFloat storeValue;

		// Token: 0x0401BB9C RID: 113564
		[Token(Token = "0x401859A")]
		[FieldOffset(Offset = "0x68")]
		private Animator animator;

		// Token: 0x0401BB9D RID: 113565
		[Token(Token = "0x401859B")]
		[FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;
	}
}
