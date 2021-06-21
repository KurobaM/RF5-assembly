using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityString
{
	// Token: 0x02001358 RID: 4952
	[Token(Token = "0x2000D23")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14DDE0", Offset = "0x14DEE1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14DDE0", Offset = "0x14DEE1")]
	public class SetString : Action
	{
		// Token: 0x06007439 RID: 29753 RVA: 0x000282C0 File Offset: 0x000264C0
		[Token(Token = "0x60060ED")]
		[Address(RVA = "0x299A330", Offset = "0x299A431", VA = "0x299A330", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600743A RID: 29754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060EE")]
		[Address(RVA = "0x299A3B0", Offset = "0x299A4B1", VA = "0x299A3B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600743B RID: 29755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060EF")]
		[Address(RVA = "0x299A430", Offset = "0x299A531", VA = "0x299A430")]
		public SetString()
		{
		}

		// Token: 0x0401B71F RID: 112415
		[Token(Token = "0x4018140")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187120", Offset = "0x187221")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x187120", Offset = "0x187221")]
		public SharedString variable;

		// Token: 0x0401B720 RID: 112416
		[Token(Token = "0x4018141")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187170", Offset = "0x187271")]
		public SharedString value;
	}
}
