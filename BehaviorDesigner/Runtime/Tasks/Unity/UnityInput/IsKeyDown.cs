using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityInput
{
	// Token: 0x02001440 RID: 5184
	[Token(Token = "0x2000E06")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153350", Offset = "0x153451")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153350", Offset = "0x153451")]
	public class IsKeyDown : Conditional
	{
		// Token: 0x06007764 RID: 30564 RVA: 0x00029808 File Offset: 0x00027A08
		[Token(Token = "0x6006418")]
		[Address(RVA = "0x28E6870", Offset = "0x28E6971", VA = "0x28E6870", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007765 RID: 30565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006419")]
		[Address(RVA = "0x28E68A0", Offset = "0x28E69A1", VA = "0x28E68A0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007766 RID: 30566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600641A")]
		[Address(RVA = "0x28E68B0", Offset = "0x28E69B1", VA = "0x28E68B0")]
		public IsKeyDown()
		{
		}

		// Token: 0x0401BA39 RID: 113209
		[Token(Token = "0x4018437")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F400", Offset = "0x18F501")]
		public KeyCode key;
	}
}
