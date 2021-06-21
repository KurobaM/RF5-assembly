using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014A3 RID: 5283
	[Token(Token = "0x2000E69")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155870", Offset = "0x155971")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155870", Offset = "0x155971")]
	public class GetDeltaPosition : Action
	{
		// Token: 0x060078D7 RID: 30935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600658B")]
		[Address(RVA = "0x28D4CD0", Offset = "0x28D4DD1", VA = "0x28D4CD0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078D8 RID: 30936 RVA: 0x0002A168 File Offset: 0x00028368
		[Token(Token = "0x600658C")]
		[Address(RVA = "0x28D4DD0", Offset = "0x28D4ED1", VA = "0x28D4DD0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078D9 RID: 30937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600658D")]
		[Address(RVA = "0x28D4EC0", Offset = "0x28D4FC1", VA = "0x28D4EC0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078DA RID: 30938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600658E")]
		[Address(RVA = "0x28D4F50", Offset = "0x28D5051", VA = "0x28D4F50")]
		public GetDeltaPosition()
		{
		}

		// Token: 0x0401BB91 RID: 113553
		[Token(Token = "0x401858F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192810", Offset = "0x192911")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB92 RID: 113554
		[Token(Token = "0x4018590")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192850", Offset = "0x192951")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x192850", Offset = "0x192951")]
		public SharedVector3 storeValue;

		// Token: 0x0401BB93 RID: 113555
		[Token(Token = "0x4018591")]
		[FieldOffset(Offset = "0x60")]
		private Animator animator;

		// Token: 0x0401BB94 RID: 113556
		[Token(Token = "0x4018592")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
