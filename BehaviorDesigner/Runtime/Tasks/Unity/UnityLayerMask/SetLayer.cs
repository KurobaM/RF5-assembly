using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityLayerMask
{
	// Token: 0x02001436 RID: 5174
	[Token(Token = "0x2000DFC")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152F90", Offset = "0x153091")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152F90", Offset = "0x153091")]
	public class SetLayer : Action
	{
		// Token: 0x06007746 RID: 30534 RVA: 0x00029718 File Offset: 0x00027918
		[Token(Token = "0x60063FA")]
		[Address(RVA = "0x28E6BC0", Offset = "0x28E6CC1", VA = "0x28E6BC0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007747 RID: 30535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063FB")]
		[Address(RVA = "0x28E6C70", Offset = "0x28E6D71", VA = "0x28E6C70", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007748 RID: 30536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063FC")]
		[Address(RVA = "0x28E6CE0", Offset = "0x28E6DE1", VA = "0x28E6CE0")]
		public SetLayer()
		{
		}

		// Token: 0x0401BA27 RID: 113191
		[Token(Token = "0x4018425")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18EF10", Offset = "0x18F011")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA28 RID: 113192
		[Token(Token = "0x4018426")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18EF50", Offset = "0x18F051")]
		public SharedString layerName;
	}
}
