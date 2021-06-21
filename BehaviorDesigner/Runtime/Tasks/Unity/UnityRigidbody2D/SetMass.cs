using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x02001396 RID: 5014
	[Token(Token = "0x2000D61")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F520", Offset = "0x14F621")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F520", Offset = "0x14F621")]
	public class SetMass : Action
	{
		// Token: 0x0600750E RID: 29966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061C2")]
		[Address(RVA = "0x29983F0", Offset = "0x29984F1", VA = "0x29983F0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600750F RID: 29967 RVA: 0x00028890 File Offset: 0x00026A90
		[Token(Token = "0x60061C3")]
		[Address(RVA = "0x29984F0", Offset = "0x29985F1", VA = "0x29984F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007510 RID: 29968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061C4")]
		[Address(RVA = "0x29985E0", Offset = "0x29986E1", VA = "0x29985E0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007511 RID: 29969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061C5")]
		[Address(RVA = "0x2998630", Offset = "0x2998731", VA = "0x2998630")]
		public SetMass()
		{
		}

		// Token: 0x0401B7CD RID: 112589
		[Token(Token = "0x40181EE")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189220", Offset = "0x189321")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7CE RID: 112590
		[Token(Token = "0x40181EF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189260", Offset = "0x189361")]
		public SharedFloat mass;

		// Token: 0x0401B7CF RID: 112591
		[Token(Token = "0x40181F0")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B7D0 RID: 112592
		[Token(Token = "0x40181F1")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
