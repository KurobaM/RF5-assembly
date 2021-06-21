using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTime
{
	// Token: 0x0200134B RID: 4939
	[Token(Token = "0x2000D16")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D900", Offset = "0x14DA01")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D900", Offset = "0x14DA01")]
	public class GetDeltaTime : Action
	{
		// Token: 0x06007411 RID: 29713 RVA: 0x00028188 File Offset: 0x00026388
		[Token(Token = "0x60060C5")]
		[Address(RVA = "0x299A440", Offset = "0x299A541", VA = "0x299A440", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007412 RID: 29714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C6")]
		[Address(RVA = "0x299A4B0", Offset = "0x299A5B1", VA = "0x299A4B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007413 RID: 29715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C7")]
		[Address(RVA = "0x299A4F0", Offset = "0x299A5F1", VA = "0x299A4F0")]
		public GetDeltaTime()
		{
		}

		// Token: 0x0401B704 RID: 112388
		[Token(Token = "0x4018125")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186A30", Offset = "0x186B31")]
		public SharedFloat storeResult;
	}
}
