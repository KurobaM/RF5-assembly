using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTime
{
	// Token: 0x0200134C RID: 4940
	[Token(Token = "0x2000D17")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D960", Offset = "0x14DA61")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D960", Offset = "0x14DA61")]
	public class GetRealtimeSinceStartup : Action
	{
		// Token: 0x06007414 RID: 29716 RVA: 0x000281A0 File Offset: 0x000263A0
		[Token(Token = "0x60060C8")]
		[Address(RVA = "0x299A500", Offset = "0x299A601", VA = "0x299A500", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007415 RID: 29717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060C9")]
		[Address(RVA = "0x299A570", Offset = "0x299A671", VA = "0x299A570", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007416 RID: 29718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060CA")]
		[Address(RVA = "0x299A5B0", Offset = "0x299A6B1", VA = "0x299A5B0")]
		public GetRealtimeSinceStartup()
		{
		}

		// Token: 0x0401B705 RID: 112389
		[Token(Token = "0x4018126")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186A70", Offset = "0x186B71")]
		public SharedFloat storeResult;
	}
}
