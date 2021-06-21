using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityString
{
	// Token: 0x02001357 RID: 4951
	[Token(Token = "0x2000D22")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14DD80", Offset = "0x14DE81")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14DD80", Offset = "0x14DE81")]
	public class Replace : Action
	{
		// Token: 0x06007436 RID: 29750 RVA: 0x000282A8 File Offset: 0x000264A8
		[Token(Token = "0x60060EA")]
		[Address(RVA = "0x299A190", Offset = "0x299A291", VA = "0x299A190", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007437 RID: 29751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060EB")]
		[Address(RVA = "0x299A260", Offset = "0x299A361", VA = "0x299A260", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007438 RID: 29752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060EC")]
		[Address(RVA = "0x299A320", Offset = "0x299A421", VA = "0x299A320")]
		public Replace()
		{
		}

		// Token: 0x0401B71B RID: 112411
		[Token(Token = "0x401813C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187010", Offset = "0x187111")]
		public SharedString targetString;

		// Token: 0x0401B71C RID: 112412
		[Token(Token = "0x401813D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187050", Offset = "0x187151")]
		public SharedString oldString;

		// Token: 0x0401B71D RID: 112413
		[Token(Token = "0x401813E")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187090", Offset = "0x187191")]
		public SharedString newString;

		// Token: 0x0401B71E RID: 112414
		[Token(Token = "0x401813F")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1870D0", Offset = "0x1871D1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1870D0", Offset = "0x1871D1")]
		public SharedString storeResult;
	}
}
