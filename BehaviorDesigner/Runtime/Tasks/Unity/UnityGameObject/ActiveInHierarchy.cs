using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityGameObject
{
	// Token: 0x02001444 RID: 5188
	[Token(Token = "0x2000E0A")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1534D0", Offset = "0x1535D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1534D0", Offset = "0x1535D1")]
	public class ActiveInHierarchy : Conditional
	{
		// Token: 0x06007770 RID: 30576 RVA: 0x00029868 File Offset: 0x00027A68
		[Token(Token = "0x6006424")]
		[Address(RVA = "0x28E4BF0", Offset = "0x28E4CF1", VA = "0x28E4BF0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007771 RID: 30577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006425")]
		[Address(RVA = "0x28E4C80", Offset = "0x28E4D81", VA = "0x28E4C80", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007772 RID: 30578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006426")]
		[Address(RVA = "0x28E4C90", Offset = "0x28E4D91", VA = "0x28E4C90")]
		public ActiveInHierarchy()
		{
		}

		// Token: 0x0401BA3D RID: 113213
		[Token(Token = "0x401843B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F500", Offset = "0x18F601")]
		public SharedGameObject targetGameObject;
	}
}
